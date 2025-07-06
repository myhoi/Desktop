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
    public partial class Form4: Form
    {
        string connStr = @"Data Source=MYHOI\MSSQLSERVER01;Initial Catalog=QuanLyBay;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
            this.Load += Form4_Load;
            cboKhach.SelectedIndexChanged += cboKhach_SelectedIndexChanged;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            LoadKhach();
        }

        private void LoadKhach()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT Id, HoTen FROM KHACH";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboKhach.DataSource = dt;
                cboKhach.DisplayMember = "HoTen";
                cboKhach.ValueMember = "Id";
            }
        }
        

        private void cboKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhach.SelectedValue != null)
            {
                if (cboKhach.SelectedValue == null || cboKhach.SelectedValue is DataRowView)
                    return;
                int idKhach = Convert.ToInt32(cboKhach.SelectedValue);
                LoadDanhSachVe(idKhach);
                LoadChuyenBay();
            }
        }
        private void LoadDanhSachVe(int idKhach)
        {
            if (cboKhach.SelectedValue == null) return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = @"SELECT dv.IdVe, cb.TenChuyenBay, dv.GiaTien, dv.ThoiGianDatVe
                                 FROM DATVE dv
                                 JOIN CHUYENBAY cb ON dv.MaChuyen = cb.MaChuyen
                                 WHERE dv.IdKhach = @idKhach";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idKhach", idKhach);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDatVe.AutoGenerateColumns = true;
                dgvDatVe.DataSource = dt;

                // Tính tổng tiền
                decimal tong = 0;
                foreach (DataRow row in dt.Rows)
                {
                    tong += Convert.ToDecimal(row["GiaTien"]);
                }

                lblTongTien.Text = "Tổng tiền: " + tong.ToString("N0") + " VNĐ";
            }
        }
        private void LoadChuyenBay()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT MaChuyen, TenChuyenBay FROM CHUYENBAY";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboChuyenBay.DataSource = dt;
                cboChuyenBay.DisplayMember = "TenChuyenBay";
                cboChuyenBay.ValueMember = "MaChuyen";
            }
        }
        private void btnThemDatVe_Click(object sender, EventArgs e)
        {
            if (cboKhach.SelectedValue == null || cboChuyenBay.SelectedValue == null || txtGiaTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            int idKhach = Convert.ToInt32(cboKhach.SelectedValue);
            int maChuyen = Convert.ToInt32(cboChuyenBay.SelectedValue);
            decimal giaTien = 0;

            if (!decimal.TryParse(txtGiaTien.Text, out giaTien))
            {
                MessageBox.Show("Giá tiền không hợp lệ.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO DATVE (IdKhach, MaChuyen, GiaTien, ThoiGianDatVe) VALUES (@id, @mc, @gia, GETDATE())";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idKhach);
                cmd.Parameters.AddWithValue("@mc", maChuyen);
                cmd.Parameters.AddWithValue("@gia", giaTien);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Đặt vé thành công!");
                LoadDanhSachVe(idKhach);
                txtGiaTien.Clear();
            }
        }
    }
}
