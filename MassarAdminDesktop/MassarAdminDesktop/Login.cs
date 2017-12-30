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
namespace MassarAdminDesktop
{
    public partial class Login : Form
    {
        public static DBConnect bd;
        public static Admin admin;
        public static MySqlDataReader read;
        public Login()
        {

            InitializeComponent();
           

            bd = new DBConnect();

            //  read = bd.Gets("select * from etudiant ");

            // MessageBox.Show(bd.Get("select * from etudiant "));
            // MessageBox.Show(admin.cript("ramzi"));
            admin = new Admin();
            //   Admin.isSuper = true;
            //  Admin.newAdmin("ramzinedjari","ramzi150",true);


        }

        private void log_in_Click(object sender, EventArgs e)
        {
            if (!admin.login(nom.Text, password.Text))
            {
                MessageBox.Show("les informations incorrects");
                return;
            }
            nom.Text = "";
            password.Text = "";
           // MessageBox.Show("login succseful Admin : "+admin.nom);
          // change the messageBox by opening   the Main IHM
            Home home = new Home();
            home.Show();
        }

       





    }
}


