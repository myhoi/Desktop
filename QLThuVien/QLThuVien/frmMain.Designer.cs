namespace QuanLyThuVien
{
    partial class frmMain
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSach;
        private System.Windows.Forms.TabPage tabMuonSach;

        // Quản lý Sách
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.TextBox txtMaSach, txtTenSach, txtTacGia, txtNamXB, txtNhaXB, txtTriGia;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Button btnThemSach, btnSuaSach, btnXoaSach, btnLamMoiSach, btnLocSach;
        private System.Windows.Forms.ComboBox cmbLocMaSach;

        // Quản lý Mượn Sách
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.TextBox txtMaPhieuMuon;
        private System.Windows.Forms.ComboBox cmbMaSachMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon, dtpNgayTra;
        private System.Windows.Forms.Button btnThemPM, btnSuaPM, btnXoaPM, btnLamMoiPM, btnThongKeQuaHan;


        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSach = new System.Windows.Forms.TabPage();
            this.tabMuonSach = new System.Windows.Forms.TabPage();

            // ========== Tab Quản lý Sách ==========
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.txtNhaXB = new System.Windows.Forms.TextBox();
            this.txtTriGia = new System.Windows.Forms.TextBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnSuaSach = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnLamMoiSach = new System.Windows.Forms.Button();
            this.cmbLocMaSach = new System.Windows.Forms.ComboBox();
            this.btnLocSach = new System.Windows.Forms.Button();

            // ========== Tab Quản lý Mượn Sách ==========
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.txtMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.cmbMaSachMuon = new System.Windows.Forms.ComboBox();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.btnThemPM = new System.Windows.Forms.Button();
            this.btnSuaPM = new System.Windows.Forms.Button();
            this.btnXoaPM = new System.Windows.Forms.Button();
            this.btnLamMoiPM = new System.Windows.Forms.Button();
            this.btnThongKeQuaHan = new System.Windows.Forms.Button();

            // TabControl
            this.tabControl1.Controls.Add(this.tabSach);
            this.tabControl1.Controls.Add(this.tabMuonSach);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;

            // ========== Tab Sách ==========
            this.tabSach.Text = "Quản lý Sách";
            this.tabSach.Controls.Add(this.dgvSach);
            this.tabSach.Controls.Add(this.txtMaSach);
            this.tabSach.Controls.Add(this.txtTenSach);
            this.tabSach.Controls.Add(this.txtTacGia);
            this.tabSach.Controls.Add(this.txtNamXB);
            this.tabSach.Controls.Add(this.txtNhaXB);
            this.tabSach.Controls.Add(this.txtTriGia);
            this.tabSach.Controls.Add(this.dtpNgayNhap);
            this.tabSach.Controls.Add(this.btnThemSach);
            this.tabSach.Controls.Add(this.btnSuaSach);
            this.tabSach.Controls.Add(this.btnXoaSach);
            this.tabSach.Controls.Add(this.btnLamMoiSach);
            this.tabSach.Controls.Add(this.cmbLocMaSach);
            this.tabSach.Controls.Add(this.btnLocSach);

            // Đặt vị trí, kích thước các control
            this.dgvSach.Location = new System.Drawing.Point(20, 180);
            this.dgvSach.Size = new System.Drawing.Size(700, 250);

            this.txtMaSach.Location = new System.Drawing.Point(20, 20);
            this.txtMaSach.Size = new System.Drawing.Size(120, 22);

            this.txtTenSach.Location = new System.Drawing.Point(160, 20);
            this.txtTenSach.Size = new System.Drawing.Size(180, 22);

            this.txtTacGia.Location = new System.Drawing.Point(360, 20);
            this.txtTacGia.Size = new System.Drawing.Size(120, 22);

            this.txtNamXB.Location = new System.Drawing.Point(500, 20);
            this.txtNamXB.Size = new System.Drawing.Size(80, 22);

            this.txtNhaXB.Location = new System.Drawing.Point(600, 20);
            this.txtNhaXB.Size = new System.Drawing.Size(120, 22);

            this.txtTriGia.Location = new System.Drawing.Point(20, 60);
            this.txtTriGia.Size = new System.Drawing.Size(120, 22);

            this.dtpNgayNhap.Location = new System.Drawing.Point(160, 60);
            this.dtpNgayNhap.Size = new System.Drawing.Size(180, 22);

            this.btnThemSach.Location = new System.Drawing.Point(360, 60);
            this.btnThemSach.Size = new System.Drawing.Size(80, 30);
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);

            this.btnSuaSach.Location = new System.Drawing.Point(460, 60);
            this.btnSuaSach.Size = new System.Drawing.Size(80, 30);
            this.btnSuaSach.Text = "Sửa";
            this.btnSuaSach.Click += new System.EventHandler(this.btnSuaSach_Click);

            this.btnXoaSach.Location = new System.Drawing.Point(560, 60);
            this.btnXoaSach.Size = new System.Drawing.Size(80, 30);
            this.btnXoaSach.Text = "Xóa";
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);

            this.btnLamMoiSach.Location = new System.Drawing.Point(660, 60);
            this.btnLamMoiSach.Size = new System.Drawing.Size(80, 30);
            this.btnLamMoiSach.Text = "Làm mới";
            this.btnLamMoiSach.Click += new System.EventHandler(this.btnLamMoiSach_Click);

            this.cmbLocMaSach.Location = new System.Drawing.Point(20, 110);
            this.cmbLocMaSach.Size = new System.Drawing.Size(120, 22);

            this.btnLocSach.Location = new System.Drawing.Point(160, 110);
            this.btnLocSach.Size = new System.Drawing.Size(80, 30);
            this.btnLocSach.Text = "Lọc";
            this.btnLocSach.Click += new System.EventHandler(this.btnLocSach_Click);

            // ========== Tab Mượn Sách ==========
            this.tabMuonSach.Text = "Quản lý Mượn Sách";
            this.tabMuonSach.Controls.Add(this.dgvPhieuMuon);
            this.tabMuonSach.Controls.Add(this.txtMaPhieuMuon);
            this.tabMuonSach.Controls.Add(this.cmbMaSachMuon);
            this.tabMuonSach.Controls.Add(this.dtpNgayMuon);
            this.tabMuonSach.Controls.Add(this.dtpNgayTra);
            this.tabMuonSach.Controls.Add(this.btnThemPM);
            this.tabMuonSach.Controls.Add(this.btnSuaPM);
            this.tabMuonSach.Controls.Add(this.btnXoaPM);
            this.tabMuonSach.Controls.Add(this.btnLamMoiPM);
            this.tabMuonSach.Controls.Add(this.btnThongKeQuaHan);

            this.dgvPhieuMuon.Location = new System.Drawing.Point(20, 180);
            this.dgvPhieuMuon.Size = new System.Drawing.Size(700, 250);

            this.txtMaPhieuMuon.Location = new System.Drawing.Point(20, 20);
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(120, 22);

            this.cmbMaSachMuon.Location = new System.Drawing.Point(160, 20);
            this.cmbMaSachMuon.Size = new System.Drawing.Size(120, 22);

            this.dtpNgayMuon.Location = new System.Drawing.Point(300, 20);
            this.dtpNgayMuon.Size = new System.Drawing.Size(180, 22);

            this.dtpNgayTra.Location = new System.Drawing.Point(500, 20);
            this.dtpNgayTra.Size = new System.Drawing.Size(180, 22);

            this.btnThemPM.Location = new System.Drawing.Point(20, 60);
            this.btnThemPM.Size = new System.Drawing.Size(80, 30);
            this.btnThemPM.Text = "Thêm";
            this.btnThemPM.Click += new System.EventHandler(this.btnThemPM_Click);

            this.btnSuaPM.Location = new System.Drawing.Point(120, 60);
            this.btnSuaPM.Size = new System.Drawing.Size(80, 30);
            this.btnSuaPM.Text = "Sửa";
            this.btnSuaPM.Click += new System.EventHandler(this.btnSuaPM_Click);

            this.btnXoaPM.Location = new System.Drawing.Point(220, 60);
            this.btnXoaPM.Size = new System.Drawing.Size(80, 30);
            this.btnXoaPM.Text = "Xóa";
            this.btnXoaPM.Click += new System.EventHandler(this.btnXoaPM_Click);

            this.btnLamMoiPM.Location = new System.Drawing.Point(320, 60);
            this.btnLamMoiPM.Size = new System.Drawing.Size(80, 30);
            this.btnLamMoiPM.Text = "Làm mới";
            this.btnLamMoiPM.Click += new System.EventHandler(this.btnLamMoiPM_Click);

            this.btnThongKeQuaHan.Location = new System.Drawing.Point(420, 60);
            this.btnThongKeQuaHan.Size = new System.Drawing.Size(180, 30);
            this.btnThongKeQuaHan.Text = "Thống kê quá hạn";
            this.btnThongKeQuaHan.Click += new System.EventHandler(this.btnThongKeQuaHan_Click);

            // frmMain
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Quản lý Thư viện";
        }

        #endregion
    }
}