namespace QLBay
{
    partial class Form2
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.thôngTinKháchĐặtVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinĐặtVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýChuyếnBayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinKháchĐặtVéToolStripMenuItem,
            this.thôngTinĐặtVéToolStripMenuItem,
            this.quảnLýChuyếnBayToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 33);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // thôngTinKháchĐặtVéToolStripMenuItem
            // 
            this.thôngTinKháchĐặtVéToolStripMenuItem.Name = "thôngTinKháchĐặtVéToolStripMenuItem";
            this.thôngTinKháchĐặtVéToolStripMenuItem.Size = new System.Drawing.Size(209, 29);
            this.thôngTinKháchĐặtVéToolStripMenuItem.Text = "Thông tin khách đặt vé";
            this.thôngTinKháchĐặtVéToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKháchĐặtVéToolStripMenuItem_Click);
            // 
            // thôngTinĐặtVéToolStripMenuItem
            // 
            this.thôngTinĐặtVéToolStripMenuItem.Name = "thôngTinĐặtVéToolStripMenuItem";
            this.thôngTinĐặtVéToolStripMenuItem.Size = new System.Drawing.Size(158, 29);
            this.thôngTinĐặtVéToolStripMenuItem.Text = "Thông tin đặt vé";
            this.thôngTinĐặtVéToolStripMenuItem.Click += new System.EventHandler(this.thôngTinĐặtVéToolStripMenuItem_Click);
            // 
            // quảnLýChuyếnBayToolStripMenuItem
            // 
            this.quảnLýChuyếnBayToolStripMenuItem.Name = "quảnLýChuyếnBayToolStripMenuItem";
            this.quảnLýChuyếnBayToolStripMenuItem.Size = new System.Drawing.Size(184, 29);
            this.quảnLýChuyếnBayToolStripMenuItem.Text = "Quản lý chuyến bay";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(335, 160);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(128, 33);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(504, 160);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 33);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchĐặtVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinĐặtVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýChuyếnBayToolStripMenuItem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnThoat;
    }
}