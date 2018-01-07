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

        private void viewprofesseur_Load(object sender, EventArgs e)
        {
            Login.read = DBConnect.Gets("select e.nom,e.prenom,avg(ex.note) from annee as a , examiner as ex, groupe as g , enseignant as e , groupe_matiere_enseignant as gme where gme.id_enseignant=e.id  and gme.id_groupe=g.id and gme.id_groupe=ex.id_groupe and gme.id_matiere=ex.id_matiere and ex.id_annee=a.id and a.annee_scolaire='"+Home.idann+"' group by e.id");
            while (Login.read.Read())
                bunifuCustomDataGrid1.Rows.Add(Login.read[0].ToString(), Login.read[1].ToString(),(Math.Round(Double.Parse(Login.read[2].ToString())*10,2))+"%");
            Login.read.Close();
        }
        private void Groupe_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }
    }
}
