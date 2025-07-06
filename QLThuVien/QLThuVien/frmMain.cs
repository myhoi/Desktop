using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmMain : Form
    {
        string connectionString = "Server=.;Database=QLThuvien;Integrated Security=true;";

        public frmMain()
        {
            InitializeComponent();
            LoadSach();
            LoadPhieuMuon();
            LoadComboBoxMaSach();
        }

        private void LoadSach()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM SACH";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSach.DataSource = dt;
                // Load MaSach vào combobox lọc
                cmbLocMaSach.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    cmbLocMaSach.Items.Add(row["MaSach"].ToString());
                }
            }
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO SACH VALUES (@MaSach, @TenSach, @TacGia, @NamXB, @NhaXB, @TriGia, @NgayNhap)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text);
                cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text);
                cmd.Parameters.AddWithValue("@TacGia", txtTacGia.Text);
                cmd.Parameters.AddWithValue("@NamXB", int.Parse(txtNamXB.Text));
                cmd.Parameters.AddWithValue("@NhaXB", txtNhaXB.Text);
                cmd.Parameters.AddWithValue("@TriGia", decimal.Parse(txtTriGia.Text));
                cmd.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);
                cmd.ExecuteNonQuery();
                LoadSach();
            }
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE SACH SET TenSach=@TenSach, TacGia=@TacGia, NamXuatBan=@NamXB, NhaXuatBan=@NhaXB, TriGia=@TriGia, NgayNhap=@NgayNhap WHERE MaSach=@MaSach";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text);
                cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text);
                cmd.Parameters.AddWithValue("@TacGia", txtTacGia.Text);
                cmd.Parameters.AddWithValue("@NamXB", int.Parse(txtNamXB.Text));
                cmd.Parameters.AddWithValue("@NhaXB", txtNhaXB.Text);
                cmd.Parameters.AddWithValue("@TriGia", decimal.Parse(txtTriGia.Text));
                cmd.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);
                cmd.ExecuteNonQuery();
                LoadSach();
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM SACH WHERE MaSach=@MaSach";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text);
                cmd.ExecuteNonQuery();
                LoadSach();
            }
        }

        private void btnLamMoiSach_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtNamXB.Clear();
            txtNhaXB.Clear();
            txtTriGia.Clear();
            dtpNgayNhap.Value = DateTime.Now;
        }

        private void btnLocSach_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM SACH WHERE MaSach=@MaSach";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaSach", cmbLocMaSach.SelectedItem.ToString());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSach.DataSource = dt;
            }
        }

        // ================== QUẢN LÝ MƯỢN SÁCH ==================
        private void LoadPhieuMuon()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM PHIEUMUONSACH";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPhieuMuon.DataSource = dt;
            }
        }

        private void LoadComboBoxMaSach()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaSach FROM SACH";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                cmbMaSachMuon.Items.Clear();
                while (reader.Read())
                {
                    cmbMaSachMuon.Items.Add(reader["MaSach"].ToString());
                }
            }
        }

        private void btnThemPM_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO PHIEUMUONSACH VALUES (@MaPhieuMuon, @MaSach, @NgayMuon, @NgayTra)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuMuon", txtMaPhieuMuon.Text);
                cmd.Parameters.AddWithValue("@MaSach", cmbMaSachMuon.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@NgayMuon", dtpNgayMuon.Value);
                cmd.Parameters.AddWithValue("@NgayTra", dtpNgayTra.Value);
                cmd.ExecuteNonQuery();
                LoadPhieuMuon();
            }
        }

        private void btnSuaPM_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE PHIEUMUONSACH SET MaSach=@MaSach, NgayMuon=@NgayMuon, NgayTra=@NgayTra WHERE MaPhieuMuon=@MaPhieuMuon";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuMuon", txtMaPhieuMuon.Text);
                cmd.Parameters.AddWithValue("@MaSach", cmbMaSachMuon.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@NgayMuon", dtpNgayMuon.Value);
                cmd.Parameters.AddWithValue("@NgayTra", dtpNgayTra.Value);
                cmd.ExecuteNonQuery();
                LoadPhieuMuon();
            }
        }

        private void btnXoaPM_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM PHIEUMUONSACH WHERE MaPhieuMuon=@MaPhieuMuon";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuMuon", txtMaPhieuMuon.Text);
                cmd.ExecuteNonQuery();
                LoadPhieuMuon();
            }
        }

        private void btnLamMoiPM_Click(object sender, EventArgs e)
        {
            txtMaPhieuMuon.Clear();
            cmbMaSachMuon.SelectedIndex = -1;
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now.AddDays(14);
        }

        private void btnThongKeQuaHan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM PHIEUMUONSACH WHERE DATEDIFF(day, NgayMuon, NgayTra) > 15";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPhieuMuon.DataSource = dt;
            }
        }
    }
}
