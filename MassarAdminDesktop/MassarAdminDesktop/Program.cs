using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassarAdminDesktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool tw = false;
            try
            {
                using (StreamReader sr = File.OpenText(@"C:\\Massar\Installer.txt"))
                {
                    tw = true;
                    if (sr.ReadLine() == "Installed")
                    {
                        sr.Close();
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new HomePreview());
                    }
                    else
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Installer());
                    }
                }
            }
            catch(FileNotFoundException ex)
            {
                if (!tw)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Installer());
                }
            }
           
        }
    }
}
