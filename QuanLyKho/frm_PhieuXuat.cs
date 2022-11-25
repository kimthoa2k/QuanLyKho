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
    public partial class frm_PhieuXuat : Form
    {
        LopChung lc;
        BLL.bllQLKho bll;
        SqlDataReader dr;
        frm_PhieuXuatModule PXM = new frm_PhieuXuatModule();
        public frm_PhieuXuat()
        {
            InitializeComponent();
            bll = new BLL.bllQLKho(this);
            lc = new LopChung();
            LoadPX();
        }

        private void btnAddPX_Click(object sender, EventArgs e)
        {
            frm_PhieuXuatModule px = new frm_PhieuXuatModule();
            px.btnSavePX.Enabled = true;
            px.btnUpdatePX.Enabled = false;
            px.ShowDialog();
            LoadPX();
        }

        private void dgvPhieuXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvPhieuXuat.Columns[e.ColumnIndex].Name;

            //Thực hiện Edit
            if (ColName == "Edit")
            {
                PXM.txtMaPX.Text = dgvPhieuXuat.Rows[e.RowIndex].Cells[1].Value.ToString();
                PXM.txtTenKH.Text = dgvPhieuXuat.Rows[e.RowIndex].Cells[2].Value.ToString();
                PXM.txtTenSP.Text = dgvPhieuXuat.Rows[e.RowIndex].Cells[3].Value.ToString();
                PXM.txtSoLuong.Text = dgvPhieuXuat.Rows[e.RowIndex].Cells[4].Value.ToString();
                PXM.datePKPX.Text = dgvPhieuXuat.Rows[e.RowIndex].Cells[5].Value.ToString();
                PXM.txtNguoiXuat.Text = dgvPhieuXuat.Rows[e.RowIndex].Cells[6].Value.ToString();

                //Thực hiện Edit nên tắt nút save và mở update
                PXM.btnSavePX.Enabled = false;
                PXM.btnUpdatePX.Enabled = true;
                PXM.txtMaPX.Enabled = false;
                PXM.ShowDialog();
            }
            else if (ColName == "delete")
            {
                DialogResult dialog;
                dialog = MessageBox.Show("Bạn có muốn xóa phiếu xuất này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    frm_SanPham SP = new frm_SanPham();
                    SqlCommand comm = new SqlCommand("delete from [PhieuXuat] where MaPX LIKE'" + dgvPhieuXuat.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", lc.ChuoiKetNoi());
                    lc.OpenKN();
                    try
                    {
                        int ketQua = comm.ExecuteNonQuery();
                        if (ketQua >= 1)
                        {
                            MessageBox.Show("Xóa phiếu xuất thành công", "Thông báo");
                        }
                        else
                            MessageBox.Show("Xóa phiếu xuất thất bại", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    lc.CloseKN();
                }
            }
            LoadPX();
        }

        public void LoadPX()
        {
            int i = 0;
            dgvPhieuXuat.Rows.Clear();
            SqlCommand comm = new SqlCommand("select * from [PhieuXuat]", lc.ChuoiKetNoi());
            lc.OpenKN();
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvPhieuXuat.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            lc.CloseKN();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadTKPX();
        }
        public void LoadTKPX()
        {
            int i = 0;
            dgvPhieuXuat.Rows.Clear();
            SqlCommand comm = new SqlCommand("select * from [PhieuXuat] where CONCAT(MaPX,TenKH,TenSP,NgayXuat,NguoiXuat) LIKE '%" + txtSearch.Text + "%'", lc.ChuoiKetNoi());
            lc.OpenKN();
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvPhieuXuat.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            lc.CloseKN();
        }
    }
}
