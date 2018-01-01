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
        }

        public void addChartBy(string nom="", SeriesChartType typechart= SeriesChartType.Column, string id_matiere ="", string unite="",string semestre="",string titre="") {
            string query= "SELECT id_etudiant,prenom ,nom, avg(note) as n from examiner , etudiant where etudiant.id=id_etudiant and  id_groupe='" + this.id_class+"' ";
            string query2="";
            
            if (id_matiere != "") 
                query2+="  id_matiere='"+id_matiere+"' and";
            if (unite != "")
                query2 += "  id_matiere='" + unite + "' and";
            if (semestre != "")
                query2 += "  id_matiere='" + semestre + "' and";
            if (titre != "")
                query2 += "  id_matiere='" + titre + "' and";
            if (query2.EndsWith("and"))
                query2 = query2.Substring(0,query2.Length-3);
            query2 += " group by id_etudiant ";




            Series s = new Series{
                ChartType = typechart
            };

            
            Login.read = DBConnect.Gets(query+query2);
            while (Login.read.Read())
                s.Points.AddXY(Login.read["nom"].ToString(), Double.Parse(Login.read["n"].ToString()));
            for (int i = 0; i < 30; i++)
                s.Points.AddXY("nom" + i, 18);
                s.Name = nom;
            this.c.Series.Add(s);
            //this.c.Series.Add(s);
            Login.read.Close();

        }


    }
}
