using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassarAdminDesktop
{
    static class Controller
    {
        public static bool checkFile(string path)
        {
            string[] d = path.Split('_');
            foreach(string w in d)
            Console.WriteLine(w);
            return true;
        }
    }
}
