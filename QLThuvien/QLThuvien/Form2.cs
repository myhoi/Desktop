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
    public partial class Form2: Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MYHOI\MSSQLSERVER01;Initial Catalog=QLThuVien;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }
        void LoadSach()
        {
            string sql = "SELECT * FROM SACH";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSach.DataSource = dt;

            cboMaSach.DataSource = dt.Copy();
            cboMaSach.DisplayMember = "MaSach";
            cboMaSach.ValueMember = "MaSach";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO SACH VALUES (@ma, @ten, @tg, @nam, @nxb, @gia, @ngay)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", cboMaSach.Text);
            cmd.Parameters.AddWithValue("@ten", txtTenSach.Text);
            cmd.Parameters.AddWithValue("@tg", txtTacGia.Text);
            cmd.Parameters.AddWithValue("@nam", int.Parse(txtNamXB.Text));
            cmd.Parameters.AddWithValue("@nxb", txtNXB.Text);
            cmd.Parameters.AddWithValue("@gia", decimal.Parse(txtGia.Text));
            cmd.Parameters.AddWithValue("@ngay", dtNgayNhap.Value);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE SACH SET Tensach=@ten, Tacgia=@tg, Namxuatban=@nam, Nhaxuatban=@nxb, Trigia=@gia, NgayNhap=@ngay WHERE MaSach=@ma";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", cboMaSach.Text);
            cmd.Parameters.AddWithValue("@ten", txtTenSach.Text);
            cmd.Parameters.AddWithValue("@tg", txtTacGia.Text);
            cmd.Parameters.AddWithValue("@nam", int.Parse(txtNamXB.Text));
            cmd.Parameters.AddWithValue("@nxb", txtNXB.Text);
            cmd.Parameters.AddWithValue("@gia", decimal.Parse(txtGia.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Xác nhận xóa?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                string sql = "DELETE FROM SACH WHERE MaSach=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", cboMaSach.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadSach();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadSach();
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                cboMaSach.Text = dgvSach.Rows[i].Cells["MaSach"].Value.ToString();
                txtTenSach.Text = dgvSach.Rows[i].Cells["Tensach"].Value.ToString();
                txtTacGia.Text = dgvSach.Rows[i].Cells["Tacgia"].Value.ToString();
                txtNamXB.Text = dgvSach.Rows[i].Cells["Namxuatban"].Value.ToString();
                txtNXB.Text = dgvSach.Rows[i].Cells["Nhaxuatban"].Value.ToString();
                txtGia.Text = dgvSach.Rows[i].Cells["Trigia"].Value.ToString();
            }
        }

        private void cboMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaSach.SelectedValue != null)
            {
                string sql = "SELECT * FROM SACH WHERE MaSach=@ma";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@ma", cboMaSach.SelectedValue.ToString());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSach.DataSource = dt;
            }
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void quảnLýMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
