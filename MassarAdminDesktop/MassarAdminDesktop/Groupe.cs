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
        List<Button> Matieres = new List<Button>();


        public Groupe(string id, string groupe)
        {
            InitializeComponent();
            this.id = id;
            this.groupe = groupe;
            this.groupe_l.Text = groupe;

            Login.read = DBConnect.Gets("SELECT ma.id, ma.nom FROM groupe_matiere_enseignant, matiere as ma WHERE ma.id = id_matiere and id_groupe = " + id);
            int w = 100;
            while (Login.read.Read())
            {

                Button b = new Button();
                MessageBox.Show(Login.read[1].ToString() + "_" + Login.read[0].ToString());
                b.Location = new System.Drawing.Point(w, 400);
                b.Text = Login.read[1].ToString()+"_"+Login.read[0].ToString();
                b.Click += new System.EventHandler(this.click_matiere);
                Matieres.Add(b);
                b.Size = new System.Drawing.Size(100, 129);
                this.Controls.Add(b);
                w += 100;
                b.Show();
            }
            Login.read.Close();


        }

        void click_matiere(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string nom = b.Text.Split('_')[0];
            string id = b.Text.Split('_')[1];
            Subjects S = new Subjects(id, nom);
            S.TopLevel = false;
            S.Parent = this.Parent;
            
            this.Hide();
            S.Show();
        }




    }
}
