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
        string id;
        string groupe;
        List<Bunifu.Framework.UI.BunifuTileButton> Matieres = new List<Bunifu.Framework.UI.BunifuTileButton>();
        public Form PreviewForm;

        public Groupe(string id, string groupe)
        {
            InitializeComponent();
            this.id = id;
            this.groupe = groupe;
            this.groupe_l.Text = groupe;

            Login.read = DBConnect.Gets("SELECT ma.id, ma.nom FROM groupe_matiere_enseignant, matiere as ma WHERE ma.id = id_matiere and id_groupe = " + id);
            int w = bunifuSeparator1.Location.X;
            while (Login.read.Read())
            {

                Bunifu.Framework.UI.BunifuTileButton b = new Bunifu.Framework.UI.BunifuTileButton();
                b.Location = new Point(w, bunifuSeparator1.Location.Y + bunifuSeparator1.Height + 20);
                b.LabelText = Login.read[1] + "_" + Login.read[0];
                b.BackColor = Color.FromArgb(0, 163, 77);
                b.Click += new EventHandler(this.click_matiere);
                Matieres.Add(b);
                b.Size = new Size(100, 100);
                panel1.Controls.Add(b);
                w += b.Width + 10; 
                b.Show();
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
            Eleves S = new Eleves(this.id);
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

        private void panel3_Click(object sender, EventArgs e)
        {
            click_eleves();
        }


        private void Groupe_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }
    }
}
