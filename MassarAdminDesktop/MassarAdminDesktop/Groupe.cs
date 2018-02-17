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
        List<Bunifu.Framework.UI.BunifuFlatButton> Matieres = new List<Bunifu.Framework.UI.BunifuFlatButton>();
        public List<Matiere> matieres = new List<Matiere>();
        public List<Eleve> el = new List<Eleve>();
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public Groupe(string id, string groupe)
        {
            InitializeComponent();
            this.id = id;
            this.groupe = groupe;
            this.groupe_l.Text = groupe; int s = 1;
            Login.read = DBConnect.Gets("SELECT ma.id, ma.nom FROM groupe_matiere_enseignant, matiere as ma WHERE ma.id = id_matiere and id_groupe = " + id);
            int w = 12;
            int t = 10;
            bool r = false;
            while (Login.read.Read())
            {
                if (r)
                {
                    r = false;
                    panel2.Size = new Size(panel2.Width, panel2.Height + 63);
                }
                this.matieres.Add(new Matiere(Login.read[0].ToString(), Login.read[1].ToString()));
                Bunifu.Framework.UI.BunifuFlatButton bs = new Bunifu.Framework.UI.BunifuFlatButton();
                bs.Size = new Size(210, 43);
                bs.Iconimage = Properties.Resources.diploma;
                bs.IconZoom = 60;
                bs.Text = Login.read[1].ToString().Substring(0, 1).ToUpper() + Login.read[1].ToString().Substring(1, Login.read[1].ToString().Length - 1);
                dictionary.Add(Login.read[1].ToString().Substring(0, 1).ToUpper() + Login.read[1].ToString().Substring(1, Login.read[1].ToString().Length - 1), Login.read[0].ToString());
                bs.BackColor = Color.FromArgb(107, 124, 140);
                bs.Normalcolor = Color.FromArgb(107, 124, 140);
                bs.Activecolor = Color.FromArgb(107, 124, 140);
                bs.OnHovercolor = Color.FromArgb(97, 114, 130);
                bs.Location = new Point(w, t);
                bs.Click += new EventHandler(this.click_matiere);
                panel2.Controls.Add(bs);
                Matieres.Add(bs);
                w += bs.Width + 5;
                if (s % 3 == 0)
                {
                    t += bs.Height + 5;
                    w = panel2.Location.X ;
                    r = true;
                }
                s += 1;
            }
            Login.read.Close();
            Login.read = DBConnect.Gets("SELECT id, id_massar, nom, prenom, nom_ar, prenom_ar, sexe, ville_naissance, ville_naissance_ar, adresse, date_naissance FROM etudiant, etudiant_groupe where id_groupe = " + id + " and id_etudiant = id");
            while (Login.read.Read())
            {
                //Login.read[7].ToString()
                Eleve es = new Eleve(Login.read[0].ToString(), Login.read[1].ToString(), Login.read[2].ToString(), Login.read[3].ToString(), Login.read[4].ToString(), Login.read[5].ToString(), Login.read[6].ToString(), Login.read[7].ToString(), Login.read[8].ToString(), Login.read[9].ToString());
                el.Add(es);
                countetu++;
            }

            Login.read.Close();
        

        }

        void click_matiere(object sender, EventArgs e)
        {
           
            Bunifu.Framework.UI.BunifuFlatButton b = (Bunifu.Framework.UI.BunifuFlatButton)sender;
            string nom = b.Text;
            string id = dictionary[b.Text];
            Subjects view = new Subjects(id, nom);
            HomePreview.resizeLocationForm(view);
        }


        void click_eleves()
        {
            Eleves view = new Eleves(this.id, matieres, groupe_l.Text);
            view.el = this.el;
            view.render_eleves(el);
            HomePreview.resizeLocationForm(view);

        }

        private void Groupe_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }

        public int nbrgarc()
        {
            int nb = 0;
            foreach (Eleve e in el)
                if (e.sexe == "ذكر") nb++;
            return nb;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            click_eleves();
        }

        private void Groupe_Load(object sender, EventArgs e)
        {
            if (countetu == 0)
                return;
            int s = nbrgarc();
            int fille = countetu - s;
            Progressbar1.MaxValue = countetu;
            Progressbar1.Value = s;
            countetudiant.Text = countetu.ToString();
            label4.Text = s.ToString();
            label6.Text = fille.ToString();
        }
    }
}
