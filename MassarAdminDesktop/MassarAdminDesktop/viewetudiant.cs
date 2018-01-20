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
    public partial class viewetudiant : Form
    {
        
        List<List<string>> etudiants; 
        public viewetudiant()
        {
            InitializeComponent();
        }

        private void viewetudiant_Load(object sender, EventArgs e)
        {
            Login.read = DBConnect.Gets("select e.nom,e.prenom,e.sexe , g.nom from etudiant  as e, etudiant_groupe as eg , groupe as g, annee as a where  eg.id_etudiant=e.id and eg.id_groupe=g.id and g.id_annee=a.id and a.annee_scolaire='" + HomePreview.idann + "'");
            etudiants = new List<List<string>>();
            int i = 0;
            while (Login.read.Read()) {
                etudiants.Add(new List<string>());
                etudiants[i].Add(Login.read[0].ToString());
                etudiants[i].Add(Login.read[1].ToString());
                etudiants[i].Add(Login.read[2].ToString());
                etudiants[i++].Add(Login.read[3].ToString());
            }
            Login.read.Close();
            setDataGridView(etudiants);
        }

        public void setDataGridView(List<List<string>> etu)
        {
            bunifuCustomDataGrid1.Rows.Clear();
            for(int i = 0; i < etu.Count; i++)
            {
                bunifuCustomDataGrid1.Rows.Add(etu[i][0], etu[i][1], etu[i][2], etu[i][3]);
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.ColumnIndex == 3)
            {
                for (int i = 0; i < HomePreview.ClassButton.Count; i++)
                    if (bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[3].Value.ToString() == HomePreview.ClassButton[i].Text)
                        HomePreview.id = HomePreview.id_classes[i];
                Groupe Groupe_Form = new Groupe(HomePreview.id, bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[3].Value.ToString());
                HomePreview.resizeLocationForm(Groupe_Form);
            }
    }

        private void Groupe_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }

        private void search_OnTextChange(object sender, EventArgs e)
        {
            List<List<string>> list = new List<List<string>>();
            if(search.text != "")
            {
                int w=0;
                for(int i=0; i< etudiants.Count; i++) {
                    if(etudiants[i][0].ToUpper().Contains(search.text.ToUpper()) || etudiants[i][1].ToUpper().Contains(search.text.ToUpper()))
                    {
                        list.Add(new List<string>());
                        list[w].Add(etudiants[i][0]);
                        list[w].Add(etudiants[i][1]);
                        list[w].Add(etudiants[i][2]);
                        list[w++].Add(etudiants[i][3]);
                    }
                }
                setDataGridView(list);
                return;
            }
            setDataGridView(etudiants);
        }
    }
}
