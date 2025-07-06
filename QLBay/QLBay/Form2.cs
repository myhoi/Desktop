using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBay
{
    public partial class Form2: Form
    {
        private string quyenTruyCap;
        public Form2(string quyen)
        {
            InitializeComponent();
            quyenTruyCap = quyen;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //this.Text = "Hệ thống quản lý bay - " + quyenTruyCap.ToUpper();
        }

        private void thôngTinKháchĐặtVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void thôngTinĐặtVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
