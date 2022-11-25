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
    public partial class frm_DanhMuc : Form
    {
        LopChung lc;
        BLL.bllQLKho bll;
        SqlDataReader dr;
        frm_DanhMucModule danhMM = new frm_DanhMucModule();
        public frm_DanhMuc()
        {
            InitializeComponent();
            bll = new BLL.bllQLKho(this);
            lc = new LopChung();
            LoadDM();
        }

        private void btnAddDanhMuc_Click(object sender, EventArgs e)
        {
            frm_DanhMucModule DMM = new frm_DanhMucModule();
            DMM.btnSaveDM.Enabled = true;
            DMM.btnUpdateDM.Enabled = false;
            DMM.ShowDialog();
            LoadDM();
        }

        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvDanhMuc.Columns[e.ColumnIndex].Name;

            //Thực hiện Edit
            if (ColName == "edit")
            {
                danhMM.txtMaDM.Text = dgvDanhMuc.Rows[e.RowIndex].Cells[1].Value.ToString();
                danhMM.txtTenDM.Text = dgvDanhMuc.Rows[e.RowIndex].Cells[2].Value.ToString();
                danhMM.txtMaNCCDM.Text = dgvDanhMuc.Rows[e.RowIndex].Cells[3].Value.ToString();

                //Thực hiện Edit nên tắt nút save và mở update
                danhMM.btnSaveDM.Enabled = false;
                danhMM.btnUpdateDM.Enabled = true;
                danhMM.txtMaDM.Enabled = false;
                danhMM.ShowDialog();
            }
            else if (ColName == "delete")
            {
                DialogResult dialog;
                dialog = MessageBox.Show("Bạn có muốn xóa danh mục này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    frm_SanPham SP = new frm_SanPham();
                    SqlCommand comm = new SqlCommand("delete from [DanhMuc] where MaDM LIKE'" + dgvDanhMuc.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", lc.ChuoiKetNoi());
                    lc.OpenKN();
                    try
                    {
                        int ketQua = comm.ExecuteNonQuery();
                        if (ketQua >= 1)
                        {
                            SqlCommand comm2 = new SqlCommand("delete from [SanPham] where MaDM LIKE'" + SP.dgvSanPham.Rows[e.RowIndex].Cells[6].Value.ToString() + "'", lc.ChuoiKetNoi());
                            lc.OpenKN();
                            int ketQua2 = comm2.ExecuteNonQuery();
                            if (ketQua2 >=1)
                            {
                                MessageBox.Show("Xóa danh mục thành công", "Thông báo");
                            }
                            lc.CloseKN();
                        }
                        else
                            MessageBox.Show("Xóa danh mục thất bại", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    lc.CloseKN();
                }
            }
            LoadDM();
        }

        public void LoadDM()
        {
            int i = 0;
            dgvDanhMuc.Rows.Clear();
            SqlCommand comm = new SqlCommand("select * from [DanhMuc]", lc.ChuoiKetNoi());
            lc.OpenKN();
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvDanhMuc.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
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
            dgvDanhMuc.Rows.Clear();
            SqlCommand comm = new SqlCommand("select * from [DanhMuc] where CONCAT(MaDM,TenDM,MaNCC) LIKE '%"+txtSearch.Text+"%' ", lc.ChuoiKetNoi());
            lc.OpenKN();
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvDanhMuc.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            lc.CloseKN();
        }
    }
}
