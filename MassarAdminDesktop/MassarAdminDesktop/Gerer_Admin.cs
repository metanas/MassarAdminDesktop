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
    public partial class Gerer_Admin : MaterialSkin.Controls.MaterialForm
    {
        private List<string[]> lesAdmins = new List<string[]>();

        public Gerer_Admin()
        {
            InitializeComponent();
            refresh();
            
        }
        void refresh() {
            int i = 0;
            lesAdmins.Clear();
            Admins.Rows.Clear();
            Login.read = DBConnect.Gets("select * from admin ;");
            while (Login.read.Read())
            {
                Admins.Rows.Add(Login.read["nom"], "", Login.read["isSuper"], "Supprimer", "Modifier");
                lesAdmins.Add(new string[] { Login.read["nom"].ToString(), "", Login.read["isSuper"].ToString() });
                if (Login.admin.nom == Login.read["nom"].ToString()) 
                    Admins.Rows[i].Cells[2].ReadOnly = true;               
            }
            Login.read.Close();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            string adm = Login.admin.newAdmin(newN.Text, NewP.Text, Super.Checked);
            if (adm.StartsWith("n")) {
                refresh();
                newN.Text = "";
                NewP.Text = "";
                Super.Checked = false;
            }
            MessageBox.Show(adm);
        }
       

        private void Admins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 4)
            {
                if (Admins.Rows[e.RowIndex].Cells[1].Value.ToString() == lesAdmins[e.RowIndex][1] && Admins.Rows[e.RowIndex].Cells[2].Value.ToString() == lesAdmins[e.RowIndex][2])
                {
                    MessageBox.Show("tu n'a pas fait aucun modification");
                    return;
                }
                
                string result = Login.admin.ModifierAdmin(Admins.Rows[e.RowIndex].Cells[0].Value.ToString(), Admins.Rows[e.RowIndex].Cells[1].Value.ToString(), Admins.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (result.StartsWith("Admin")) 
                    refresh();
                    MessageBox.Show(result);
            }
            else if (e.ColumnIndex == 3) {
                if(Admins.Rows[e.RowIndex].Cells[0].Value.ToString()==Login.admin.nom){
                    MessageBox.Show("tu n'a pas le droit de supprimer votre compte");
                    return;
                }
                string result = Login.admin.SupprimerAdmin(Admins.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (result.StartsWith("Admin"))
                    refresh();
                MessageBox.Show(result);
            }
        
        
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
