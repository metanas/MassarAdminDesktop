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
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preview p = new Preview();
            p.TopLevel = false;
            p.Parent = this;
            p.FormBorderStyle = FormBorderStyle.None;
            p.Show();
            p.browse();

        }
    }
}
