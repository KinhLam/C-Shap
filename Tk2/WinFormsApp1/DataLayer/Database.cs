using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DataLayer
{
    internal class Database
    {
        string path = string.Empty;
        public Database(string path)
        {
            this.path = path;
        }
        //doc file
        public List<User> ReadUsers(ref string err)
        {
            List<User> users = null;
            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fileStream))
                    {
                        string line = string.Empty;
                        User user = new User();
                        users = new List<User>();
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] vs = line.Split(',');
                            user = new User()
                            {
                                ID = Convert.ToInt32(vs[0]),
                                TaiKhoan = vs[1],
                                SoTien = vs[2],
                                ThoiGian = vs[3],
                                MatKhau = vs[4]
                            };

                            users.Add(user);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;

            }
            return users;
        }
        public bool WriterUser(ref string err, List<User> users)
        {
            bool result = false;
            try

            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
                {
                    using (StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
                    {
                        foreach (User item in users)
                        {
                            streamWriter.WriteLine(item.ToString());
                        }

                    }
                }
                result = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return result;
        }
    }
}
