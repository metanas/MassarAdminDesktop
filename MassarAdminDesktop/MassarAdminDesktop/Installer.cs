using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassarAdminDesktop
{
    public partial class Installer : Form
    {
        int tog, mvalX, mvalY;
        public Installer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (val)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Entrez le nom de l'école");
                    textBox1.Focus();
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Entrez le nom de l'administrateur");
                    textBox2.Focus();
                    return;
                }
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Entrez le mot de passe");
                    textBox3.Focus();
                    return;
                }
                if (textBox4.Text == "")
                {
                    MessageBox.Show("Entrez la confirmation de mot de passe");
                    textBox4.Focus();
                    return;
                }
                if (textBox4.Text != textBox3.Text)
                {
                    MessageBox.Show("Les mots de passe sont différents");
                    textBox3.Focus();
                    return;
                }
                createTable();

            }
            else {
                dirCreate();
            }
        }

        void createTable()
        {
            string stringConnection = "SERVER=" + textBox8.Text + ";" + "UID=" + textBox7.Text + ";" + "PASSWORD=" + textBox6.Text + "; Character Set=utf8";
            DBConnect.connection = new MySql.Data.MySqlClient.MySqlConnection(stringConnection);
            try
            {
                DBConnect.connection.Open();
            }
            catch
            {
                label8.Visible = true;
                return;
            }
            Admin ad = new Admin();
            DBConnect.Post("SET SQL_MODE = \"NO_AUTO_VALUE_ON_ZERO\";");
            progressBar1.Value += 5;
            DBConnect.Post("SET AUTOCOMMIT = 0;");
            progressBar1.Value += 5;
            DBConnect.Post("START TRANSACTION;");
            progressBar1.Value += 5;
            DBConnect.Post("DROP DATABASE IF EXISTS `Massar`;");
            progressBar1.Value += 5;
            DBConnect.Post("CREATE DATABASE IF NOT EXISTS `Massar` DEFAULT CHARACTER SET utf8 COLLATE utf8_bin;");
            progressBar1.Value += 5;
            DBConnect.Post("USE `Massar`;");
            progressBar1.Value += 5;
            DBConnect.Post("CREATE TABLE IF NOT EXISTS `admin` ( `id` int(11) NOT NULL AUTO_INCREMENT, `nom` varchar(200) NOT NULL, `password` varchar(200) NOT NULL, `isSuper` varchar(5) NOT NULL, PRIMARY KEY(`id`), UNIQUE KEY `nom` (`nom`)) ENGINE = MyISAM DEFAULT CHARSET = latin1; ");
            progressBar1.Value += 5;
            DBConnect.Post("CREATE TABLE IF NOT EXISTS `annee` (`id` int(11) NOT NULL AUTO_INCREMENT, `annee_scolaire` varchar(10) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL, PRIMARY KEY(`id`), UNIQUE KEY `annee_scolaire` (`annee_scolaire`)) ENGINE = MyISAM DEFAULT CHARSET = latin1; ");
            progressBar1.Value += 5;
            DBConnect.Post("CREATE TABLE IF NOT EXISTS `enseignant` ( `id` int(11) NOT NULL AUTO_INCREMENT, `nom` varchar(30) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL, `prenom` varchar(30) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL, PRIMARY KEY(`id`), UNIQUE KEY `nom` (`nom`,`prenom`)) ENGINE = MyISAM DEFAULT CHARSET = latin1; ");
            progressBar1.Value += 5;
            DBConnect.Post("CREATE TABLE IF NOT EXISTS `etudiant` (`id` int(11) NOT NULL, `id_massar` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL, `nom` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL, `cin` varchar(10) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL, `prenom` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL, `nom_ar` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL, `prenom_ar` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL, `sexe` varchar(5) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL, `date_naissance` date NOT NULL, `ville_naissance` varchar(15) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL, `ville_naissance_ar` varchar(15) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL, `adresse` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL, `password` varchar(255) DEFAULT NULL, `active` int(11) NOT NULL DEFAULT '0', PRIMARY KEY(`id`), UNIQUE KEY `id_massar` (`id_massar`)) ENGINE = MyISAM DEFAULT CHARSET = latin1;");
            progressBar1.Value += 5;
            DBConnect.Post("CREATE TABLE IF NOT EXISTS `etudiant_groupe` (`id_groupe` int(11) NOT NULL, `id_etudiant` int(11) NOT NULL, PRIMARY KEY(`id_groupe`,`id_etudiant`), KEY `id_etudiant` (`id_etudiant`)) ENGINE = MyISAM DEFAULT CHARSET = latin1; ");
            progressBar1.Value += 5;
            DBConnect.Post("CREATE TABLE IF NOT EXISTS `examiner` ( `id_annee` int(11) NOT NULL, `id_groupe` int(11) NOT NULL, `id_etudiant` int(11) NOT NULL, `id_matiere` int(11) NOT NULL, `titre` varchar(40) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL, `semestre` varchar(40) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL, `unite` varchar(40) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL, `note` float(11) DEFAULT NULL , insertion DateTime default now(), author varchar(50), PRIMARY KEY(`id_groupe`,`id_etudiant`,`id_annee`,`id_matiere`,`titre`,`semestre`,`unite`), KEY `id_matiere` (`id_matiere`), KEY `id_etudiant` (`id_etudiant`), KEY `id_annee` (`id_annee`)) ENGINE = MyISAM DEFAULT CHARSET = latin1; ");
            progressBar1.Value += 5;
            DBConnect.Post("CREATE TABLE IF NOT EXISTS `groupe` ( `id` int(11) NOT NULL AUTO_INCREMENT, `nom` varchar(30) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL, `id_niveau` int(11) NOT NULL, `id_annee` int(11) NOT NULL, PRIMARY KEY(`id`), UNIQUE KEY `nom` (`nom`,`id_annee`)) ENGINE = MyISAM DEFAULT CHARSET = latin1; ");
            progressBar1.Value += 5;
            DBConnect.Post("CREATE TABLE IF NOT EXISTS `groupe_matiere_enseignant` ( `id_matiere` int(11) NOT NULL, `id_groupe` int(11) NOT NULL, `id_enseignant` int(11) NOT NULL, PRIMARY KEY(`id_matiere`,`id_groupe`,`id_enseignant`), KEY `id_groupe` (`id_groupe`), KEY `id_enseignant` (`id_enseignant`)) ENGINE = MyISAM DEFAULT CHARSET = latin1; ");
            progressBar1.Value += 5;
            DBConnect.Post("CREATE TABLE IF NOT EXISTS `matiere` (`id` int(11) NOT NULL AUTO_INCREMENT, `nom` varchar(30) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,PRIMARY KEY(`id`)) ENGINE = MyISAM DEFAULT CHARSET = latin1; ");
            progressBar1.Value += 5;
            DBConnect.Post("CREATE TABLE IF NOT EXISTS `niveau` (`id` int(11) NOT NULL AUTO_INCREMENT, `nom` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL, PRIMARY KEY(`id`)) ENGINE = MyISAM DEFAULT CHARSET = latin1; ");
            progressBar1.Value += 5;
            DBConnect.Post("INSERT INTO `admin` ( `nom`, `password`, `isSuper`) VALUES ('"+ textBox2.Text +"', '"+ ad.cript(textBox2.Text) + "', 'True');");
            progressBar1.Value += 5;            
            DBConnect.Post("INSERT INTO `annee` (`annee_scolaire`) VALUES ('" + (int.Parse(DateTime.Today.Year.ToString()) - 1) + "/" + DateTime.Today.Year + "');");
            progressBar1.Value += 5;
            DBConnect.Post("INSERT INTO `niveau` (`id`, `nom`) VALUES (1, '1APG'),(2, '2APG'),(3, '3APG'),(4, '4APG'),(5, '5APG'),(6, '6APG'); ");
            progressBar1.Value += 5;
            DBConnect.Post(string.Format("GRANT ALL PRIVILEGES ON massar.* TO '{0}'@'%' identified by '{1}' WITH GRANT OPTION;", textBox7.Text, textBox6.Text));
            DBConnect.Post("FLUSH PRIVILEGES");
            DBConnect.Post("COMMIT;");
            dirCreate();
        }

        private void dirCreate()
        {
            foreach (string subPath in new string[3] { "C:\\Massar", "C:\\Fonts", "C:\\Images" })
            {
                bool exists = Directory.Exists(subPath);
                if (!exists)
                    Directory.CreateDirectory(subPath);
            }
            using (StreamWriter sw = File.CreateText(@"C:\\Massar\Installer.txt"))
            {
                sw.WriteLine("Installed");
                if (val)
                {
                    sw.WriteLine(textBox1.Text);
                }
            }
            using (StreamWriter sw = File.CreateText(@"C:\\Massar\.ConfigurationDB.txt"))
            {
                if (val)
                {
                    sw.WriteLine(textBox8.Text);
                    sw.WriteLine("Massar");
                    sw.WriteLine(textBox7.Text);
                    sw.WriteLine(textBox6.Text);
                }
            }
            string fileName = "img.png";
            string sourcePath = @"C:\\Program Files (x86)\Cesim\Massar Admin\Config";
            string targetPath = @"C:\\Images";

            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }


            File.Copy(sourceFile, destFile, true);
            foreach (string fiName in new string[4] { "ARIALUNI.TTF", "LATO-BLACK.TTF", "LATO-BOLD.TTF", "LATO-REGULAR.TTF" })
            {
                sourcePath = @"C:\Program Files (x86)\Cesim\Massar Admin\Config";
                targetPath = @"C:\Fonts";

                sourceFile = Path.Combine(sourcePath, fiName);
                destFile = Path.Combine(targetPath, fiName);

                if (!Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                }


                File.Copy(sourceFile, destFile, true);
            }

            progressBar1.Value = 100;
            HomePreview homePreview = new HomePreview(this);
            homePreview.Show();
            this.Hide();

        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            tog = 1;
            mvalX = e.Location.X;
            mvalY = e.Location.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            tog = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tog == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mvalX, MousePosition.Y - mvalY);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\\Program Files (x86)\Cesim\Massar Admin\mysql-installer-web-community-5.7.21.0.msi");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {           
                this.Close();            
        }

        bool val = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            val = ((CheckBox)sender).Checked;
            if (val)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
            }
            else {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
            }
        }
    }
}
