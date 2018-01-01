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
    public partial class Subjects : Form
    {


        public Subjects()
        {
            InitializeComponent();
        }

        private void Subjects_Load(object sender, EventArgs e)
        {

            string id = Home.id;
            string nomgr = Home.nomgr;
            MessageBox.Show(id + nomgr);
            MessageBox.Show(progressBar1.Value.ToString());
            if (progressBar1.Value >= 10)
            {
                progressBar1.ForeColor = Color.Yellow;

            }
        }

    }
}