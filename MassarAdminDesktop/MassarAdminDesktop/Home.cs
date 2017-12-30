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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            if (!Login.admin.isSuper)
                utilisateurs.Visible = false;
        }

        private void importerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Previw previw = new Previw();
            previw.TopLevel = false;
            previw.Parent = this;
            previw.Show();
            previw.browse();
        }

        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Admin gerer = new Gerer_Admin();
            gerer.Show();
        }
    }
}
