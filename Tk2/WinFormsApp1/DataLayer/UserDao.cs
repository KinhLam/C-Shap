using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DataLayer
{
    internal class UserDao
    {
        private List<User> users;
        public List<User> Users { get { return users; } set { users = value; } }
        Database database;
        public UserDao()
        {
            users = new List<User>() {
            new User()
            {
                ID = 1, TaiKhoan = "admin", SoTien = "30000", ThoiGian = "10 tieng", MatKhau = "admin"
            },
            new User()
            {
                ID = 2,
                TaiKhoan = "khoa",
                SoTien = "30000",
                ThoiGian = "10 tieng",
                MatKhau = "1234"
            }
            };
        }
        public UserDao(ref string err,string path)
        {
            users= new List<User>();    
            database = new Database(path);
            users = database.ReadUsers(ref err);
        }
        public bool WriterUser(ref string err, List<User> users)
        {
            return database.WriterUser(ref err, users);
        }
        public bool WriterUser(ref string err)
        {
            return database.WriterUser(ref err, users);
        }
    }
}
