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
    public partial class Subjects : Form
    {


        public Subjects()
        {
            InitializeComponent();
            string id = Home.id;
            string nomgr = Home.nomgr;
            MessageBox.Show(id + nomgr);
            MessageBox.Show(progressBar1.Value.ToString());
            if (progressBar1.Value >= 10)
            {
                progressBar1.ForeColor = Color.Yellow;

            }

            max.Text = DBConnect.Get("select max(note) from examiner where id_matiere=1 and id_groupe=" + id + ";");
            min.Text = DBConnect.Get("select min(note) from examiner where id_matiere=1 and id_groupe=" + id + ";");

            string moy = DBConnect.Get("select avg(note) from examiner where id_matiere=1 and id_groupe=" + id + ";");
            progressBar1.Value = (int)Math.Ceiling(float.Parse( moy));

            Login.read = DBConnect.Gets("select nom , prenom from groupe_matiere_enseignant , enseignant where id_enseignant=id and id_groupe="+id+" and id_matiere=1;");
            while (Login.read.Read())
                professeur.Text = Login.read["nom"].ToString() + " " + Login.read["prenom"].ToString();
            Login.read.Close();
            
            moyenne.Text = moy.Substring(0, 5);
            if (progressBar1.Value < 10)
                moyenne.ForeColor = Color.Red;





        }

        private void Subjects_Load(object sender, EventArgs e)
        {

           

        }

    }
}