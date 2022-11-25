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
    public partial class frm_SanPham : Form
    {
        LopChung lc;
        BLL.bllQLKho bll;
        SqlDataReader dr;
        frm_SanPhamModule SpM = new frm_SanPhamModule();
        public frm_SanPham()
        {
            InitializeComponent();
            bll = new BLL.bllQLKho(this);
            lc = new LopChung();
            LoadSP();
        }

        private void btnAddSanPham_Click(object sender, EventArgs e)
        {
            frm_SanPhamModule SPM = new frm_SanPhamModule();
            SPM.btnSaveSP.Enabled = true;
            SPM.btnUpdateSP.Enabled = false;
            SPM.ShowDialog();
            LoadSP();
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvSanPham.Columns[e.ColumnIndex].Name;

            //Thực hiện Edit
            if (ColName == "Edit")
            {
                SpM.txtMaSP.Text = dgvSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
                SpM.txtTenSP.Text = dgvSanPham.Rows[e.RowIndex].Cells[2].Value.ToString();
                SpM.txtGhiChu.Text = dgvSanPham.Rows[e.RowIndex].Cells[3].Value.ToString();
                SpM.txtDonGia.Text = dgvSanPham.Rows[e.RowIndex].Cells[4].Value.ToString();
                SpM.txtSoLuong.Text = dgvSanPham.Rows[e.RowIndex].Cells[5].Value.ToString();
                SpM.txtMaDM.Text = dgvSanPham.Rows[e.RowIndex].Cells[6].Value.ToString();

                //Thực hiện Edit nên tắt nút save và mở update
                SpM.btnSaveSP.Enabled = false;
                SpM.btnUpdateSP.Enabled = true;
                SpM.txtMaSP.Enabled = false;
                SpM.ShowDialog();
            }
            else if (ColName == "delete")
            {
                DialogResult dialog;
                dialog = MessageBox.Show("Bạn có muốn xóa sản phẩm này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    SqlCommand comm = new SqlCommand("delete from [SanPham] where MaSP LIKE'" + dgvSanPham.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", lc.ChuoiKetNoi());
                    lc.OpenKN();
                    try
                    {
                        int ketQua = comm.ExecuteNonQuery();
                        if (ketQua >= 1)
                            MessageBox.Show("Xóa sản phẩm thành công", "Thông báo");
                        else
                            MessageBox.Show("Xóa sản phẩm thất bại", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    lc.CloseKN();
                }
            }
            LoadSP();
        }

        public void LoadSP()
        {
            int i = 0;
            dgvSanPham.Rows.Clear();
            SqlCommand comm = new SqlCommand("select * from [SanPham]", lc.ChuoiKetNoi());
            lc.OpenKN();
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvSanPham.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            lc.CloseKN();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadTK();
        }

        public void LoadTK()
        {
            int i = 0;
            dgvSanPham.Rows.Clear();
            SqlCommand comm = new SqlCommand("select * from [SanPham] where CONCAT(MaSP,TenSP,MaDM) LIKE '%" + txtSearch.Text + "%'", lc.ChuoiKetNoi());
            lc.OpenKN();
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvSanPham.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            lc.CloseKN();
        }
    }
}
