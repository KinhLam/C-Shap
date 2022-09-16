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
       
        private bool KiemTraDangNhap(string taiKhoan, string matKhau)
            {
                return bd.KiemTraUser(taiKhoan, matKhau);
            //if (taiKhoan.Equals("admin") && matKhau.Equals("admin"))
            //    return true;
            //return false;
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
        bool trangThaiDongForm = false;
        BLLUser bd;
        string err = string.Empty;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                if (!string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    if (KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
                    {
                        trangThaiDongForm = true;
                        ClsMain.taiKhoan = txtTaiKhoan.Text;
                        ClsMain.users = bd.GetUsers();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản và mật khẩu không đúng \n Xin lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTaiKhoan.ResetText();
                        txtMatKhau.Text = string.Empty;
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập mật khẩu \n Xin lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tài khoản \n Xin lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(ref err, ClsMain.path);
        }
    }
}
