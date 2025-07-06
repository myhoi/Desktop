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

namespace QLBay
{
    public partial class Form3: Form
    {
        string connStr = @"Data Source=MYHOI\MSSQLSERVER01;Initial Catalog=QuanLyBay;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
            this.Load += Form3_Load;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            LoadKhach();
        }

        private void LoadKhach()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT * FROM KHACH";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKhach.AutoGenerateColumns = true;
                dgvKhach.DataSource = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO KHACH(HoTen, NgaySinh, DiaChi, GioiTinh) VALUES (@ht, @ns, @dc, @gt)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ht", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@ns", dtNgaySinh.Value);
                cmd.Parameters.AddWithValue("@dc", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@gt", cboGioiTinh.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Đã thêm khách thành công!");
                LoadKhach();
            }
        }

        private void dgvKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtHoTen.Text = dgvKhach.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                dtNgaySinh.Value = Convert.ToDateTime(dgvKhach.Rows[e.RowIndex].Cells["NgaySinh"].Value);
                txtDiaChi.Text = dgvKhach.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                cboGioiTinh.Text = dgvKhach.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvKhach.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvKhach.CurrentRow.Cells["Id"].Value);

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "UPDATE KHACH SET HoTen=@ht, NgaySinh=@ns, DiaChi=@dc, GioiTinh=@gt WHERE Id=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ht", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@ns", dtNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@dc", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@gt", cboGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Cập nhật thành công!");
                    LoadKhach();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhach.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvKhach.CurrentRow.Cells["Id"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá khách này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        string query = "DELETE FROM KHACH WHERE Id=@id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Đã xoá thành công.");
                            LoadKhach();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Không thể xoá khách này vì có vé đã đặt.");
                        }
                    }
                }
            }
        }
    }
}
