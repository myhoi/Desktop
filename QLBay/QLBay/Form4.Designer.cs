namespace QLBay
{
    partial class Form4
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
            this.cboKhach = new System.Windows.Forms.ComboBox();
            this.cboChuyenBay = new System.Windows.Forms.ComboBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.btnThemDatVe = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dgvDatVe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatVe)).BeginInit();
            this.SuspendLayout();
            // 
            // cboKhach
            // 
            this.cboKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhach.FormattingEnabled = true;
            this.cboKhach.Location = new System.Drawing.Point(79, 53);
            this.cboKhach.Name = "cboKhach";
            this.cboKhach.Size = new System.Drawing.Size(121, 33);
            this.cboKhach.TabIndex = 0;
            this.cboKhach.SelectedIndexChanged += new System.EventHandler(this.cboKhach_SelectedIndexChanged);
            // 
            // cboChuyenBay
            // 
            this.cboChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChuyenBay.FormattingEnabled = true;
            this.cboChuyenBay.Location = new System.Drawing.Point(233, 53);
            this.cboChuyenBay.Name = "cboChuyenBay";
            this.cboChuyenBay.Size = new System.Drawing.Size(121, 33);
            this.cboChuyenBay.TabIndex = 1;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(201, 220);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(153, 30);
            this.txtGiaTien.TabIndex = 2;
            // 
            // btnThemDatVe
            // 
            this.btnThemDatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDatVe.Location = new System.Drawing.Point(84, 274);
            this.btnThemDatVe.Name = "btnThemDatVe";
            this.btnThemDatVe.Size = new System.Drawing.Size(212, 40);
            this.btnThemDatVe.TabIndex = 3;
            this.btnThemDatVe.Text = "Thêm thông tin đặt vé";
            this.btnThemDatVe.UseVisualStyleBackColor = true;
            this.btnThemDatVe.Click += new System.EventHandler(this.btnThemDatVe_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(79, 327);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(273, 25);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Hiển thị tổng tiền khách đã đặt";
            // 
            // dgvDatVe
            // 
            this.dgvDatVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatVe.Location = new System.Drawing.Point(415, 25);
            this.dgvDatVe.Name = "dgvDatVe";
            this.dgvDatVe.RowHeadersWidth = 62;
            this.dgvDatVe.RowTemplate.Height = 28;
            this.dgvDatVe.Size = new System.Drawing.Size(373, 187);
            this.dgvDatVe.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập giá vé";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatVe);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnThemDatVe);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.cboChuyenBay);
            this.Controls.Add(this.cboKhach);
            this.Name = "Form4";
            this.Text = "Form đặt vé";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboKhach;
        private System.Windows.Forms.ComboBox cboChuyenBay;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Button btnThemDatVe;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridView dgvDatVe;
        private System.Windows.Forms.Label label1;
    }
}