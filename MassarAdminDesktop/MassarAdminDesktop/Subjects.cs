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
        List<Button> cc = new List<Button>(); 
        string[] semestre= new string[6];

        public Subjects()
        {
            InitializeComponent();
            semestre[0] = "1"; semestre[1] = "1"; semestre[2] = "1"; semestre[3] = "2"; semestre[4] = "2"; semestre[5] = "2";
            cc.Add(button1); cc.Add(button2); cc.Add(button3); cc.Add(button4); cc.Add(button5); cc.Add(button6);
            foreach (Button b in cc)
                b.Click += new System.EventHandler(this.clickcc);
            string id = Home.id;
            string nomgr = Home.nomgr;
            MessageBox.Show(id + nomgr);
            MessageBox.Show(progressBar1.Value.ToString());
            if (progressBar1.Value >= 10)
            {
                progressBar1.ForeColor = Color.Yellow;

            }
            chart ch = new chart(chart1, Home.id);
            ch.addChartBy(nom: nomgr);
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

            Login.read = DBConnect.Gets("select distinct titre from examiner where id_groupe = "+id+" and id_matiere=1 order by semestre,titre");
            int i = 0;
            while (Login.read.Read())
                cc[i++].Visible = true;
            Login.read.Close();


            


        }
        private void clickcc(object sender,EventArgs e)
        {
            chart ch = new chart(chart1,Home.id);
            Button the_cc = ((Button)sender);
            ch.addChartBy(nom: semestre[cc.IndexOf(the_cc)] + " " + the_cc.Text, semestre: semestre[cc.IndexOf(the_cc)], titre: the_cc.Text);

        }

     

      


    }
}