using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassarAdminDesktop
{
    public partial class Previw : Form
    {
        List<int> notescols = new List<int>();
        List<int> notesrows = new List<int>();
        string path,fileName;
        public Form PreviewForm;
        string q;
        string id_groupe;
        string id_annee;
        public Previw()
        {
            InitializeComponent();

            

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel Files (.xlsx)|*.xlsx|Excel Files 2007 (.xlx)|*.xlx";
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName;
                fileName = open.SafeFileName;
            }
        }

        private void Previw_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }


        private void ColumnsOfNotes() {
            for (int i = 0; i < dataGridView1.ColumnCount; i++) {
                if (dataGridView1.Columns[i].HeaderText.Contains("النقطة"))
                    this.notescols.Add(i);
            }
 }
        private void rowsOfNotes()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value!=null && dataGridView1.Rows[i].Cells[0].Value.ToString().Trim().Length > 0)
                    this.notesrows.Add(i);

            }
        }
        private void Importer_b_Click(object sender, EventArgs e)
        {
            string query = "";
            if (this.q == "notes")
            {
                rowsOfNotes();
                ColumnsOfNotes();
                string semestre = label16.Text;
                if (semestre.Contains("الأولى")) semestre = "1";
                else semestre ="2";
                string titre =label17.Text;
                if (titre.Contains("الأول"))
                    titre = "cc1";
                else if (titre.Contains("الثاني"))
                    titre = "cc2";
                else if (titre.Contains("الثالث"))
                    titre = "cc3";
                else if (titre.Contains("الرابع"))
                    titre = "cc4";
                else if (titre.Contains("الخامس"))
                    titre = "cc5";
                else {
                    MessageBox.Show("veuillez respecter le format ");
                    return;
                }

                string matiere = label18.Text;//due label of matiere is empty
                DBConnect.Post("insert ignore into matiere values (null,'"+ matiere + "')");
                string idMatiere = DBConnect.Get("select id from matiere where nom='"+matiere+"'");
                this.id_annee = DBConnect.Get("select id from annee where annee_scolaire='" + label19.Text + "'");
                MessageBox.Show(this.id_annee);
                this.id_groupe = DBConnect.Get(string.Format("select id from groupe where nom = '{0}' and id_annee = {1}", label14.Text, this.id_annee));
                if (this.id_groupe == "") {
                    MessageBox.Show("groupe introuvable");
                    return;
                }
                query += "insert ignore into examiner values ";

                DBConnect.Post("insert ignore into enseignant (nom, prenom) values ('"+ label15.Text.Split(' ')[0] + "','" + label15.Text.Split(' ')[1] + "')");
                DBConnect.Post("insert ignore into groupe_matiere_enseignant values (" + idMatiere + "," + id_groupe + ", (select id from enseignant where nom='"+label15.Text.Split(' ')[0] +"' and prenom='" + label15.Text.Split(' ')[1] + "'))");
                MessageBox.Show(this.id_groupe);
                foreach (int row in this.notesrows)
                {
                    
                    foreach (int col in this.notescols)
                    {
                        query += string.Format(" ({0},{1},{2},{3},'{4}','{5}','{6}',{7}) ,",this.id_annee,this.id_groupe,dataGridView1.Rows[row].Cells[0].Value.ToString(),idMatiere,titre,semestre, dataGridView1.Columns[col].HeaderText,dataGridView1.Rows[row].Cells[col].Value.ToString());


                    }
                }
                query = query.Substring(0,query.Length-1);
                try
                {
                    DBConnect.Post(query);
                }
                catch (Exception exx) {
                    MessageBox.Show(exx.Message);
                }
            }
            else if(this.q == "info")
            {
                MessageBox.Show("_" + label31.Text + "_");
                this.id_annee = DBConnect.Get("select id from annee where annee_scolaire='" + label31.Text + "'");
                
                DBConnect.Post(string.Format("insert ignore into groupe values(null,'{0}',{1},{2})", label33.Text, label33.Text.Substring(0, 1), this.id_annee));
                
                this.id_groupe = DBConnect.Get(string.Format("select id from groupe where nom = '{0}' and id_annee = {1}", label33.Text, this.id_annee));
                string query3 = "insert into etudiant_groupe values ";
               
                query += "INSERT ignore INTO  etudiant  values ";
                foreach(DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.Cells[0].Value==null || r.Cells[0].Value.ToString().Trim().Length==0)
                        continue;
                    query += " ( ";
                    
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if (c.ColumnIndex == 0)
                        {
                            query += c.Value.ToString() + ",";
                            
                            query3 +="("+id_groupe+","+ c.Value.ToString() + "),";
                        }
                        
                        else query +="'"+ c.Value.ToString() + "',";

                    }
                    query = query.Substring(0, query.Length - 1);
                    query += ") ,";
                }
                query = query.Substring(0, query.Length - 1);
                query3 = query3.Substring(0, query3.Length - 1);
                DBConnect.Post(query);
                DBConnect.Post("delete from etudiant_groupe where id_groupe="+this.id_groupe);
                DBConnect.Post(query3);

            }
        }

        private void Previw_Load(object sender, EventArgs e)
        {
            if (path != null)
            {
                Excel excel = new Excel(path, "r");
                if (!excel.isOpen()) return;
                excel.setCheet(excel.getSheets());
                int w = 0;
                List<Label> label = new List<Label>();
                List<string> s = new List<string>();
                q = Controller.checkFile(path);
                if (q == "notes") //fichier = notes
                {
                    panel2.Visible = true;
                    panel3.Visible = false;
                    label = new List<Label>(){ label10, label11, label12, label13, label14, label15, label16, label17, label18, label19 };
                    s = new List<string>() { "أكاديمية :", "الإقليمية", "مؤسسة", "المستوى  :", "القسم  :", "الاستاذ", "الدورة  :", "نقط :", "المادة", "السنة الدراسية :" };
                    for (int i = 0; i < excel.find("ID")[0]; i++)
                    {
                        try
                        {
                            for (int j = 0; j < excel.sheet.GetRow(i).LastCellNum; j++)
                            {
                                string f = excel.getContent(i, j);
                                if (f.Contains(s[w]))
                                {
                                    bool t = true;
                                    for (int k = j + 1; k < excel.sheet.GetRow(i).LastCellNum; k++)
                                    {
                                        string b = excel.getContent(i, k);
                                        if (b != "" && !s.Contains(b))
                                        {
                                            label[w].Text = excel.getContent(i, k);
                                            w++;
                                            t = false;
                                            break;
                                        }

                                    }
                                    if (t) { label[w].Text = ""; w++; }
                                }

                            }
                        }
                        catch { }
                    }
                    int x = excel.find("ID")[0];
                    int y = excel.find("ID")[1];
                    int we = excel.sheet.GetRow(x).LastCellNum;
                    for (int j = y; j < excel.sheet.GetRow(x).LastCellNum; j++)
                    {
                        if (excel.getContent(x, j).Length == 0 && excel.getContent(x, j + 1).Length == 0 && excel.getContent(x, j + 2).Length == 0)
                        {
                            we = j;
                            break;
                        }
                    }
                    for (int i = x; i < excel.GetLastRow(); i++)
                    {
                        if (i == x)
                        {
                            int f = 0;
                            dataGridView1.ColumnCount = we - y;
                            for (int j = y; j < we; j++)
                            {
                                dataGridView1.Columns[f++].HeaderText = excel.getContent(i, j) + " " + excel.getContent(i + 1, j);  
                            }

                        }
                        else
                        {
                            if (excel.getContent(i+1, y) == "")
                            {
                                break;
                            }
                            dataGridView1.Rows.Add();
                            for (int j = y; j < we; j++)
                            {
                                try
                                {
                                    if ((float.Parse(excel.getContent(i + 1, j)) > 20 || float.Parse(excel.getContent(i + 1, j)) < 0) && j != y)
                                    {
                                        dataGridView1.Rows[i - x - 1].Cells[j - y].Style.BackColor = Color.DarkRed;
                                        Importer_b.Visible = false;
                                    }
                                }
                                catch { }
                                dataGridView1.Rows[i - x - 1].Cells[j - y].Value = excel.getContent(i+1, j);
                            }
                        }
                    }
                }
                else if (q == "info")
                {
                    panel2.Visible = true;
                    panel3.Visible = true;
                    label = new List<Label>() { label28, label29, label30, label31, label32, label33 };
                    s = new List<string>() { "أكاديمية :", "المذيرية الإقليمية :", "مؤسسة  :", "السنة الدراسية", "المستوى :", "القسم" };
                    for (int i = 0; i < excel.find("رقم التلميذ")[0] - 1; i++)
                    {
                        try
                        {
                            for (int j = 0; j < excel.sheet.GetRow(i).LastCellNum; j++)
                            {
                                string f = excel.getContent(i, j);
                                if (f.Contains(s[w]))
                                {
                                    bool t = true;
                                    for (int k = j + 1; k < excel.sheet.GetRow(i).LastCellNum; k++)
                                    {
                                        string b = excel.getContent(i, k);
                                        if (b != "" && !s.Contains(b))
                                        {
                                            label[w].Text = excel.getContent(i, k);
                                            w++;
                                            t = false;
                                            break;
                                        }

                                    }
                                    if (t) { label[w].Text = ""; w++; }
                                }

                            }
                        }
                        catch { }

                    }

                    int x = excel.find("رقم التلميذ")[0] - 1;
                    int y = excel.find("رقم التلميذ")[1] - 1;

                    for (int i = x; i < excel.GetLastRow(); i++)
                    {
                        if (i == x)
                        {
                            int f = 0;
                            dataGridView1.ColumnCount = excel.sheet.GetRow(i).LastCellNum - 1;
                            for (int j = y; j < excel.sheet.GetRow(i).LastCellNum; j++)
                            {
                                    dataGridView1.Columns[f++].HeaderText = excel.getContent(i, j) + " " + excel.getContent(i + 1, j);
                            }

                        }
                        else
                        {
                            dataGridView1.Rows.Add();
                            if (excel.getContent(i + 1, y) == "")
                            {
                                return;
                            }
                            for (int j = y; j < excel.sheet.GetRow(i + 1).LastCellNum; j++)
                            {
                                dataGridView1.Rows[i - x - 1].Cells[j - y].Value = excel.getContent(i + 1, j);
                            }
                        }
                    }
                }
                if (s != null)
                {
                    for (int i = 0; i < s.Count; i++)
                    {
                        if (label[i].Text == "")
                        {
                            materialLabel1.Text += "il faut saisir " + s[i] + "\n";
                        }
                    }
                    if (dataGridView1.Rows.Count == 0) materialLabel1.Text += "aucun eleves n'est trouve";
                    if (materialLabel1.Text != "") { groupBox1.Visible = true; materialLabel1.ForeColor = Color.Red; }
                }
                if (panel2.Visible || panel3.Visible || !groupBox1.Visible) { Importer_b.Visible = false; }
            }
          
        }
    }
}
