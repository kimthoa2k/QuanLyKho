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
    public partial class frm_DanhMucModule : Form
    {
        LopChung lc;
        BLL.bllQLKho bll;
        public frm_DanhMucModule()
        {
            InitializeComponent();
            bll = new BLL.bllQLKho(this);
            lc = new LopChung();
        }
        private void frm_DanhMucModule_Load(object sender, EventArgs e)
        {
            LoadComBo();
        }
        private void btnSaveDM_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn lưu không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bll.bllThemDM();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateDM_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn cập nhập không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bll.bllSuaDM();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSaveDM.Enabled = true;
            btnUpdateDM.Enabled = false;
        }
        public void Clear()
        {
            txtMaDM.Clear();
            txtTenDM.Clear();
            txtMaNCCDM.Clear();
        }
        public void LoadComBo()
        {
            string sqlLoadCombo = "select * from NhaCC";
            ckbNCC.DataSource = lc.load(sqlLoadCombo);
            ckbNCC.DisplayMember = "MaNCC";
        }

        private void ckbNCC_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView row = ckbNCC.SelectedItem as DataRowView;
            if (row != null)
            {
                txtMaNCCDM.Text = row["MaNCC"].ToString();
            }
        }
    }
}
