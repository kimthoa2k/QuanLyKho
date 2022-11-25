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


namespace QuanLyKho
{
    public partial class frm_PhieuNhap : Form
    {
        LopChung lc;
        BLL.bllQLKho bll;
        SqlDataReader dr;
        frm_PhieuNhapModule PNM = new frm_PhieuNhapModule();
        public frm_PhieuNhap()
        {
            InitializeComponent();
            bll = new BLL.bllQLKho(this);
            lc = new LopChung();
            LoadPN();
        }

        private void btnAddPN_Click(object sender, EventArgs e)
        {
            frm_PhieuNhapModule pn = new frm_PhieuNhapModule();
            pn.btnSavePN.Enabled = true;
            pn.btnUpdatePN.Enabled = false;
            pn.ShowDialog();
            LoadPN();
        }
        private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvPhieuNhap.Columns[e.ColumnIndex].Name;

            //Thực hiện Edit
            if (ColName == "Edit")
            {
                PNM.txtMaPN.Text = dgvPhieuNhap.Rows[e.RowIndex].Cells[1].Value.ToString();
                PNM.txtTenNCC.Text = dgvPhieuNhap.Rows[e.RowIndex].Cells[2].Value.ToString();
                PNM.txtTenSP.Text = dgvPhieuNhap.Rows[e.RowIndex].Cells[3].Value.ToString();
                PNM.txtSoLuong.Text = dgvPhieuNhap.Rows[e.RowIndex].Cells[4].Value.ToString();
                PNM.datePKPN.Text = dgvPhieuNhap.Rows[e.RowIndex].Cells[5].Value.ToString();
                PNM.txtNguoiNhap.Text = dgvPhieuNhap.Rows[e.RowIndex].Cells[6].Value.ToString();

                //Thực hiện Edit nên tắt nút save và mở update
                PNM.btnSavePN.Enabled = false;
                PNM.btnUpdatePN.Enabled = true;
                PNM.txtMaPN.Enabled = false;
                PNM.ShowDialog();
            }
            else if (ColName == "delete")
            {
                DialogResult dialog;
                dialog = MessageBox.Show("Bạn có muốn xóa phiếu nhập này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    frm_SanPham SP = new frm_SanPham();
                    SqlCommand comm = new SqlCommand("delete from [PhieuNhap] where MaPN LIKE'" + dgvPhieuNhap.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", lc.ChuoiKetNoi());
                    lc.OpenKN();
                    try
                    {
                        int ketQua = comm.ExecuteNonQuery();
                        if (ketQua >= 1)
                        {
                            MessageBox.Show("Xóa phiếu nhập thành công", "Thông báo");
                        }
                        else
                            MessageBox.Show("Xóa phiếu nhập thất bại", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    lc.CloseKN();
                }
            }
            LoadPN();
        }

        public void LoadPN()
        {
            int i = 0;
            dgvPhieuNhap.Rows.Clear();
            SqlCommand comm = new SqlCommand("select * from [PhieuNhap]", lc.ChuoiKetNoi());
            lc.OpenKN();
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvPhieuNhap.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            lc.CloseKN();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadTKPN();
        }

        public void LoadTKPN()
        {
            int i = 0;
            dgvPhieuNhap.Rows.Clear();
            SqlCommand comm = new SqlCommand("select * from [PhieuNhap] where CONCAT(MaPN,TenNCC,TenSP,NgayNhap,NguoiNhap) LIKE '%" + txtSearch.Text + "%'", lc.ChuoiKetNoi());
            lc.OpenKN();
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvPhieuNhap.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            lc.CloseKN();
        }
    }
}
