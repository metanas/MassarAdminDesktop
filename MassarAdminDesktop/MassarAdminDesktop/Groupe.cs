using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MassarAdminDesktop
{
    public partial class Groupe : Form
    {
        int countetu = 0;
        string id;
        string groupe;
        List<Bunifu.Framework.UI.BunifuTileButton> Matieres = new List<Bunifu.Framework.UI.BunifuTileButton>();
        public List<Matiere> matieres = new List<Matiere>();
        public Form PreviewForm;
        public List<Eleve> el = new List<Eleve>();

        public Groupe(string id, string groupe)
        {
            InitializeComponent();
            this.id = id;
            this.groupe = groupe;
            this.groupe_l.Text = groupe;

            Login.read = DBConnect.Gets("SELECT ma.id, ma.nom FROM groupe_matiere_enseignant, matiere as ma WHERE ma.id = id_matiere and id_groupe = " + id);
            int w = panel2.Location.X;
            while (Login.read.Read())
            {
                this.matieres.Add(new Matiere(Login.read[0].ToString(), Login.read[1].ToString()));
                Bunifu.Framework.UI.BunifuTileButton b = new Bunifu.Framework.UI.BunifuTileButton();
                b.Location = new Point(w, panel2.Location.Y + panel2.Height + 20);
                b.LabelText = Login.read[1].ToString().Substring(0,1).ToUpper() + Login.read[1].ToString().Substring(1, Login.read[1].ToString().Length-1) + "_" + Login.read[0];
                b.BackColor = Color.FromArgb(230, 81, 0);
                b.colorActive = Color.FromArgb(230, 81, 0);
                b.color = Color.FromArgb(230, 81, 0); 
                b.Click += new EventHandler(this.click_matiere);
                Matieres.Add(b);
                b.Size = new Size(100, 100);
                panel1.Controls.Add(b);
                w += b.Width + 10; 
                b.Show();
            }
            Login.read.Close();
            Login.read = DBConnect.
               Gets("SELECT id, id_massar, nom, prenom, nom_ar, prenom_ar, sexe, ville_naissance, ville_naissance_ar, adresse, date_naissance FROM etudiant, etudiant_groupe where id_groupe = " + id + " and id_etudiant = id");
            while (Login.read.Read())
            {
                //Login.read[7].ToString()
                Eleve e = new Eleve(Login.read[0].ToString(), Login.read[1].ToString(), Login.read[2].ToString(), Login.read[3].ToString(), Login.read[4].ToString(), Login.read[5].ToString(), Login.read[6].ToString(), Login.read[7].ToString(), Login.read[8].ToString(), Login.read[9].ToString());

                el.Add(e);
                countetu++;
            }

            Login.read.Close();

        }

        void click_matiere(object sender, EventArgs e)
        {
           
            Bunifu.Framework.UI.BunifuTileButton b = (Bunifu.Framework.UI.BunifuTileButton)sender;
            string nom = b.LabelText.Split('_')[0];
            string id = b.LabelText.Split('_')[1];
            Subjects S = new Subjects(id, nom);
            S.TopLevel = false;
            S.Parent = Home.ActifForm.Parent;
            S.Width = this.Width;
            S.Height = this.Height;
            S.Location = new Point(this.Location.X, this.Location.Y);
            S.Show();
            if (Home.ActifForm != null)
            {
                Home.ActifForm.Hide();
                Home.PreviewFrom.Add(Home.ActifForm);

            }
            Home.ActifForm = S;
        }


        void click_eleves()
        {
            Eleves S = new Eleves(this.id, this);
            S.el = this.el;
            S.render_eleves();
            S.TopLevel = false;
            S.Parent = Home.ActifForm.Parent;
            S.Location = new Point(this.Location.X, this.Location.Y);
            S.Show();
            if (Home.ActifForm != null)
            {
                Home.ActifForm.Hide();
                Home.PreviewFrom.Add(Home.ActifForm);

            }
            Home.ActifForm = S;
            
        }

        


        private void Groupe_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int fille = countetu - nbrgarc();
            Progressbar1.MaxValue = 10;
            Progressbar1.Value =nbrgarc();
            countetudiant.Text =countetu.ToString();
            label4.Text = nbrgarc().ToString();
            label6.Text = fille.ToString();
        }
        public int nbrgarc()
        {
            int nb = 0;
            foreach (Eleve e in el)
                if (e.sexe == "m") nb++;
            return nb;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)

        {
            click_eleves();
        }
    }
}
