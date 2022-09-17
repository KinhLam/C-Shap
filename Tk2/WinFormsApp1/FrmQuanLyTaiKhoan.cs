using WinFormsApp1.BussinessLayer;
using WinFormsApp1.DataLayer;
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
    public partial class FrmQuanLyTaiKhoan : Form
    {
        public FrmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmQuanLyTaiKhoan_Modified frmQuanLyTaiKhoan_Modified = new FrmQuanLyTaiKhoan_Modified();
            frmQuanLyTaiKhoan_Modified.ShowDialog();
        }
    }
}
