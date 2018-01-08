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
        string id;
        public List<Eleve> el = new List<Eleve>();
        public List<Matiere> matieres;
        public List<MaterialSkin.Controls.MaterialCheckBox> Matieres_bs = new List<MaterialSkin.Controls.MaterialCheckBox>(); 
        public Eleves(string id, List<Matiere> matieres)
        {
            this.id = id;
            this.matieres = matieres;
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
            render_eleves();

        }

        
        public void render_eleves()
        {
            /*foreach (Eleve e in this.el)
                dgv_eleves.Rows.Add(e.nom, e.prenom, e.moyenne(id));*/
            var source = new BindingList<Eleve>(this.el);
            dgv_eleves.DataSource = source;
        }

        private void dgv_eleves_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                foreach (MaterialSkin.Controls.MaterialCheckBox b in Matieres_bs)
                {
                    this.panel1.Controls.Remove(b);
                }
                chart c = new chart(chart_e, this.id);
                c.addChartByEtudiant(el[e.RowIndex].id);
            }
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
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
                int y = 0;
                foreach (MaterialSkin.Controls.MaterialCheckBox b in Matieres_bs)
                {
                    b.Location = new Point(chart_e.Location.X + chart_e.Width + 20, 44 + y);
                    b.Parent = panel1;
                    y += 38;
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
    }
}
