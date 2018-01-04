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
    public partial class Eleves : Form
    {
        string id;
        public List<Eleve> el = new List<Eleve>();
        public Eleves(string id)
        {
            this.id = id;
            InitializeComponent();
            el.Clear();
            Login.read = DBConnect.
                Gets("SELECT id, id_massar, nom, prenom, nom_ar, prenom_ar, sexe, ville_naissance, ville_naissance_ar, adresse, date_naissance FROM etudiant, etudiant_groupe where id_groupe = " + id+" and id_etudiant = id");
            while (Login.read.Read())
            {
                //Login.read[7].ToString()
                Eleve e = new Eleve(Login.read[0].ToString(), Login.read[1].ToString(), Login.read[2].ToString(), Login.read[3].ToString(), Login.read[4].ToString(), Login.read[5].ToString(), Login.read[6].ToString(), Login.read[7].ToString(), Login.read[8].ToString(), Login.read[9].ToString());

                el.Add(e);
            }

            Login.read.Close();
            render_eleves();
        }

        
        void render_eleves()
        {
            foreach (Eleve e in el)
                dgv_eleves.Rows.Add(e.nom, e.prenom, e.moyenne(id));
        }

        private void dgv_eleves_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            chart c = new chart(chart_e, this.id);
            c.addChartByEtudiant(el[e.RowIndex].id);
        }
    }
}
