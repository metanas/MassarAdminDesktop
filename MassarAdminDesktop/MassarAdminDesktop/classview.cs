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
    public partial class classview : Form
    {
        public classview()
        {
            InitializeComponent();
        }

        private void classview_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.Rows.Clear();
            Login.read = DBConnect.Gets("select groupe.nom , groupe.id ,count(etudiant_groupe.id_etudiant) from etudiant_groupe , groupe,  annee where groupe.id=etudiant_groupe.id_groupe and  annee.annee_scolaire='" + HomePreview.idann + "' and  annee.id=groupe.id_annee group by etudiant_groupe.id_groupe ; ");
            while (Login.read.Read()) {
                bunifuCustomDataGrid1.Rows.Add(Login.read["id"].ToString(), Login.read["nom"].ToString(),Login.read[2].ToString(),"supprimer");
            }
            Login.read.Close();
        }

        private async void BunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                if (e.ColumnIndex == 3) {
                    string idGroupe = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (MessageBox.Show("etes vous sur de vouloir supprimer cette Classe", "Suppression de Classe",  MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        await Task.Run(() =>
                        {
                            DBConnect.Post("DELETE FROM examiner where id_annee=(select id from annee where annee_scolaire='" + HomePreview.idann + "') and id_groupe='" + idGroupe + "'");
                            DBConnect.Post("Delete FROM etudiant where id in (select id_etudiant From etudiant_groupe where id_groupe='" + idGroupe + "')");
                            DBConnect.Post("Delete FRom etudiant_groupe where id_groupe=" + idGroupe);
                            DBConnect.Post("Delete From groupe where id=" + idGroupe);
                            DBConnect.Post("Delete From groupe_matiere_enseignant where id_groupe=" + idGroupe);
                        });
                        classview_Load(sender, e);
                    }
                }
            }
        }

        private void Groupe_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }
    }
}
