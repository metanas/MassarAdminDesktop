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
      
        List<Bunifu.Framework.UI.BunifuTileButton> cl_buttons = new List<Bunifu.Framework.UI.BunifuTileButton>();
        string[] semestre= new string[6];
        string idm;
        string nomm;

        public Subjects(string idm, string nomm)
        {
            InitializeComponent();
            semestre[0] = "1"; semestre[1] = "1"; semestre[2] = "1"; semestre[3] = "2"; semestre[4] = "2"; semestre[5] = "2";
            cl_buttons.Add(Button1); cl_buttons.Add(Button2); cl_buttons.Add(Button3); cl_buttons.Add(Button4); cl_buttons.Add(Button5); cl_buttons.Add(Button6);
            foreach (Bunifu.Framework.UI.BunifuTileButton b in cl_buttons)
                b.Click += new System.EventHandler(this.clickcc);
            string id = Home.id;
            string nomgr = Home.nomgr;
            this.idm = idm;
            this.nomm = nomm;
            chart ch = new chart(chart1, Home.id);
            ch.addChartBy(nom: nomgr);
            max.Text = DBConnect.Get("select max(note) from examiner where id_matiere="+this.idm+" and id_groupe=" + id + ";");
            min.Text = DBConnect.Get("select min(note) from examiner where id_matiere=" + this.idm + " and id_groupe=" + id + ";");

            string moy = DBConnect.Get("select avg(note) from examiner where id_matiere=" + this.idm + " and id_groupe=" + id + ";");
            bunifuCircleProgressbar1.Value = (int)Math.Ceiling(float.Parse(moy));

            Login.read = DBConnect.Gets("select nom , prenom from groupe_matiere_enseignant , enseignant where id_enseignant=id and id_groupe="+id+" and id_matiere=" + this.idm);
            while (Login.read.Read())
                label2.Text = Login.read["nom"].ToString() + " " + Login.read["prenom"].ToString();
            Login.read.Close();
            
            moyenne.Text = moy.Substring(0, 5);
            if (bunifuCircleProgressbar1.Value < 10)
                bunifuCircleProgressbar1.ProgressColor = Color.Red;
            else
                bunifuCircleProgressbar1.ProgressColor = Color.Green;
            Login.read = DBConnect.Gets("select distinct titre from examiner where id_groupe = "+id+ " and id_matiere=" + this.idm + " order by semestre,titre");
            int i = 0;
            while (Login.read.Read())
                cl_buttons[i++].Visible = true;
            Login.read.Close();

        }
        private void clickcc(object sender,EventArgs e)
        {
            chart ch = new chart(chart1,Home.id);
            Bunifu.Framework.UI.BunifuTileButton the_cc = ((Bunifu.Framework.UI.BunifuTileButton)sender);
            ch.addChartBy(nom: semestre[cl_buttons.IndexOf(the_cc)] + " " + the_cc.LabelText, semestre: semestre[cl_buttons.IndexOf(the_cc)], titre: the_cc.LabelText);

        }

        
    }
}