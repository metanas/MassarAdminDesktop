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
    public partial class viewprofesseur : Form
    {
        public viewprofesseur()
        {
            InitializeComponent();
        }
        List<List<string>> pl = new List<List<string>>();
        private void viewprofesseur_Load(object sender, EventArgs e)
        {
            List<string> tmp = new List<string>();
            Login.read = DBConnect.Gets("select e.nom,e.prenom,avg(ex.note) from annee as a , examiner as ex, groupe as g , enseignant as e , groupe_matiere_enseignant as gme where gme.id_enseignant=e.id  and gme.id_groupe=g.id and gme.id_groupe=ex.id_groupe and gme.id_matiere=ex.id_matiere and ex.id_annee=a.id and a.annee_scolaire='" + HomePreview.idann + "' group by e.id");
            while (Login.read.Read())
            {
                pl.Add(new List<string>());
                pl[pl.Count - 1].Add(Login.read[0].ToString());
                pl[pl.Count - 1].Add(Login.read[1].ToString());
                pl[pl.Count - 1].Add(Login.read[2].ToString());
            }
            Login.read.Close();
            setData(pl);
        }
        void setData(List<List<string>> t)
        {
            bunifuCustomDataGrid1.Rows.Clear();
            for (int i=0;i<t.Count;i++)
                bunifuCustomDataGrid1.Rows.Add(t[i][0], t[i][1], (Math.Round(Double.Parse(t[i][2].ToString()) * 10, 2)) + " %");

        }
        private void Groupe_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }

        private void search_OnTextChange(object sender, EventArgs e)
        {
            List<List<string>> t = new List<List<string>>();
            if(search.text != "")
            {
                for (int i = 0; i < pl.Count; i++)
                {
                    if(pl[i][0].ToUpper().Contains(search.text.ToUpper()) || pl[i][1].ToUpper().Contains(search.text.ToUpper()))
                    {
                        t.Add(pl[i]);
                    }
                }
                setData(t);
            }
            else { setData(pl); }
        }
    }
}
