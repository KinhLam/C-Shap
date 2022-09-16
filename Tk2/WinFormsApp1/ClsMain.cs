using WinFormsApp1.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class ClsMain
    {
        public static string taiKhoan= string .Empty;
       public static string path = string .Format(@"{0}\Users.ini", Application.StartupPath);
        public static List<User> users = null;
    }
}
