using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.BussinessLayer;

namespace WinFormsApp1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        bool trangThaiDongForm = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                if (!String.IsNullOrEmpty(txtMatKhau.Text))
                {
                    if(KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
                    {
                        trangThaiDongForm = true;
                        ClsMain.taiKhoan = txtTaiKhoan.Text;
                        ClsMain.users = bd.GetUsers();
                        this.Close();
                    }
                }
            }
        }
        BLLUser bd;
        private bool KiemTraDangNhap(string taiKhoan, string matKhau)
            {
                return bd.KiemTraUser(taiKhoan, matKhau);
            }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            trangThaiDongForm = true;
            Application.Exit();


        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trangThaiDongForm == true)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
