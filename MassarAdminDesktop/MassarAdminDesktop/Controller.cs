using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassarAdminDesktop
{
    static class Controller
    {
        public static string[] checkFile(string path)
        {
            string[] d = path.Split('_');
            return d;
        }
    }
}
