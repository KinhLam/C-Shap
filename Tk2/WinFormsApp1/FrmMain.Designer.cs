namespace WinFormsApp1
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnQuanLyKhachHang = new System.Windows.Forms.ToolStripSplitButton();
            this.mnQuanLyNhanVien = new System.Windows.Forms.ToolStripSplitButton();
            this.mnDangXuat = new System.Windows.Forms.ToolStripButton();
            this.mnThemKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDanhSachKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThoat = new System.Windows.Forms.ToolStripSplitButton();
            this.mnThemNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDanhSachNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnQuanLyKhachHang,
            this.mnQuanLyNhanVien,
            this.mnDangXuat,
            this.mnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1336, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnQuanLyKhachHang
            // 
            this.mnQuanLyKhachHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnQuanLyKhachHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThemKhachHang,
            this.mnDanhSachKhachHang});
            this.mnQuanLyKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanLyKhachHang.Image")));
            this.mnQuanLyKhachHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnQuanLyKhachHang.Name = "mnQuanLyKhachHang";
            this.mnQuanLyKhachHang.Size = new System.Drawing.Size(157, 24);
            this.mnQuanLyKhachHang.Text = "Quản lý khách hàng";
            this.mnQuanLyKhachHang.ButtonClick += new System.EventHandler(this.mnQuanLyKhachHang_ButtonClick);
            // 
            // mnQuanLyNhanVien
            // 
            this.mnQuanLyNhanVien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnQuanLyNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThemNhanVien,
            this.mnDanhSachNhanVien});
            this.mnQuanLyNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanLyNhanVien.Image")));
            this.mnQuanLyNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnQuanLyNhanVien.Name = "mnQuanLyNhanVien";
            this.mnQuanLyNhanVien.Size = new System.Drawing.Size(145, 24);
            this.mnQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.mnQuanLyNhanVien.ButtonClick += new System.EventHandler(this.mnQuanLyNhanVien_ButtonClick);
            // 
            // mnDangXuat
            // 
            this.mnDangXuat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("mnDangXuat.Image")));
            this.mnDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnDangXuat.Name = "mnDangXuat";
            this.mnDangXuat.Size = new System.Drawing.Size(81, 24);
            this.mnDangXuat.Text = "Đăng xuất";
            // 
            // mnThemKhachHang
            // 
            this.mnThemKhachHang.Name = "mnThemKhachHang";
            this.mnThemKhachHang.Size = new System.Drawing.Size(241, 26);
            this.mnThemKhachHang.Text = "Thêm khách hàng";
            this.mnThemKhachHang.Click += new System.EventHandler(this.mnThemKhachHang_Click);
            // 
            // mnDanhSachKhachHang
            // 
            this.mnDanhSachKhachHang.Name = "mnDanhSachKhachHang";
            this.mnDanhSachKhachHang.Size = new System.Drawing.Size(241, 26);
            this.mnDanhSachKhachHang.Text = "Danh sách Khách hàng";
            this.mnDanhSachKhachHang.Click += new System.EventHandler(this.mnDanhSachKhachHang_Click);
            // 
            // mnThoat
            // 
            this.mnThoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnThoat.Image = ((System.Drawing.Image)(resources.GetObject("mnThoat.Image")));
            this.mnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnThoat.Name = "mnThoat";
            this.mnThoat.Size = new System.Drawing.Size(66, 24);
            this.mnThoat.Text = "Thoát";
            // 
            // mnThemNhanVien
            // 
            this.mnThemNhanVien.Name = "mnThemNhanVien";
            this.mnThemNhanVien.Size = new System.Drawing.Size(227, 26);
            this.mnThemNhanVien.Text = "Thêm nhân viên";
            this.mnThemNhanVien.Click += new System.EventHandler(this.mnThemNhanVien_Click);
            // 
            // mnDanhSachNhanVien
            // 
            this.mnDanhSachNhanVien.Name = "mnDanhSachNhanVien";
            this.mnDanhSachNhanVien.Size = new System.Drawing.Size(227, 26);
            this.mnDanhSachNhanVien.Text = "Danh sách nhân viên";
            this.mnDanhSachNhanVien.Click += new System.EventHandler(this.mnDanhSachNhanVien_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 623);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripSplitButton mnQuanLyKhachHang;
        private ToolStripSplitButton mnQuanLyNhanVien;
        private ToolStripMenuItem mnThemKhachHang;
        private ToolStripMenuItem mnDanhSachKhachHang;
        private ToolStripMenuItem mnThemNhanVien;
        private ToolStripMenuItem mnDanhSachNhanVien;
        private ToolStripButton mnDangXuat;
        private ToolStripSplitButton mnThoat;
    }
}