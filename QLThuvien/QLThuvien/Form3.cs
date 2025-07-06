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
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MYHOI\MSSQLSERVER01;Initial Catalog=QLThuVien;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            LoadPhieuMuon();
        }

        private void LoadPhieuMuon()
        {
            string sql = @"
                SELECT p.MaPhieuMuon, t.MaSach, p.NgayMuon, p.NgayTra
                FROM PHIEUMUONSACH p
                JOIN THONGTINMUONSACH t ON p.MaPhieuMuon = t.MaPhieuMuon";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMuon.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieu.Text.Trim();
            string maSach = txtMaSach.Text.Trim();

            if (maPhieu == "" || maSach == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string sql1 = "INSERT INTO PHIEUMUONSACH VALUES (@ma, @ngayMuon, @ngayTra)";
            string sql2 = "INSERT INTO THONGTINMUONSACH VALUES (@maSach, @ma)";

            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            cmd1.Parameters.AddWithValue("@ma", maPhieu);
            cmd1.Parameters.AddWithValue("@ngayMuon", dtNgayMuon.Value);
            cmd1.Parameters.AddWithValue("@ngayTra", dtNgayTra.Value);

            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            cmd2.Parameters.AddWithValue("@maSach", maSach);
            cmd2.Parameters.AddWithValue("@ma", maPhieu);

            conn.Close();
            LoadPhieuMuon();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string sql = @"
                SELECT t.MaSach, p.NgayMuon, p.NgayTra
                FROM PHIEUMUONSACH p
                JOIN THONGTINMUONSACH t ON p.MaPhieuMuon = t.MaPhieuMuon
                WHERE DATEDIFF(DAY, p.NgayMuon, p.NgayTra) > 15";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMuon.DataSource = dt;
        }

        private void dgvMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMaPhieu.Text = dgvMuon.Rows[i].Cells["MaPhieuMuon"].Value.ToString();
                txtMaSach.Text = dgvMuon.Rows[i].Cells["MaSach"].Value.ToString();
                dtNgayMuon.Value = Convert.ToDateTime(dgvMuon.Rows[i].Cells["NgayMuon"].Value);
                dtNgayTra.Value = Convert.ToDateTime(dgvMuon.Rows[i].Cells["NgayTra"].Value);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieu.Text.Trim();
            string maSach = txtMaSach.Text.Trim();

            string sql1 = "UPDATE PHIEUMUONSACH SET NgayMuon=@ngayMuon, NgayTra=@ngayTra WHERE MaPhieuMuon=@ma";
            string sql2 = "UPDATE THONGTINMUONSACH SET MaSach=@maSach WHERE MaPhieuMuon=@ma";

            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            cmd1.Parameters.AddWithValue("@ngayMuon", dtNgayMuon.Value);
            cmd1.Parameters.AddWithValue("@ngayTra", dtNgayTra.Value);
            cmd1.Parameters.AddWithValue("@ma", maPhieu);

            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            cmd2.Parameters.AddWithValue("@maSach", maSach);
            cmd2.Parameters.AddWithValue("@ma", maPhieu);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieu.Text.Trim();

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phiếu mượn này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sql2 = "DELETE FROM THONGTINMUONSACH WHERE MaPhieuMuon=@ma";
                string sql1 = "DELETE FROM PHIEUMUONSACH WHERE MaPhieuMuon=@ma";

                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.Parameters.AddWithValue("@ma", maPhieu);
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@ma", maPhieu);

            }
            conn.Close();
            LoadPhieuMuon();
        }
    }
}
