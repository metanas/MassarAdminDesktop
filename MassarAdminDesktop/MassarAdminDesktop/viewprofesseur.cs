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
    public partial class viewprofesseur : Form
    {
        public viewprofesseur()
        {
            InitializeComponent();
        }

        private void viewprofesseur_Load(object sender, EventArgs e)
        {
            Login.read = DBConnect.Gets("select nom,prenom from enseignant");
            while (Login.read.Read())
                bunifuCustomDataGrid1.Rows.Add(Login.read["nom"].ToString(), Login.read["prenom"].ToString());
            Login.read.Close();
        }
    }
}
