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
    public partial class frm_PhieuNhapModule : Form
    {
        LopChung lc;
        BLL.bllQLKho bll;
        public frm_PhieuNhapModule()
        {
            InitializeComponent();
            bll = new BLL.bllQLKho(this);
            lc = new LopChung();
        }

        private void frm_PhieuNhapModule_Load(object sender, EventArgs e)
        {
            LoadComBoNCC();
            LoadComBoTenSP();
            LoadComBoUser();
        }

        private void btnSavePN_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn lưu không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bll.bllThemPN();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdatePN_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn cập nhập không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bll.bllSuaPN();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSavePN.Enabled = true;
            btnUpdatePN.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {
            txtMaPN.Clear();
            txtTenNCC.Clear();
            txtTenSP.Clear();
            txtSoLuong.Clear();
            txtNguoiNhap.Clear();
        }
        public void LoadComBoNCC()
        {
            string sqlLoadCombo = "select * from NhaCC";
            ckbNCC.DataSource = lc.load(sqlLoadCombo);
            ckbNCC.DisplayMember = "TenNCC";
        }
        public void LoadComBoTenSP()
        {
            string sqlLoadCombo = "select * from SanPham";
            ckbTenSP.DataSource = lc.load(sqlLoadCombo);
            ckbTenSP.DisplayMember = "TenSP";
        }
        public void LoadComBoUser()
        {
            string sqlLoadCombo = "select * from [User]";
            ckbNguoiNhap.DataSource = lc.load(sqlLoadCombo);
            ckbNguoiNhap.DisplayMember = "FullName";
        }

        private void ckbNCC_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView row = ckbNCC.SelectedItem as DataRowView;
            if (row != null)
            {
                txtTenNCC.Text = row["TenNCC"].ToString();
            }
        }

        private void ckbTenSP_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView row = ckbTenSP.SelectedItem as DataRowView;
            if (row != null)
            {
                txtTenSP.Text = row["TenSP"].ToString();
            }
        }

        private void ckbNguoiNhap_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView row = ckbNguoiNhap.SelectedItem as DataRowView;
            if (row != null)
            {
                txtNguoiNhap.Text = row["FullName"].ToString();
            }
        }
    }
}
