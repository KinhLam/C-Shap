using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void mnQuanLyKhachHang_ButtonClick(object sender, EventArgs e)
        {
            FrmQuanLyTaiKhoan frmQuanLyTaiKhoan = new FrmQuanLyTaiKhoan();
            frmQuanLyTaiKhoan.ShowDialog();
        }

        private void mnThemKhachHang_Click(object sender, EventArgs e)
        {
            FrmQuanLyTaiKhoan_Modified frmQuanLyTaiKhoan_Modified = new FrmQuanLyTaiKhoan_Modified();
            frmQuanLyTaiKhoan_Modified.ShowDialog();
        }

        private void mnDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            FrmQuanLyTaiKhoan frmQuanLyTaiKhoan = new FrmQuanLyTaiKhoan();
            frmQuanLyTaiKhoan.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            lblThongTinDangNhap.Text = string.Format("Tài khoản đăng nhập: {0}", ClsMain.taiKhoan);
        }

        private void mnThoat_ButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }
    }
}
