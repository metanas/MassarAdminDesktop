using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using Bunifu.Framework.Lib;
using Bunifu.Framework.UI;

namespace MassarAdminDesktop
{
    class chart
    {
        string id_class;
        List<Color> col = new List<Color> { Color.FromArgb(150, 239, 147, 1), Color.FromArgb(150, 0, 115, 182), Color.FromArgb(150, 0, 166, 90), Color.FromArgb(150, 221, 76, 57), Color.FromArgb(150, 0, 131, 201), Color.FromArgb(150, 239, 147, 1) };

        public Chart c;
        ToolTip tp;
        static public int a = 0;


        public List<MaterialSkin.Controls.MaterialCheckBox> series_bs = new List<MaterialSkin.Controls.MaterialCheckBox>();
        public List<MaterialSkin.Controls.MaterialRadioButton> series_bb = new List<MaterialSkin.Controls.MaterialRadioButton>();

        public chart(Chart mychart, string id_class) {
            this.c = mychart;
            this.id_class = id_class;
            this.c.Series.Clear();
            this.c.ChartAreas[0].AxisX.Interval = 1;
            this.c.ChartAreas[0].AxisY.Maximum = 10;


            this.c.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            this.c.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            tp = new ToolTip();

        }

        public static void doubleCliick(object sender, EventArgs e)
        {
            if (((Chart)sender).Dock == DockStyle.Fill) ((Chart)sender).Dock = DockStyle.None;
            else ((Chart)sender).Dock = DockStyle.Fill;
        }


        public void addChartByEtudiant(string id_et)
        {
            int i = 0;

            Series s = new Series
            {
                ChartType = SeriesChartType.StackedBar

            };
            //            s.Name = "";
            s.IsVisibleInLegend = false;

            Login.read = DBConnect.Gets("SELECT avg(note), nom from examiner, matiere where id_matiere=id and id_etudiant = " + id_et + " and id_groupe = " + id_class + " GROUP BY id_matiere");
            while (Login.read.Read())
            {
                s.Points.AddXY(Login.read["nom"].ToString(), Double.Parse(Login.read[0].ToString()));
                s.Points[i].ToolTip = Math.Round(Double.Parse(Login.read[0].ToString()), 2, MidpointRounding.AwayFromZero).ToString();
                s.Points[i].Color = this.col[i++];


            }
            this.c.Series.Add(s);
            Login.read.Close();
        }

        public void addChartEvolutionSeries(Eleve eleve, Matiere matiere)
        {
            Series s = new Series
            {
                ChartType = SeriesChartType.Line


            };
            s.BorderWidth = 3;
            int i = 0;
            s.IsValueShownAsLabel = true;
            s.Name = matiere.intitule;
            Login.read = DBConnect.Gets(string.Format("SELECT avg(note), titre FROM examiner where id_etudiant = {0} and id_groupe = {1} and id_matiere = {2} group by titre order by titre", eleve.id, this.id_class, matiere.id));
            while (Login.read.Read())
            {
                s.Points.AddXY(Login.read[1].ToString(), Math.Round(float.Parse(Login.read[0].ToString()), 2));
                s.Points[i].MarkerSize = 9;
                s.Points[i++].MarkerStyle = MarkerStyle.Circle;

            }
            Login.read.Close();
            this.c.Series.Add(s);
            MaterialSkin.Controls.MaterialCheckBox b = new MaterialSkin.Controls.MaterialCheckBox();
            b.Text = s.Name;
            b.Checked = true;
            this.series_bs.Add(b);
            b.CheckedChanged += B_Click;
        }

        public void addChartEvolutionAnneeEleve(Eleve eleve)
        {
            Series s = new Series
            {
                ChartType = SeriesChartType.Line


            };
            s.BorderWidth = 3;
            int i = 0;
            s.IsValueShownAsLabel = true;
            s.IsVisibleInLegend = false;

            Login.read = DBConnect.Gets(string.Format("SELECT avg(note), titre FROM examiner where id_etudiant = {0} and id_groupe = {1} group by titre order by titre", eleve.id, this.id_class));
            while (Login.read.Read())
            {
                s.Points.AddXY(Login.read[1].ToString(), Math.Round(float.Parse(Login.read[0].ToString()), 2));
                s.Points[i].MarkerSize = 9;
                s.Points[i++].MarkerStyle = MarkerStyle.Circle;

            }
            Login.read.Close();
            this.c.Series.Add(s);

        }

        public void evoann()
        {
            int i = 0;
            Series s = new Series
            {
                ChartType = SeriesChartType.Line
            };
            this.c.ChartAreas[0].AxisY.Maximum = 100;
            s.Name = "Taux de reussite par annee";
            Login.read = DBConnect.Gets("select avg(note),annee_scolaire from examiner,annee where id_annee=id group by id_annee");
            while (Login.read.Read())
            {
                s.Points.AddXY(Login.read[1].ToString(), Double.Parse(Login.read[0].ToString()) * 10);
                s.Points[i].MarkerSize = 9;
                s.Points[i++].MarkerStyle = MarkerStyle.Circle;

            }
            this.c.Series.Add(s);
            //this.c.Series.Add(s);
            Login.read.Close();
        }


        public void B_Click(object sender, EventArgs e)
        {
            CheckBox series_b = (CheckBox)sender;
            this.c.Series[series_b.Text].Enabled = series_b.Checked;
        }
        public void Bb_Click(object sender, EventArgs e)
        {
            RadioButton series_bb = (RadioButton)sender;
            this.c.Series[series_bb.Text].Enabled = series_bb.Checked;
        }
        public void addChartBy(string nom = "", SeriesChartType typechart = SeriesChartType.Column, string id_matiere = "", string unite = "", string semestre = "", string titre = "") {
            string query2 = "SELECT id_etudiant,prenom ,nom, avg(note) as n from examiner , etudiant where etudiant.id=id_etudiant and  id_groupe=" + this.id_class + " and";

            if (id_matiere != "")
                query2 += " id_matiere=" + id_matiere + " and";
            if (unite != "")
                query2 += " unite='" + unite + "' and";
            if (semestre != "")
                query2 += " semestre='" + semestre + "' and";
            if (titre != "")
                query2 += " titre='" + titre + "' and";
            if (query2.EndsWith("and"))
                query2 = query2.Substring(0, query2.Length - 3);
            query2 += " group by id_etudiant ";

            Series s = new Series {
                ChartType = typechart
            };


            Login.read = DBConnect.Gets(query2);
            int q = 0;
            while (Login.read.Read())
            {
                s.Points.AddXY(Login.read["nom"].ToString(), Double.Parse(Login.read["n"].ToString()));
                s.Points[q++].ToolTip = Math.Round(Double.Parse(Login.read["n"].ToString()), 2, MidpointRounding.AwayFromZero).ToString();
            }
            s.Name = nom;
            this.c.Series.Add(s);
            //this.c.Series.Add(s);
            Login.read.Close();

        }
        public void addChartEvolutionUnites(Eleve eleve, Matiere matiere)
        {
            Series s = new Series
            {
                ChartType = SeriesChartType.Column


            };
           
            int i = 0;
            s.IsValueShownAsLabel = true;
            s.Name = matiere.intitule;
            Login.read = DBConnect.Gets("Select unite , avg(note) from examiner where id_matiere=" + matiere.id + " and  id_etudiant=" + eleve.id + " group by unite");
            while (Login.read.Read())
            {
                s.Points.AddXY(Login.read[0].ToString(), Math.Round(float.Parse(Login.read[1].ToString()), 2));
                s.Points[i].MarkerSize = 9;
                s.Points[i].Color = this.col[i++];


            }
            Login.read.Close();
            
            MaterialSkin.Controls.MaterialRadioButton bb = new MaterialSkin.Controls.MaterialRadioButton();
            this.c.Series.Add(s);
            bb.Text = s.Name;
            this.series_bb.Add(bb);
            bb.CheckedChanged += Bb_Click;
          


        }
    }
}
