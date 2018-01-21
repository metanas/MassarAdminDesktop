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
    public partial class Option : Form
    {
        string serverdefault = "31.220.105.14";
        string databasedefault = "offerson_masar";
        string uiddefault = "offerson_ramzi";
        string passworddefault = "ramzi150";
        public static string stringConnection;
        int tog;
        int mvalX;
        int mvalY;
        public Option()
        {
            InitializeComponent();
            stringConnection = "SERVER=" + serverdefault + ";" + "DATABASE=" +
                       databasedefault + ";" + "UID=" + uiddefault + ";" + "PASSWORD=" + passworddefault + "; Character Set=utf8";
        }
       
        private void test_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=" + server.Text + ";" + "DATABASE=" +
                       database.Text + ";" + "UID=" + username.Text + ";" + "PASSWORD=" + password.Text + "; Character Set=utf8";
            try {
                DBConnect.connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
                DBConnect.connection.Open();
                label1.Text = "connection reussie";
                label1.ForeColor = Color.LightGreen;
            }
            catch
            {
                label1.Text = "connection failed";
                label1.ForeColor = Color.DarkRed;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stringConnection = "SERVER=" + server.Text + ";" + "DATABASE=" +
                       database.Text + ";" + "UID=" + username.Text + ";" + "PASSWORD=" + password.Text + "; Character Set=utf8";
            this.Close();
        }

        private void Canncel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            tog = 1;
            mvalX = e.Location.X;
            mvalY = e.Location.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            tog = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tog == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mvalX, MousePosition.Y - mvalY);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
