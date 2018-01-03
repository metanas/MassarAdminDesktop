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
            Betudiant.LabelText = countetu;
            Bprofesseur.LabelText=countprof;
            Bclasse.LabelText = countclasse;
            
        }
    }
}
