using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBay
{
    public partial class Form1 : Form
    {
        //Data Source=MYHOI\MSSQLSERVER01;Initial Catalog=QuanLyBay;Integrated Security=True
        string connStr = @"Data Source=MYHOI\MSSQLSERVER01;Initial Catalog=QuanLyBay;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT * FROM NHANVIEN WHERE Email = @email AND MatKhau = @password";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email); // admin@sedeu.vn 123456
                cmd.Parameters.AddWithValue("@password", password);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string tenNV = reader["TenNV"].ToString();
                    string quyen = reader["QuyenTruyCap"].ToString();

                    MessageBox.Show("Đăng nhập thành công! Xin chào " + tenNV, "Thông báo");

                    // Mở form chính, truyền quyền truy cập nếu cần
                    Form2 main = new Form2(quyen);
                    this.Hide();
                    main.Show();
                }
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
        }
    }
}
