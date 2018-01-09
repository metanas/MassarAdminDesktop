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
            Login.read = DBConnect.Gets("select e.nom,e.prenom,e.sexe , g.nom from etudiant  as e, etudiant_groupe as eg , groupe as g, annee as a where  eg.id_etudiant=e.id and eg.id_groupe=g.id and g.id_annee=a.id and a.annee_scolaire='" + Home.idann + "'");
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
            
            Groupe Groupe_Form;
            if (e.ColumnIndex == 3)
            {
                for (int i = 0; i < Home.cl_buttons.Count; i++)
                    if (bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[3].Value.ToString() == Home.cl_buttons[i].Text)
                        Home.id = Home.id_classes[i];
                Groupe_Form = new Groupe(Home.id, bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[3].Value.ToString());

                Groupe_Form.TopLevel = false;
                Groupe_Form.Parent = Home.ActifForm.Parent;
                Groupe_Form.Location = new Point(this.Location.X, this.Location.Y);
                Groupe_Form.Show();
                Home.AddForm(Groupe_Form);


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
