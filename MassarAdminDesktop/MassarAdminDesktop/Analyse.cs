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
    public partial class Analyse : Form
    {
        public Analyse()
        {
            InitializeComponent();
        }

        private void Analyse_Load(object sender, EventArgs e)
        {
            string countetu = DBConnect.Get("select count(*) from etudiant");
            string countprof = DBConnect.Get("select count(*) from enseignant");
            string countclasse = DBConnect.Get("select count(*) from groupe");
            label1.Text = countetu;
            label2.Text = countprof;
            label3.Text = countclasse;
            
        }

        private void Analyse_ResizeBegin(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - panel1.Width)/2, (this.Height - panel1.Height)/2);
        }
    }
}
