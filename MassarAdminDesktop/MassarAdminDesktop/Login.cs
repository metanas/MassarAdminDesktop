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
    public partial class Login : Form
    {
        public static DBConnect bd;
        public static Admin admin;
        public static MySqlDataReader read;
        bool x;
        public Login()
        {
            InitializeComponent();
            nom.Focus();
        }

        private async void ButtonClickHandlerAsync(object sender, EventArgs e)
        {
            bd = new DBConnect();
            admin = new Admin();
            await Task.Run(() =>
            {
                x = admin.login(nom.Text, password.Text);
            });
            if (!x)
            {
                MessageBox.Show("les informations incorrects");
                return;
            }
            nom.Text = "";
            password.Text = "";
            HomePreview.HomeForm.Text = "hello";
            this.Close();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonClickHandlerAsync(sender, e);
            }
        }

        private void Groupe_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }

        private void Option_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            option.ShowDialog();
        }

        private void Option_MouseHover(object sender, EventArgs e)
        {
            Option.ForeColor = Color.FromArgb(150, 150, 150);
        }

        private void Option_MouseLeave(object sender, EventArgs e)
        {
            Option.ForeColor = Color.FromArgb(54, 78, 102);
        }
    }
}


