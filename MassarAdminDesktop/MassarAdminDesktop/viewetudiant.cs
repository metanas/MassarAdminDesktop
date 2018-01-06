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
        public viewetudiant()
        {
            InitializeComponent();
        }

        private void viewetudiant_Load(object sender, EventArgs e)
        {
            Login.read = DBConnect.Gets("select e.nom,e.prenom,e.sexe from etudiant  as e, etudiant_groupe as eg , groupe as g, annee as a where  eg.id_etudiant=e.id and eg.id_groupe=g.id and g.id_annee=a.id and a.annee_scolaire='" + Home.idann + "'");
            
            while (Login.read.Read())
                bunifuCustomDataGrid1.Rows.Add(Login.read["nom"].ToString(),Login.read["prenom"].ToString(), Login.read["sexe"].ToString());
            Login.read.Close();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Groupe_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }
    }
}
