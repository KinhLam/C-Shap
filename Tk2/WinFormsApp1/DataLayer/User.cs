using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DataLayer
{
    public class User
    {
        private int iD;
        private string taiKhoan;
        private string soTien;
        private string thoiGian;
        private string matKhau;
       

        public int ID { get {return iD; } set {iD= value; } }
        public string TaiKhoan { get { return taiKhoan; } set { taiKhoan= value;} }
        public string SoTien { get { return soTien; } set { soTien= value; } }
        public string ThoiGian { get { return thoiGian; } set { thoiGian= value; } }
        public string MatKhau { get { return matKhau; } set { matKhau= value;} }
    }


    
}
