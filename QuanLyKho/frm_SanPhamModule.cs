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
    public partial class frm_SanPhamModule : Form
    {
        LopChung lc;
        BLL.bllQLKho bll;
        public frm_SanPhamModule()
        {
            InitializeComponent();
            bll = new BLL.bllQLKho(this);
            lc = new LopChung();
        }

        private void frm_SanPhamModule_Load(object sender, EventArgs e)
        {
            LoadComBo();
        }

        private void btnSaveSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn lưu không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bll.bllThemSP();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn cập nhập không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bll.bllSuaSP();
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
            btnSaveSP.Enabled = true;
            btnUpdateSP.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGhiChu.Clear();
            txtMaDM.Clear();
        }
        public void LoadComBo()
        {
            string sqlLoadCombo = "select * from DanhMuc";
            comboBox1.DataSource = lc.load(sqlLoadCombo);
            comboBox1.DisplayMember = "MaDM";
        }

        //Ghi dữ liệu được chọn từ Combobox lên textbox
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView row = comboBox1.SelectedItem as DataRowView;
            if (row != null)
            {
                txtMaDM.Text = row["MaDM"].ToString();
            }
        }
    }
}
