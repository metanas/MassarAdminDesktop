using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MassarAdminDesktop
{
    public partial class Subjects : Form
    {
      
        List<Bunifu.Framework.UI.BunifuTileButton> cl_buttons = new List<Bunifu.Framework.UI.BunifuTileButton>();
        string[] semestre; 
        string idm;
        string nomm;
        string moy;
        chart ch;

        public Subjects(string idm, string nomm)
        {
            InitializeComponent();
            semestre = new string[10]{ "1", "1", "1", "1", "1", "2", "2", "2", "2", "2"}; 
            cl_buttons.Add(Button1); cl_buttons.Add(Button2); cl_buttons.Add(Button3); cl_buttons.Add(Button6); cl_buttons.Add(Button7); cl_buttons.Add(Button8); cl_buttons.Add(Button4); cl_buttons.Add(Button5); cl_buttons.Add(Button9); cl_buttons.Add(Button10);
            foreach (Bunifu.Framework.UI.BunifuTileButton b in cl_buttons)
                b.Click += new System.EventHandler(this.clickcc);
            string id = HomePreview.id;
            string nomgr = HomePreview.nomgr;
            this.idm = idm;
            this.nomm = nomm;
            chart ch = new chart(chart1, HomePreview.id);
            ch.addChartBy(nom: nomgr);

            Login.read = DBConnect.Gets("select max(calcule.n), min(calcule.n) , avg(calcule.n) from (select avg(note) as n from examiner where id_matiere="+this.idm+" group by id_etudiant) as calcule");
            if (Login.read.Read())
            {
                max.Text = Login.read[0].ToString();
                min.Text = Login.read[1].ToString();
                moy = Login.read[2].ToString();
            }
            bunifuCircleProgressbar1.Value = (int)Math.Ceiling(float.Parse(moy));

            Login.read = DBConnect.Gets("select nom , prenom from groupe_matiere_enseignant , enseignant where id_enseignant=id and id_groupe="+id+" and id_matiere=" + this.idm);
            while (Login.read.Read())
                label2.Text = Login.read["nom"].ToString() + " " + Login.read["prenom"].ToString();
            Login.read.Close();
            
            moyenne.Text = Math.Round(double.Parse(moy),2).ToString();
            if (double.Parse(moyenne.Text) < 5)
                bunifuCircleProgressbar1.ProgressColor = Color.Red;
            else
                bunifuCircleProgressbar1.ProgressColor = Color.Green;
            Login.read = DBConnect.Gets("select distinct titre from examiner where id_groupe = "+id+ " and id_matiere=" + this.idm + " order by semestre,titre");
            int i = 0;
            while (Login.read.Read())
                cl_buttons[i++].Visible = true;
            Login.read.Close();
            Infobox.Text = this.nomm;
            
        }

        private void render_details()
        {
            double moy=0;
            int nonv=0;
            int ecart_type;
            double taux;

            foreach (var p in this.ch.c.Series[0].Points)
            {
                moy += p.YValues[0];
                if(p.YValues[0]<5) nonv++;
            }
            moy /= this.ch.c.Series[0].Points.Count();
            taux = Math.Round(100 * ((double)(this.ch.c.Series[0].Points.Count() - nonv) / (double)this.ch.c.Series[0].Points.Count()), 2, MidpointRounding.AwayFromZero);

            moy = Math.Round(moy, 2);
            taux = Math.Round(taux, 2);



            moy_i.Text = Math.Round(moy, 2, MidpointRounding.AwayFromZero).ToString();
            moy_i.Visible = true;
            nonv_i.Text = nonv.ToString();
            nonv_i.Visible = true;
            taux_i.Text = taux.ToString() + " %";
            taux_i.Visible = true;
            ecart_i.Text = "à calculer";
            ecart_i.Visible = true;
            exam_i.Text = this.ch.c.Series[0].Name;
            //a changer de place
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;

        }

        private void clickcc(object sender,EventArgs e)
        {
            ch = new chart(chart1, HomePreview.id);
            Bunifu.Framework.UI.BunifuTileButton the_cc = ((Bunifu.Framework.UI.BunifuTileButton)sender);
            ch.addChartBy(nom: semestre[cl_buttons.IndexOf(the_cc)] + " " + the_cc.LabelText, semestre: semestre[cl_buttons.IndexOf(the_cc)], titre: the_cc.LabelText);
            render_details();
        }

        


        private void Subjects_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }

        private void chart1_DoubleClick(object sender, EventArgs e)
        {
            chart.doubleCliick(sender,e);
        }

        private void bunifuCircleProgressbar1_Click(object sender, EventArgs e)
        {
            chart ch = new chart(chart1, HomePreview.id);
            ch.addChartBy(nom: HomePreview.nomgr);
        }
    }
}