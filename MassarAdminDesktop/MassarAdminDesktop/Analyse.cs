using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace MassarAdminDesktop
{
    public partial class Analyse : Form
    {
        Form form;
        ToolTip tp;
        public Analyse()
        {
            InitializeComponent();
            this.form = HomePreview.HomeForm;
            tp = new ToolTip();
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
            tp.SetToolTip(pictureBox1, "Double Clique pour changer");
            using (StreamReader sr = File.OpenText(@"C:\\Massar\Installer.txt"))
            {
                string[] s = sr.ReadToEnd().Split('\n');
                label4.Text += " " + s[1];
                if (s.Length > 2)
                {
                    pictureBox1.Image = Image.FromFile(s[s.Length - 1]);
                }
                sr.Close();
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

        private void label4_TextChanged(object sender, EventArgs e)
        {
            label4.Location = new Point((panel1.Width - label4.PreferredWidth) / 2, label4.Location.Y);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image (.png, .jpeg, .jpg)|*.png|*.jpeg|*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string fileName = open.SafeFileName;
                string sourcePath = open.FileName.Substring(0,open.FileName.LastIndexOf('\\'));
                string targetPath = @"C:\Images";
                File.AppendAllText(@"C:\Massar\Installer.txt", Environment.NewLine + "C:\\Images\\" + open.SafeFileName );              
                string sourceFile = Path.Combine(sourcePath, fileName);
                string destFile = Path.Combine(targetPath, fileName);

                if (!Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                }


                File.Copy(sourceFile, destFile, true);
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
