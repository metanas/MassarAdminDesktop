using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MassarAdminDesktop
{
    public class Eleve
    {
        public string id;
        public string mass_id;
        public string nom { get; set; }
        public string prenom { get; set; }
        public string nom_ar;
        public string nom_fr;
        public string sexe;
        public string date_naissance;
        public string ville_naissance;
        public string ville_naissance_ar;
        public string adresse;

        public Eleve(string id, string mass_id, string nom, string prenom, string nom_ar, string nom_fr, string sexe, 
            string ville_naissance, string ville_naissance_ar, string adresse, string date_naissance= "")
        {
            this.id = id;
            this.mass_id = mass_id;
            this.nom = nom; 
            this.prenom = prenom;
            this.nom_ar = nom_ar;
            this.nom_fr = nom_fr;
            this.sexe = sexe;
            this.date_naissance = date_naissance;
            this.ville_naissance = ville_naissance;
            this.ville_naissance_ar = ville_naissance_ar;
            this.adresse = adresse;
        }

        public float moyenne(string id_groupe)
        {
            string Avg = DBConnect.Get("SELECT avg(note) from examiner where id_groupe=" + id_groupe + " and id_etudiant=" + this.id);
            if (Avg == "") Avg = "0";
            return float.Parse(Avg);
        }
    }


}
