using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.IO;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace MassarAdminDesktop
{
    class bulletin
    {
        public Document document;
        PdfPTable table = new PdfPTable(4);
        string semestre;
        int aa = 0;
        string id;
        string annee;
        string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "C:\\Fonts\\ARIALUNI.TTF");
        BaseFont bf;
        Font myfont;
        public bulletin(string pdfdirectory, string id = "11671321", string semestre = "1", string annee = "2017/2018", string ecole = "amana")
        {

            


            this.semestre = semestre;
            this.id = id;
            this.annee = annee;
            bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            document = new Document();


            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(pdfdirectory, FileMode.Create));
            document.Open();
            writeline2(new string[] { "بيان النتائج الدراسية للدورة " + (semestre == "1" ? "الاولى" : "الثانية"), "الاكاديمية الجهوية للتربية و التكوين" }, 3, new int[] { 0, 1 }, 7);
            writeline2(new string[] { "Bulletin du " + (semestre == "1" ? "1 er" : "2 eme") + " semestre", "لجهة : طنجة تطوان" }, 3, new int[] { 0, 1 }, 7);
            writeline2(new string[] { "السنة الدراسية : " + annee, "نيابة : طنجة اصيلة" }, 3, new int[] { 0, 1 }, 10);
            writeline("مؤسسة : " + ecole, 3, 2, 10);
            iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance("C:\\Images\\img.png");
            pic.SetAbsolutePosition(390, 770);
            document.Add(new Paragraph("   \n"));
            pic.ScalePercent(((540 / 3) / pic.Width) * 100);
            document.Add(pic);
            MySqlDataReader r = DBConnect.Gets("select nom_ar,prenom_ar,groupe.nom,annee.annee_scolaire,id_massar from etudiant,groupe,annee,etudiant_groupe where etudiant.id=" + id + " and etudiant_groupe.id_etudiant=etudiant.id AND etudiant_groupe.id_groupe=groupe.id and groupe.id_annee=annee.id and annee.annee_scolaire='" + annee + "' ");
            while (r.Read())
            {
                writeline("المستوى : " + r[2].ToString().Substring(0, 1) + " ابتدائي", 1, 1, 20);
                writeline("القسم : " + r[2].ToString(), 1, 1, 20);
                writeline("اسم و رقم التلميذ : " + r[0].ToString() + " " + r[1].ToString() + " " + r[4].ToString(), 1, 1, 20);

            }
            document.Add(new Paragraph("   \n"));


            myfont = new Font(bf, 12, Font.NORMAL);
            add_table_topdf();
            PdfPTable resultat = new PdfPTable(new float[] { 1, 1, 1, 2 });
            string[] cols = { "المعدل العام", "الدورة الثانية", "الدورة الاولى", "" };
            foreach (string c in cols)
            {
                PdfPCell cell = new PdfPCell(new Phrase(c, myfont));
                cell.HorizontalAlignment = 1;
                cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                resultat.AddCell(cell);

            }

            r = DBConnect.Gets("select semestre ,avg(note) from examiner , annee where id_etudiant=" + id + " and id_annee=annee.id and annee.annee_scolaire='"+annee+"' group by semestre order by semestre ");
            int y = 0;
            List<Double> ff = new List<Double>();
            string s = "";
            while (r.Read())
            {
                s = r[0].ToString();
                ff.Add(Math.Round(Double.Parse(r[1].ToString()),2));
                y++;
            }
            if (y == 2)
            {
                PdfPCell cell = new PdfPCell(new Phrase(Math.Round(ff.Average(),2).ToString(), myfont));
                cell.HorizontalAlignment = 1;
                cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                resultat.AddCell(cell);
                PdfPCell cell1 = new PdfPCell(new Phrase(ff[1].ToString(), myfont));
                cell1.HorizontalAlignment = 1;
                cell1.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                resultat.AddCell(cell1);
                PdfPCell cell2 = new PdfPCell(new Phrase(ff[0].ToString(), myfont));
                cell2.HorizontalAlignment = 1;
                cell2.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                resultat.AddCell(cell2);
            }
            else if (y == 1)
            {
                string no = "";
                string no2 = "";
                if (s == "2")
                    no = ff[0].ToString();
                else no2= ff[0].ToString();
                PdfPCell cell = new PdfPCell(new Phrase("", myfont));
                cell.HorizontalAlignment = 1;
                cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                resultat.AddCell(cell);

                PdfPCell cell1 = new PdfPCell(new Phrase(no, myfont));
                cell1.HorizontalAlignment = 1;
                cell1.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                resultat.AddCell(cell1);

                PdfPCell cell2 = new PdfPCell(new Phrase(no2, myfont));
                cell2.HorizontalAlignment = 1;
                cell2.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                resultat.AddCell(cell2);
            }
            PdfPCell cell3 = new PdfPCell(new Phrase("معدل المراقبة المستمرة", myfont));
            cell3.HorizontalAlignment = 1;
            cell3.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            resultat.AddCell(cell3);
            r.Close();
            document.Add(new Paragraph("   \n"));
            resultat.WidthPercentage = 40;
            resultat.HorizontalAlignment = Element.ALIGN_RIGHT;





            PdfPTable absences = new PdfPTable(2);
            PdfPCell c1 = new PdfPCell(new Phrase("الغياب", myfont));
            c1.HorizontalAlignment = 1;
            c1.Colspan = 2;
            c1.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            absences.AddCell(c1);
            c1 = new PdfPCell(new Phrase("", myfont));
            c1.HorizontalAlignment = 1;

            c1.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            absences.AddCell(c1);
            c1 = new PdfPCell(new Phrase("مبرر", myfont));
            c1.HorizontalAlignment = 1;

            c1.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            absences.AddCell(c1);
            c1 = new PdfPCell(new Phrase("", myfont));
            c1.HorizontalAlignment = 1;

            c1.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            absences.AddCell(c1);
            c1 = new PdfPCell(new Phrase("غير مبرر", myfont));
            c1.HorizontalAlignment = 1;

            c1.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            absences.AddCell(c1);

            PdfPTable ch = new PdfPTable(new float[] { 4, 1, 4 });
            ch.WidthPercentage = 100;
            c1 = new PdfPCell(absences);
            c1.HorizontalAlignment = Element.ALIGN_LEFT;
            c1.Border = PdfPCell.NO_BORDER;
            ch.AddCell(c1);
            c1 = new PdfPCell(new Phrase("", myfont));
            c1.Border = PdfPCell.NO_BORDER;
            ch.AddCell(c1);
            c1 = new PdfPCell(resultat);
            c1.HorizontalAlignment = Element.ALIGN_RIGHT;
            c1.Border = PdfPCell.NO_BORDER;
            ch.AddCell(c1);
            ch.HorizontalAlignment = Element.ALIGN_BOTTOM;





            PdfPTable etat = new PdfPTable(new float[] { 1, 1, 1, 1, 2 });

            c1 = new PdfPCell(new Phrase("قرار اللجنة", myfont));
            c1.HorizontalAlignment = 1;
            c1.Colspan = 5;
            c1.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            etat.AddCell(c1);

            string[] cols2 = { "توبيخ", "انذار", "تنويه", "تشجيع", "لوحة الشرف", " ", " ", " ", " ", " " };
            foreach (string c in cols2)
            {
                PdfPCell cell = new PdfPCell(new Phrase(c, myfont));
                cell.HorizontalAlignment = 1;
                cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                etat.AddCell(cell);

            }

            PdfPTable notes = new PdfPTable(new float[] { 1, 1, 1 });

            c1 = new PdfPCell(new Phrase("الملاحظات العامة", myfont));
            c1.HorizontalAlignment = 1;
            c1.Colspan = 3;
            c1.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            notes.AddCell(c1);

            string[] cols3 = { "يفصل", "يكرر", "ينتقل", " ", " ", " " };
            foreach (string c in cols3)
            {
                PdfPCell cell = new PdfPCell(new Phrase(c, myfont));
                cell.HorizontalAlignment = 1;
                cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                notes.AddCell(cell);

            }
            document.Add(ch);
            document.Add(new Paragraph("   \n"));
            ch = new PdfPTable(new float[] { 4, 1, 4 });
            ch.WidthPercentage = 100;
            c1 = new PdfPCell(notes);
            c1.HorizontalAlignment = Element.ALIGN_LEFT;
            c1.Border = PdfPCell.NO_BORDER;
            ch.AddCell(c1);
            c1 = new PdfPCell(new Phrase("", myfont));
            c1.Border = PdfPCell.NO_BORDER;
            ch.AddCell(c1);
            c1 = new PdfPCell(etat);
            c1.HorizontalAlignment = Element.ALIGN_RIGHT;
            c1.Border = PdfPCell.NO_BORDER;
            ch.AddCell(c1);
            ch.HorizontalAlignment = Element.ALIGN_BOTTOM;

            document.Add(ch);
            document.Close();
        }

        void writeline(string line, int sections = 1, int section = 1, int size = 15, bool underline = false, bool bold = false)
        {

            PdfPTable table = new PdfPTable(sections);
            table.WidthPercentage = 100;

            // Font myfont = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, size, Convert.ToInt32(underline) * 1 | Convert.ToInt32(underline) * 4);
            Font myfont = new Font(bf, 10, Font.NORMAL);

            myfont.SetColor(0, 0, 144);

            for (int i = 1; i <= sections; i++)
            {
                string text = i == section ? line : "";
                PdfPCell cell = new PdfPCell(new Phrase(text, myfont));
                cell.Padding = 0;

                cell.Border = PdfPCell.NO_BORDER;
                cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                table.AddCell(cell);
            }
            document.Add(table);
            // document.Add(new Paragraph("   \n"));
        }
        void writeline2(string[] line, int sections, int[] section, int size)
        {

            PdfPTable table = new PdfPTable(sections);
            table.WidthPercentage = 100;

            // Font myfont = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, size, Convert.ToInt32(underline) * 1 | Convert.ToInt32(underline) * 4);
            Font myfont = new Font(bf, 10, Font.NORMAL);

            myfont.SetColor(0, 0, 144);
            int x = 0;
            for (int i = 0; i < sections; i++)
            {
                string text = x < 2 && i == section[x] ? line[x++] : "";
                PdfPCell cell = new PdfPCell(new Phrase(text, myfont));
                cell.Padding = 0;

                cell.Border = PdfPCell.NO_BORDER;
                cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                table.AddCell(cell);
            }
            document.Add(table);
            //  document.Add(new Paragraph("   \n"));
        }

        void add_table_topdf(int pourcentage = 100)
        {



            MySqlDataReader r = DBConnect.Gets("select etudiant.nom, matiere.nom ,examiner.unite, examiner.note,AVG(note)  FROM etudiant,matiere , examiner , annee WHERE semestre=" + semestre + " and etudiant.id=examiner.id_etudiant and examiner.id_etudiant="+id+" and matiere.id=examiner.id_matiere and id_annee=annee.id and annee.annee_scolaire='"+annee+"' GROUP by unite,examiner.id_matiere ORDER by examiner.id_matiere");
            string[] cols = { "ملاحظات الاساتذة", "نقط المراقبة المستمرة", "المكونات", "المواد" };
            foreach (string c in cols)
            {
                PdfPCell cell = new PdfPCell(new Phrase(c, myfont));
                cell.HorizontalAlignment = 1;
                cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                table.AddCell(cell);

            }
            table.WidthPercentage = pourcentage;
            string now = "", last = "", MATIERE = "";
            int x = 0;
            List<Double> n = new List<Double>();
            List<string> u = new List<string>();
            while (r.Read())
            {

                now = r[1].ToString();
                if (x++ == 0) last = now;
                if (now == last)
                {
                    MATIERE = r[1].ToString();
                    n.Add(Math.Round(Double.Parse(r[4].ToString()),2));
                    u.Add(r[2].ToString());
                }
                else
                {
                    doo(MATIERE, n, u);
                    n.Clear();
                    u.Clear();
                    MATIERE = r[1].ToString();
                    n.Add(Math.Round(Double.Parse(r[4].ToString()), 2));
                    u.Add(r[2].ToString());
                }
                last = now;



            }
            doo(MATIERE, n, u);
            document.Add(table);
            r.Close();

        }
        void doo(string m, List<Double> n, List<string> u)
        {
            for (int j = 0; j < n.Count; j++)
            {
                if (j == 0)
                {
                    PdfPCell cell1 = new PdfPCell(new Phrase("", myfont));
                    cell1.HorizontalAlignment = 1;
                    cell1.Rowspan = n.Count + 1;
                    cell1.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    table.AddCell(cell1);
                }
                PdfPCell cell2 = new PdfPCell(new Phrase(n[j].ToString(), myfont));
                cell2.HorizontalAlignment = 1;
                cell2.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                table.AddCell(cell2);
                PdfPCell cell3 = new PdfPCell(new Phrase(u[j], myfont));
                cell3.HorizontalAlignment = 1;
                cell3.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                table.AddCell(cell3);
                if (j == 0)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(m, myfont));
                    cell.HorizontalAlignment = 1;
                    
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    cell.Rowspan = n.Count + 1;
                    table.AddCell(cell);
                }
            }

            PdfPCell cell5 = new PdfPCell(new Phrase(Math.Round(n.Average(),2).ToString(), myfont));
            cell5.HorizontalAlignment = 1;
            cell5.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            table.AddCell(cell5);
            PdfPCell cell6 = new PdfPCell(new Phrase("معدل الوحدة", myfont));
            cell6.HorizontalAlignment = 1;
            cell6.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            table.AddCell(cell6);

        }

        void add_table_topdf2(DataTable note, int size = 15, int pourcentage = 100)
        {
            Font myfont = new Font(bf, 12, Font.NORMAL);
            PdfPTable table = new PdfPTable(note.Columns.Count);
            table.WidthPercentage = pourcentage;
            foreach (DataColumn c in note.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(c.ColumnName, myfont));
                cell.Rowspan = 2;
                cell.HorizontalAlignment = 1;
                cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                table.AddCell(cell);
            }


            foreach (DataRow r in note.Rows)
            {
                for (int i = 0; i < note.Columns.Count; i++)
                {

                    PdfPCell cell = new PdfPCell(new Phrase(r[i].ToString(), myfont));
                    cell.HorizontalAlignment = 1;
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    if (i == 3 && aa++ % 2 == 0)
                        cell.Rowspan = 2;
                    else if (i == 3) continue;
                    table.AddCell(cell);
                }
            }
            document.Add(table);

        }

    }
}
