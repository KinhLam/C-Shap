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

        private void mnQuanLyNhanVien_ButtonClick(object sender, EventArgs e)
        {
            FrmQuanLyNhanvien frmQuanLyNhanVien = new FrmQuanLyNhanvien();
            frmQuanLyNhanVien.ShowDialog();
        }

        private void mnThemNhanVien_Click(object sender, EventArgs e)
        {
            FrmQuanLyNhanvien_Modified frmQuanLyNhanVien_Modified = new FrmQuanLyNhanvien_Modified();
            frmQuanLyNhanVien_Modified.ShowDialog();
        }

        private void mnDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            FrmQuanLyNhanvien frmQuanLyNhanVien = new FrmQuanLyNhanvien();
            frmQuanLyNhanVien.ShowDialog();
        }
    }
}
