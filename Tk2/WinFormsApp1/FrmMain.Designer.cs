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
            this.mnStrip = new System.Windows.Forms.ToolStrip();
            this.mnQuanLyKhachHang = new System.Windows.Forms.ToolStripSplitButton();
            this.mnThemKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDanhSachKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangXuat = new System.Windows.Forms.ToolStripButton();
            this.mnThoat = new System.Windows.Forms.ToolStripSplitButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblThongTinDangNhap = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnStrip
            // 
            this.mnStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnQuanLyKhachHang,
            this.mnDangXuat,
            this.mnThoat});
            this.mnStrip.Location = new System.Drawing.Point(0, 0);
            this.mnStrip.Name = "mnStrip";
            this.mnStrip.Size = new System.Drawing.Size(1169, 25);
            this.mnStrip.TabIndex = 0;
            this.mnStrip.Text = "toolStrip1";
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
            this.mnQuanLyKhachHang.Size = new System.Drawing.Size(129, 22);
            this.mnQuanLyKhachHang.Text = "Quản lý khách hàng";
            this.mnQuanLyKhachHang.ButtonClick += new System.EventHandler(this.mnQuanLyKhachHang_ButtonClick);
            // 
            // mnThemKhachHang
            // 
            this.mnThemKhachHang.Name = "mnThemKhachHang";
            this.mnThemKhachHang.Size = new System.Drawing.Size(195, 22);
            this.mnThemKhachHang.Text = "Thêm khách hàng";
            this.mnThemKhachHang.Click += new System.EventHandler(this.mnThemKhachHang_Click);
            // 
            // mnDanhSachKhachHang
            // 
            this.mnDanhSachKhachHang.Name = "mnDanhSachKhachHang";
            this.mnDanhSachKhachHang.Size = new System.Drawing.Size(195, 22);
            this.mnDanhSachKhachHang.Text = "Danh sách Khách hàng";
            this.mnDanhSachKhachHang.Click += new System.EventHandler(this.mnDanhSachKhachHang_Click);
            // 
            // mnDangXuat
            // 
            this.mnDangXuat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("mnDangXuat.Image")));
            this.mnDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnDangXuat.Name = "mnDangXuat";
            this.mnDangXuat.Size = new System.Drawing.Size(65, 22);
            this.mnDangXuat.Text = "Đăng xuất";
            this.mnDangXuat.Click += new System.EventHandler(this.mnDangXuat_Click);
            // 
            // mnThoat
            // 
            this.mnThoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnThoat.Image = ((System.Drawing.Image)(resources.GetObject("mnThoat.Image")));
            this.mnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnThoat.Name = "mnThoat";
            this.mnThoat.Size = new System.Drawing.Size(53, 22);
            this.mnThoat.Text = "Thoát";
            this.mnThoat.ButtonClick += new System.EventHandler(this.mnThoat_ButtonClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblThongTinDangNhap});
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1169, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblThongTinDangNhap
            // 
            this.lblThongTinDangNhap.Name = "lblThongTinDangNhap";
            this.lblThongTinDangNhap.Size = new System.Drawing.Size(16, 17);
            this.lblThongTinDangNhap.Text = "...";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 467);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mnStrip.ResumeLayout(false);
            this.mnStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip mnStrip;
        private ToolStripSplitButton mnQuanLyKhachHang;
        private ToolStripMenuItem mnThemKhachHang;
        private ToolStripMenuItem mnDanhSachKhachHang;
        private ToolStripButton mnDangXuat;
        private ToolStripSplitButton mnThoat;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblThongTinDangNhap;
    }
}