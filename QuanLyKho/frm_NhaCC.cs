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
    public partial class frm_NhaCC : Form
    {
        LopChung lc;
        BLL.bllQLKho bll;
        SqlDataReader dr;
        frm_NhaCCModule nccModule = new frm_NhaCCModule();
        public frm_NhaCC()
        {
            InitializeComponent();
            bll = new BLL.bllQLKho(this);
            lc = new LopChung();
            LoadNCC();
        }

        private void btnAddNCC_Click(object sender, EventArgs e)
        {
            frm_NhaCCModule NCC = new frm_NhaCCModule();
            NCC.btnSaveNCC.Enabled = true;
            NCC.btnUpdateNCC.Enabled = false;
            NCC.ShowDialog();
            LoadNCC();
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvNCC.Columns[e.ColumnIndex].Name;

            //Thực hiện Edit
            if (ColName == "Edit")
            {
                nccModule.txtMaNCC.Text = dgvNCC.Rows[e.RowIndex].Cells[1].Value.ToString();
                nccModule.txtTenNCC.Text = dgvNCC.Rows[e.RowIndex].Cells[2].Value.ToString();
                nccModule.txtSDT.Text = dgvNCC.Rows[e.RowIndex].Cells[3].Value.ToString();
                nccModule.txtDiaChi.Text = dgvNCC.Rows[e.RowIndex].Cells[4].Value.ToString();

                //Thực hiện Edit nên tắt nút save và mở update
                nccModule.btnSaveNCC.Enabled = false;
                nccModule.btnUpdateNCC.Enabled = true;
                nccModule.txtMaNCC.Enabled = false;
                nccModule.ShowDialog();
            }
            else if (ColName == "delete")
            {
                frm_SanPham SP = new frm_SanPham();
                frm_DanhMuc DM = new frm_DanhMuc();
                DialogResult dialog;
                dialog = MessageBox.Show("Bạn có muốn xóa Nhà CC này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    SqlCommand comm = new SqlCommand("delete from [NhaCC] where MaNCC LIKE'" + dgvNCC.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", lc.ChuoiKetNoi());
                    lc.OpenKN();
                    try
                    {
                        int ketQua = comm.ExecuteNonQuery();
                        if (ketQua >= 1)
                        {
                            //SqlCommand comm2 = new SqlCommand("delete from [SanPham] where" , lc.ChuoiKetNoi());
                            //lc.OpenKN();
                            //int ketQua2 = comm2.ExecuteNonQuery();
                            //if (ketQua2 >= 1)
                            //{
                                MessageBox.Show("Xóa Nhà CC thành công", "Thông báo");
                            //}
                            //lc.CloseKN();
                        }     
                        else
                            MessageBox.Show("Xóa Nhà CC thất bại", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    lc.CloseKN();
                }
            }
            LoadNCC();
        }


        public void LoadNCC()
        {
            int i = 0;
            dgvNCC.Rows.Clear();
            SqlCommand comm = new SqlCommand("select * from [NhaCC]", lc.ChuoiKetNoi());
            lc.OpenKN();
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvNCC.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
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
            dgvNCC.Rows.Clear();
            SqlCommand comm = new SqlCommand("select * from [NhaCC] where CONCAT(MaNCC,TenNCC,SDT) LIKE '%" + txtSearch.Text + "%'", lc.ChuoiKetNoi());
            lc.OpenKN();
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvNCC.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            lc.CloseKN();
        }
    }
}
