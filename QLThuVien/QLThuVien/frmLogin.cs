using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class frmLogin : Form
    {
        string connectionString = "Server=.;Database=QLThuvien;Integrated Security=true;";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM TAIKHOAN WHERE TenDangNhap=@user AND MatKhau=@pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", txtTenDangNhap.Text);
                cmd.Parameters.AddWithValue("@pass", txtMatKhau.Text);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    frmMain main = new frmMain();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }
            }
        }
    }
}
