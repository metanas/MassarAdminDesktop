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
    }
}
