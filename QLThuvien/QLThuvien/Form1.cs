using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuvien
{
    public partial class Form1: Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MYHOI\MSSQLSERVER01;Initial Catalog=QLThuVien;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtTenDangNhap.Text;
            string pass = txtMatKhau.Text;

            conn.Open();
            string sql = "SELECT * FROM TAIKHOAN WHERE TenDangNhap=@u AND MatKhau=@p";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@u", user);
            cmd.Parameters.AddWithValue("@p", pass);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                new Form2().Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }

            conn.Close();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }
    }
}
