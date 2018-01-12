using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace MassarAdminDesktop
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        public static DBConnect bd;
        public static Admin admin;
        public static MySqlDataReader read;
        bool x;
        public Login()
        {

            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue900, MaterialSkin.Primary.Blue900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            bd = new DBConnect();
            admin = new Admin();
        }

        private async void ButtonClickHandlerAsync(object sender, EventArgs e)
        {
            log_in.Text = "";
            bunifuCircleProgressbar1.Visible = true;
            await Task.Run(() =>
            {
                x = admin.login(nom.Text, password.Text);
            });
            log_in.Text = "Connexion";
            bunifuCircleProgressbar1.Visible = false;
            if (!x)
            {
                MessageBox.Show("les informations incorrects");
                return;
            }
            nom.Text = "";
            password.Text = "";
            Home home = new Home(this);
            home.Show();
            
            this.Hide();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonClickHandlerAsync(sender, e);
            }
        }
    }
}


