using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace MassarAdminDesktop
{
    public class Admin
    {
        public bool logined;
        public string nom;
        public string id;
        public bool isSuper;



        public bool login(string nom, string pass)
        {
            this.logined = false;
            if (sqlingection(nom) || sqlingection(pass))
                return false;
            MySqlDataReader r = DBConnect.Gets("select * from admin where password='" + cript(pass) + "' and nom='" + nom + "' ;");
            while (r.Read())
            {
                this.id = r["id"].ToString();
                this.nom = r["nom"].ToString();
                this.isSuper = Convert.ToBoolean(r["isSuper"].ToString());
                this.logined = true;
            }
            r.Close();
            if (!this.logined)
                return false;
            return true;

        }
        private bool sqlingection(string s)
        {
            if (s.Contains("'") || s.Contains("`") || s.Contains('"'))
                return true;
            return false;
        }

        public string cript(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

        public string newAdmin(string nom, string pass, bool isSuper)
        {
            if (!this.isSuper)
                return "  ";
            if (sqlingection(nom) || sqlingection(pass) || sqlingection(isSuper.ToString()))
                return "les informations ne doit pas contenir ces lettres  ( `  '  " + '"' + " ) ";
            if (nom.Length < 8 || pass.Length < 8)
                return "minimum 8 lettres ";
            if (DBConnect.Post("insert into admin (nom,password,isSuper) values ('" + nom + "','" + cript(pass) + "','" + isSuper.ToString() + "')"))
                return "nouveau admin est bien cree";
            return "error verifiez votre connexion ou duplication des Admins";
        }

        public string ModifierAdmin(string nom ,string pass,string isSuper) {
            if (!this.isSuper)
                return "  ";

            if ( sqlingection(pass) || sqlingection(isSuper.ToString()))
                return "les informations ne doit pas contenir ces lettres  ( `  '  " + '"' + " ) ";
            if ((pass.Length < 8 && pass.Length > 0))
                return "minimum 8 lettres en mot de passe";
            else if (pass.Length > 0)
                pass = " , password='" + cript(pass) + "'  ";
            else pass = "";

            if (DBConnect.Post("update  admin set isSuper='"+isSuper+"'"+pass+" where nom='"+nom+"' ; "))
                return "Admin bien modifie";
            return "error verifiez votre connexion ";
        
        }
        public string SupprimerAdmin(string nom)
        {
            if (!this.isSuper)
                return "  ";
            if (DBConnect.Post("delete from admin where nom='" + nom + "'  ; "))
                return "Admin bien supprimee";
            return "error verifiez votre connexion ";
        }

    }
}

