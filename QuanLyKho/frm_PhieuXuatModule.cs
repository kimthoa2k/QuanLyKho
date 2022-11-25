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
    public partial class frm_PhieuXuatModule : Form
    {
        LopChung lc;
        BLL.bllQLKho bll;
        public frm_PhieuXuatModule()
        {
            InitializeComponent();
            bll = new BLL.bllQLKho(this);
            lc = new LopChung();
        }

        private void frm_PhieuXuatModule_Load(object sender, EventArgs e)
        {
            LoadComBoTenSP();
            LoadComBoUser();
        }

        private void btnSavePX_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn lưu không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bll.bllThemPX();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdatePX_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn cập nhập không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bll.bllSuaPX();
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
            btnSavePX.Enabled = true;
            btnUpdatePX.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {
            txtMaPX.Clear();
            txtTenKH.Clear();
            txtTenSP.Clear();
            txtSoLuong.Clear();
            txtNguoiXuat.Clear();
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
            ckbNguoiXuat.DataSource = lc.load(sqlLoadCombo);
            ckbNguoiXuat.DisplayMember = "FullName";
        }

        private void ckbTenSP_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView row = ckbTenSP.SelectedItem as DataRowView;
            if (row != null)
            {
                txtTenSP.Text = row["TenSP"].ToString();
            }
        }

        private void ckbNguoiXuat_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView row = ckbNguoiXuat.SelectedItem as DataRowView;
            if (row != null)
            {
                txtNguoiXuat.Text = row["FullName"].ToString();
            }
        }
    }
}
