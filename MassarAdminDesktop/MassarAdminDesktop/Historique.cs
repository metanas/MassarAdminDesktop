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
    public partial class Historique : Form
    {
        public Historique()
        {
            InitializeComponent();
        }

        private void Historique_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Login.read = DBConnect.Gets("select distinct annee_scolaire, examiner.id_annee, groupe.nom, id_groupe, matiere.nom,id_matiere, titre, semestre, author, insertion from examiner ,annee, matiere, groupe where id_groupe=groupe.id and examiner.id_annee= annee.id and matiere.id = examiner.id_matiere order by insertion desc");
            while (Login.read.Read())
            {
                dataGridView1.Rows.Add(Login.read[0].ToString(), Login.read[1].ToString(), Login.read[2].ToString(), Login.read[3].ToString(), Login.read[4].ToString(), Login.read[5].ToString(), Login.read[6].ToString(), Login.read[7].ToString(), Login.read[8].ToString(), Login.read[9].ToString(), "Supprimer");
            }
            Login.read.Close();
        }

        private void Groupe_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                if(e.ColumnIndex == 10)
                {
                    string id_groupe = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string id_matiere = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string id_annee = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string title = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string semestre = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    int NbMatiere = int.Parse(DBConnect.Get("select count(id_matiere) from (select distinct id_annee, id_groupe, id_matiere, titre, semestre, author, insertion from examiner where id_matiere='" + id_matiere + "') as s"));                       
                    Login.read = DBConnect.Gets("select count(id_enseignant), id_enseignant from groupe_matiere_enseignant where id_enseignant=(select id_enseignant from groupe_matiere_enseignant where id_matiere="+ id_matiere + " and id_groupe='" + id_groupe + "')");
                    Login.read.Read();
                    int prof = int.Parse(Login.read[0].ToString());
                    string id_prof = Login.read[1].ToString();
                    Login.read.Close();

                    DBConnect.Post("delete from examiner where id_annee='" + id_annee+  "' and id_groupe='" + id_groupe + "' and id_matiere='" + id_matiere + "' and titre='" + title +"' and semestre='" + semestre + "'");
                    DBConnect.Post("delete from groupe_matiere_enseignant where id_groupe='" + id_groupe + "' and id_matiere='" + id_matiere + "'");
                    if (NbMatiere == 1)
                    {
                        DBConnect.Post("delete from matiere where id='" + id_matiere + "'");
                    }
                    if(prof == 1)
                    {
                        DBConnect.Post("delete from enseignant where id='" + id_prof + "'");
                    }
                    Historique_Load(null, null);
                }
            }
        }
    }
}
