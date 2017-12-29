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
    public partial class Previw : Form
    {
        string q;
        public Previw()
        {
            InitializeComponent();
        }

        private void Previw_Load(object sender, EventArgs e)
        {

        }
        public void browse()
        {
            
           
                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                    q = open.FileName;
            
        }
    }
}
