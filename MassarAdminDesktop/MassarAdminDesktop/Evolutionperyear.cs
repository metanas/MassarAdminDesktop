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
    public partial class Evolutionperyear : Form
    {
        chart ch ;
        public Evolutionperyear()
        {
            InitializeComponent();
            ch = new chart(chart1, "");
            ch.evoann();

        }

        private void chart1_DoubleClick(object sender, EventArgs e)
        {
            chart.doubleCliick(sender, e);
        }

        private void Groupe_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }

        private void chart1_DoubleClick_1(object sender, EventArgs e)
        {
            chart.doubleCliick(sender, e);
        }
    }
}
