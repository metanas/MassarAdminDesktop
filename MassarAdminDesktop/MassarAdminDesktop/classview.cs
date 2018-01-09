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
            Login.read = DBConnect.Gets("select groupe.nom , groupe.id from groupe , annee where annee.annee_scolaire='" + Home.idann + "' and  annee.id=groupe.id_annee ; ");
            while (Login.read.Read()) {
                bunifuCustomDataGrid1.Rows.Add(Login.read["nom"].ToString());
            }
            Login.read.Close();
        }
    }
}
