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
    public partial class Eleves : Form
    {
        string id,groupe;
        public List<Eleve> el = new List<Eleve>();
        public List<Matiere> matieres;
        public List<MaterialSkin.Controls.MaterialCheckBox> Matieres_bs = new List<MaterialSkin.Controls.MaterialCheckBox>();
        public List<MaterialSkin.Controls.MaterialRadioButton> Matieres_b = new List<MaterialSkin.Controls.MaterialRadioButton>();
        public Eleves(string id, List<Matiere> matieres, string groupe)
        {
            this.id = id;
            this.matieres = matieres;
            this.groupe = groupe;
            InitializeComponent();
            el.Clear();

            /*Login.read = DBConnect.
                Gets("SELECT id, id_massar, nom, prenom, nom_ar, prenom_ar, sexe, ville_naissance, ville_naissance_ar, adresse, date_naissance FROM etudiant, etudiant_groupe where id_groupe = " + id+" and id_etudiant = id");
            while (Login.read.Read())
            {
                //Login.read[7].ToString()
                Eleve e = new Eleve(Login.read[0].ToString(), Login.read[1].ToString(), Login.read[2].ToString(), Login.read[3].ToString(), Login.read[4].ToString(), Login.read[5].ToString(), Login.read[6].ToString(), Login.read[7].ToString(), Login.read[8].ToString(), Login.read[9].ToString());

                el.Add(e);
            }

            Login.read.Close();*/
            render_eleves(el);
            

        }


        public void render_eleves(List<Eleve> L)
        {
            dgv_eleves.Rows.Clear();
            foreach (Eleve e in L)
            {
                dgv_eleves.Rows.Add(e.nom, e.prenom, "Generer", e.id);
                
                //  var source = new BindingList<Eleve>(this.el);
                //  dgv_eleves.DataSource = source;
            }
        }

        public void homechart()
        {
            rdn.Visible = false;
            if (dgv_eleves.SelectedCells[0].RowIndex != -1)
            {
                foreach (MaterialSkin.Controls.MaterialCheckBox b in Matieres_bs)
                {
                    this.panel1.Controls.Remove(b);
                }
                chart c = new chart(chart_e, this.id);
                c.addChartByEtudiant(el[dgv_eleves.SelectedRows[0].Index].id);
                double moy = 0;
                foreach (var p in c.c.Series[0].Points)
                {
                    moy += p.YValues[0];
                }
                moy /= c.c.Series[0].Points.Count();
                moy = Math.Round(moy, 2);
                moy_g.Text = moy.ToString();
            }
        }

        public void rdnView()
        {
            foreach (MaterialSkin.Controls.MaterialCheckBox b in Matieres_bs)
            {
                this.panel1.Controls.Remove(b);
            }
            foreach (MaterialSkin.Controls.MaterialRadioButton b in Matieres_b)
            {
                this.panel1.Controls.Remove(b);
            }
            rdn.Rows.Clear();
            rdn.Columns.Clear();
            rdn.Visible = true;
            this.rdn.Columns.Add("Matière", "Matière");
            this.rdn.Columns.Add("Semestre1", "CC1");
            this.rdn.Columns.Add("Semestre1", "CC2");
            this.rdn.Columns.Add("Semestre1", "CC3");
            this.rdn.Columns.Add("Semestre1", "CC4");
            this.rdn.Columns.Add("Semestre1", "CC5");
            this.rdn.Columns.Add("Semestre2", "CC1");
            this.rdn.Columns.Add("Semestre2", "CC2");
            this.rdn.Columns.Add("Semestre2", "CC3");
            this.rdn.Columns.Add("Semestre2", "CC4");
            this.rdn.Columns.Add("Semestre2", "CC5");            

            for (int j = 0; j < rdn.ColumnCount; j++)

            {
                rdn.Columns[j].Width = rdn.Width/11;

            }

            string id_E = dgv_eleves.SelectedRows[0].Cells[3].Value.ToString();

            string id_annee = DBConnect.Get("SELECT id_annee from groupe where id = " + this.id);

            string sql = "select nom as matiere, sum(if(semestre = 1 and titre = 'cc1', note, null)) as s1cc1, " +
                "sum(if (semestre = 1 and titre = 'cc2', note, null)) as s1cc2, " +
                "sum(if (semestre = 1 and titre = 'cc3', note, null)) as s1cc3, " +
                "sum(if (semestre = 1 and titre = 'cc4', note, null)) as s1cc4, " +
                "sum(if (semestre = 1 and titre = 'cc5', note, null)) as s1cc5, " +
                "sum(if (semestre = 2 and titre = 'cc1', note, null)) as s2cc1, " +
                "sum(if (semestre = 2 and titre = 'cc2', note, null)) as s2cc2, " +
                "sum(if (semestre = 2 and titre = 'cc3', note, null)) as s2cc3, " +
                "sum(if (semestre = 2 and titre = 'cc4', note, null)) as s2cc4, " +
                "sum(if (semestre = 2 and titre = 'cc5', note, null)) as s2cc5 " +
                "from(SELECT nom, semestre, titre, avg(note) as note FROM examiner " +
                "LEFT OUTER JOIN matiere on examiner.id_matiere = matiere.id where id_etudiant = " + id_E + "and id_annee = " + id_annee +
                " group by nom, titre) as t2 GROUP by t2.nom, t2.semestre";
            Login.read = DBConnect.Gets(sql);
            while (Login.read.Read())
            {
                rdn.Rows.Add(Login.read[0], Login.read[1], Login.read[2], Login.read[3], Login.read[4], Login.read[5], Login.read[6], Login.read[7], Login.read[8], Login.read[9], Login.read[10]);
            }

            Login.read.Close();
        }

        private void dgv_eleves_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if(e.ColumnIndex == 0 || e.ColumnIndex == 1)
                {
                    rdnView();
                }
                if (e.ColumnIndex == 2) {
                    string s = "1";
                    if (radioButton2.Checked)
                        s = "2";
                    string id_E = dgv_eleves.SelectedRows[0].Cells[3].Value.ToString();
                    string nomm = dgv_eleves.SelectedRows[0].Cells[0].Value.ToString();
                    string prenomm = dgv_eleves.SelectedRows[0].Cells[1].Value.ToString();
                    if (DBConnect.Get("select semestre from examiner where id_etudiant=" + id_E + " and semestre=" + s) == "")
                    {
                        MessageBox.Show("semestre introuvable");
                        return;
                    }
                    using (FolderBrowserDialog dlg = new FolderBrowserDialog())
                    {
                        
                        dlg.Description = "Select a folder";
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            
                            
                                bulletin bul = new bulletin(dlg.SelectedPath + "\\" + "bulletin S" + s + " " + nomm + " " + prenomm + ".pdf", id_E, s, HomePreview.idann, "amana");



                            MessageBox.Show("Bulletin bien generee");
                        }
                    }


                    return;
                }
                foreach (MaterialSkin.Controls.MaterialCheckBox b in Matieres_bs)
                {
                    this.panel1.Controls.Remove(b);
                }
                foreach (MaterialSkin.Controls.MaterialRadioButton b in Matieres_b)
                {
                    this.panel1.Controls.Remove(b);
                }
                chart c = new chart(chart_e, this.id);
                c.addChartByEtudiant(el[e.RowIndex].id);
                double moy = 0;
                foreach (var p in c.c.Series[0].Points)
                {
                    moy += p.YValues[0];
                }
                moy /= c.c.Series[0].Points.Count();
                moy = Math.Round(moy, 2);
                moy_g.Text = moy.ToString();
            }
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            rdn.Visible = false;
            foreach (MaterialSkin.Controls.MaterialRadioButton b in Matieres_b)
            {
                this.panel1.Controls.Remove(b);
            }
            if (dgv_eleves.SelectedRows.Count == 1)
            {
                chart C = new chart(chart_e, this.id);
                //chart_e.DataManipulator.Statistics.Median.
                
                Eleve eleve = el[dgv_eleves.SelectedRows[0].Index];
                
                foreach (Matiere m in this.matieres)
                {
                    C.addChartEvolutionSeries(eleve, m);                  
                }
                Matieres_bs = C.series_bs;
                int y = chart_e.Location.Y;
                foreach (MaterialSkin.Controls.MaterialCheckBox b in Matieres_bs)
                {
                    b.Location = new Point(chart_e.Location.X + chart_e.Width + 10, y);
                    b.Parent = panel1;
                    y += 25;
                    b.Show();
                }
                
            }
        }

        private void chart_e_DoubleClick(object sender, EventArgs e)
        {
                chart.doubleCliick(sender, e);
        }

        private void Groupe_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            rdn.Visible = false;
            foreach (MaterialSkin.Controls.MaterialCheckBox b in Matieres_bs)
            {
                this.panel1.Controls.Remove(b);
            }
            foreach (MaterialSkin.Controls.MaterialRadioButton b in Matieres_b)
            {
                this.panel1.Controls.Remove(b);
            }
            if (dgv_eleves.SelectedRows.Count == 1)
            {
                chart C = new chart(chart_e, this.id);
                //chart_e.DataManipulator.Statistics.Median.

                Eleve eleve = el[dgv_eleves.SelectedRows[0].Index];
                
                C.addChartEvolutionAnneeEleve(eleve);
            }
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            foreach (MaterialSkin.Controls.MaterialRadioButton b in Matieres_b)
            {
                this.panel1.Controls.Remove(b);
            }
            homechart();
        }

        private void Eleves_Load(object sender, EventArgs e)
        {
            GroupeName.Text = groupe;
        }

        private void search_OnTextChange(object sender, EventArgs e)
        {
            List<Eleve> list = new List<Eleve>();
            if (search.text != "")
            {
                for (int i = 0; i < el.Count; i++)
                {
                    if (el[i].nom.ToUpper().Contains(search.text.ToUpper()) || el[i].prenom.ToUpper().Contains(search.text.ToUpper()))
                    {
                        list.Add(el[i]);
                    }
                }
                render_eleves(list);
                
            }
            else { render_eleves(el);  }

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            rdn.Visible = false;
            MaterialSkin.Controls.MaterialRadioButton bb = new MaterialSkin.Controls.MaterialRadioButton();
            foreach (MaterialSkin.Controls.MaterialCheckBox b in Matieres_bs)
            {
                this.panel1.Controls.Remove(b);
            }
            if (dgv_eleves.SelectedRows.Count == 1)
            {
                chart C = new chart(chart_e, this.id);           
                Eleve eleve = el[dgv_eleves.SelectedRows[0].Index];

                foreach (Matiere m in this.matieres)
                {                
                        C.addChartEvolutionUnites(eleve, m);
                }
                
                Matieres_b = C.series_bb;
                int y = chart_e.Location.Y;
                foreach (MaterialSkin.Controls.MaterialRadioButton l in Matieres_b)
                {
                    l.Location = new Point(chart_e.Location.X + chart_e.Width + 10, y);
                    l.Parent = panel1;
                    y += 25;
                    l.Show();
                    l.Checked = true;         
                }
                
                
            }

            

        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            rdnView();
        }

        private void dgv_eleves_SelectionChanged(object sender, EventArgs e)
        {
              
            
        }
    }
}
