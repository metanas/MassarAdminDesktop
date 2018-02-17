using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace MassarAdminDesktop
{
    public partial class Analyse : Form
    {
        Form form;
        public Analyse()
        {
            InitializeComponent();
            this.form = HomePreview.HomeForm;
        }

        private void Analyse_Load(object sender, EventArgs e)
        {
            string countetu = DBConnect.Get("SELECT COUNT(id_Etudiant) from etudiant_groupe WHERE id_groupe in (SELECT id from groupe WHERE id_annee =(SELECT id from annee WHERE annee_scolaire='" + HomePreview.idann + "'))");
            string countprof = DBConnect.Get("select count(*) from enseignant as e , groupe_matiere_enseignant as gme , groupe as g , annee as a where e.id=gme.id_enseignant and gme.id_groupe=g.id and g.id_annee=a.id and  a.annee_scolaire='" + HomePreview.idann + "'");
            string countclasse = HomePreview.nbrClasse.ToString();
            Betudiant.Font = new Font(HomePreview.latoBold.Families[0], 14, FontStyle.Bold);
            bunifuTileButton1.Font = new Font(HomePreview.latoBold.Families[0], 14, FontStyle.Bold);
            bunifuTileButton2.Font = new Font(HomePreview.latoBold.Families[0], 14, FontStyle.Bold);
            bunifuTileButton3.Font = new Font(HomePreview.latoBold.Families[0], 14, FontStyle.Bold);
            label1.Text = countetu;
            label2.Text = countprof;
            label3.Text = countclasse;
            using (StreamReader sr = File.OpenText(@"C:\\Massar\Installer.txt"))
            {
                label4.Text += " " + sr.ReadToEnd().Split('\n')[1];               
            }
        }

        private void Analyse_ResizeBegin(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - panel1.Width)/2, (this.Height - panel1.Height)/2);
        }

        private void Betudiant_Click(object sender, EventArgs e)
        {  
            viewetudiant view = new viewetudiant();
            HomePreview.resizeLocationForm(view);
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            
            viewprofesseur view = new viewprofesseur();
            HomePreview.resizeLocationForm(view);
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {            
            Evolutionperyear view = new Evolutionperyear();
            HomePreview.resizeLocationForm(view);
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            
            classview view = new classview();
            HomePreview.resizeLocationForm(view);
        }
    }
}
