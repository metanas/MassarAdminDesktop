using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassarAdminDesktop
{
    public partial class Option : Form
    {
        public static string stringConnection;
        int tog;
        int mvalX;
        int mvalY;
        public Option()
        {
            InitializeComponent();
            string[] lw = new string[4] { " ", " ", " ", " " };
            using (StreamReader sr = File.OpenText(@"C:\\Massar\.ConfigurationDB.txt"))
            {
                string tables;
                int i = 0;  
                while ((tables = sr.ReadLine()) != null)
                {
                    lw[i++] = tables;
                }
            }
            stringConnection = "SERVER=" + lw[0] + ";" + "DATABASE=" +
                lw[1] + ";" + "UID=" + lw[2] + ";" + "PASSWORD=" + lw[3] + "; Character Set=utf8";
            server.Text = (lw[0] == " ") ? "" : lw[0];
            database.Text = (lw[1] == " ") ? "" :lw[1];
            username.Text = (lw[2] == " ") ? "" : lw[2];
            password.Text = (lw[0] == " ") ? "" : lw[3];
        }
       
        private async void test_Click(object sender, EventArgs e)
        {

            string connectionString = "SERVER=" + server.Text + ";" + "DATABASE=" +
                       database.Text + ";" + "UID=" + username.Text + ";" + "PASSWORD=" + password.Text + "; Character Set=utf8";
            bunifuCircleProgressbar1.Visible = true;
            test.Text = "";
            label1.Text = "";
            bool work = false;
            await Task.Run(() =>
            {
                try
                {
                    DBConnect.connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
                    DBConnect.connection.Open();
                    work = true;
                }
                catch
                {
                    work = false;
                }
            });
            if (work)
            {
                label1.Text = "connexion réussie";
                label1.ForeColor = Color.LightGreen;
            }
            else
            {
                label1.Text = "connection échoué";
                label1.ForeColor = Color.DarkRed;
            }
            bunifuCircleProgressbar1.Visible = false;
            test.Text = "Tester";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteToFile();
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

        public void ReadFromFile()
        {
            using (StreamReader sr = File.OpenText(@"C:\\Massar\.ConfigurationDB.txt"))
            {
                string tables;
                int i = 0;
                MaterialSkin.Controls.MaterialSingleLineTextField[] l = new MaterialSkin.Controls.MaterialSingleLineTextField[] { server, database, username, password }; 
                while ((tables = sr.ReadLine()) != null)
                {
                    l[i++].Text = tables;
                }
            }
        }

        public void WriteToFile()
        {
            using (StreamWriter sw = File.CreateText(@"C:\\Massar\.ConfigurationDB.txt"))
            {
                sw.WriteLine(server.Text);
                sw.WriteLine(database.Text);
                sw.WriteLine(username.Text);
                sw.WriteLine(password.Text);
            }
        }
    }
}
