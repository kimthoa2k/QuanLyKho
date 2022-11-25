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
    public partial class frm_UserModule : Form
    {
        LopChung lc;
        BLL.bllQLKho bll;
        public frm_UserModule()
        {
            InitializeComponent();
            bll = new BLL.bllQLKho(this);
            lc = new LopChung();
        }

        private void frm_UserModule_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassUser.Text != txtNLaiMK.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng !!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn lưu không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    bll.bllThem();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassUser.Text != txtNLaiMK.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn cập nhập không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bll.bllSua();
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
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            txtUser.Clear();
            txtFullNameUser.Clear();
            txtPassUser.Clear();
            txtSDTUser.Clear();
            txtNLaiMK.Clear();
        }       
    }
}
