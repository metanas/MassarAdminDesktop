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
namespace MassarAdminDesktop
{
    class chart
    {
        string id_class;
        
        Chart c;
        public  chart (Chart mychart,string id_class) {
            this.c = mychart;
            this.id_class = id_class;
            this.c.Series.Clear();
            this.c.ChartAreas[0].AxisX.Interval = 1;
            this.c.ChartAreas[0].AxisY.Maximum = 20;
            
        }

        public void addChartByEtudiant(string id_et)
        {
            int i = 0;
            List<Color> col = new List<Color> {Color.AliceBlue, Color.Aqua, Color.Aquamarine,Color.Brown, Color.Cornsilk, Color.DarkGreen };
            Series s = new Series
            {
                ChartType = SeriesChartType.StackedBar
                
            };
            //            s.Name = "";
            s.IsVisibleInLegend = false;
            
            Login.read = DBConnect.Gets("SELECT avg(note), nom from examiner, matiere where id_matiere=id and id_etudiant = "+id_et+" and id_groupe = "+id_class+" GROUP BY id_matiere");
            while (Login.read.Read())
            {
                s.Points.AddXY(Login.read["nom"].ToString(), Double.Parse(Login.read[0].ToString()));
                s.Points[i].Color = col[i++];
            }
            this.c.Series.Add(s);
            Login.read.Close();
        }

        public void addChartHistorique(string id_et)
        {
            Series s = new Series
            {
                ChartType = SeriesChartType.StackedBar

            };
        }

        public void addChartBy(string nom="", SeriesChartType typechart= SeriesChartType.Column, string id_matiere ="", string unite="",string semestre="",string titre="") {
            string query2= "SELECT id_etudiant,prenom ,nom, avg(note) as n from examiner , etudiant where etudiant.id=id_etudiant and  id_groupe=" + this.id_class+" and";

            if (id_matiere != "") 
                query2+=" id_matiere="+id_matiere+" and";
            if (unite != "")
                query2 += " unite='" + unite + "' and";
            if (semestre != "")
                query2 += " semestre='" + semestre + "' and";
            if (titre != "")
                query2 += " titre='" + titre + "' and";
            if (query2.EndsWith("and"))
                query2 = query2.Substring(0,query2.Length-3);
            query2 += " group by id_etudiant ";

            Series s = new Series{
                ChartType = typechart
            };

            
            Login.read = DBConnect.Gets(query2);
            while (Login.read.Read())
                s.Points.AddXY(Login.read["nom"].ToString(), Double.Parse(Login.read["n"].ToString()));
            
                s.Name = nom;
            this.c.Series.Add(s);
            //this.c.Series.Add(s);
            Login.read.Close();

        }
    }
}
