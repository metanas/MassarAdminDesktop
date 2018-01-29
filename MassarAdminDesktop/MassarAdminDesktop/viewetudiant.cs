using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            Login.read = DBConnect.Gets("select e.id_massar, e.nom, e.prenom, e.sexe , g.nom, e.password , e.active from etudiant  as e, etudiant_groupe as eg , groupe as g, annee as a where  eg.id_etudiant=e.id and eg.id_groupe=g.id and g.id_annee=a.id and a.annee_scolaire='" + HomePreview.idann + "'");
            etudiants = new List<List<string>>();
            int i = 0;
            while (Login.read.Read()) {
                etudiants.Add(new List<string>());
                etudiants[i].Add(Login.read[0].ToString());
                etudiants[i].Add(Login.read[1].ToString());
                etudiants[i].Add(Login.read[2].ToString());
                etudiants[i].Add(Login.read[3].ToString());
                etudiants[i].Add(Login.read[4].ToString());
                etudiants[i].Add((Login.read[5].ToString() == "") ? "": "deja genere");
                etudiants[i++].Add(Login.read[6].ToString());
            }
            Login.read.Close();
            setDataGridView(etudiants);
        }

        public void setDataGridView(List<List<string>> etu)
        {
            bunifuCustomDataGrid1.Rows.Clear();
            for(int i = 0; i < etu.Count; i++)
            {
                bunifuCustomDataGrid1.Rows.Add(etu[i][0], etu[i][1], etu[i][2], etu[i][3], etu[i][4], etu[i][5], etu[i][6]);
            }
        }
        private Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private string generatePassword(string numEleve) {
            var f = RandomString(8);
            Admin admin = new Admin();
            var s = admin.cript(f);
            DBConnect.Post("UPDATE etudiant set password ='" + admin.cript(f) + "' where id_massar='" + numEleve + "'");
            return f;
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 4)
                {
                    for (int i = 0; i < HomePreview.ClassButton.Count; i++)
                        if (bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == HomePreview.ClassButton[i].Text)
                            HomePreview.id = HomePreview.id_classes[i];
                    Groupe Groupe_Form = new Groupe(HomePreview.id, bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    HomePreview.resizeLocationForm(Groupe_Form);
                }
                else if (e.ColumnIndex == 5)
                {
                    if(bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[6].Value.ToString() == "0")
                    {
                        if (MessageBox.Show("voulez-vous réinitialise le mot de passe", "changer le mot de passe", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            string pass = generatePassword(bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
                            bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[5].Value = pass;
                        }
                    
                    }
                }
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
                    if(etudiants[i][0].ToUpper().Contains(search.text.ToUpper()) || etudiants[i][1].ToUpper().Contains(search.text.ToUpper()) || etudiants[i][2].ToUpper().Contains(search.text.ToUpper()))
                    {
                        list.Add(new List<string>());
                        list[w].Add(etudiants[i][0]);
                        list[w].Add(etudiants[i][1]);
                        list[w].Add(etudiants[i][2]);
                        list[w].Add(etudiants[i][3]);
                        list[w].Add(etudiants[i][4]);
                        list[w].Add(etudiants[i][5]);
                        list[w++].Add(etudiants[i][6]);
                    }
                }
                setDataGridView(list);
                return;
            }
            setDataGridView(etudiants);
        }
    }
}
