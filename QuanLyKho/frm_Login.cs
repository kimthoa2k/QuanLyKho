using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class frm_Login : Form
    {
        LopChung lc;
        public frm_Login()
        {
            InitializeComponent();
            lc = new LopChung();
        }

        private void CkbHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbHienThi.Checked == false)
                txtMk.UseSystemPasswordChar = true;
            else
                txtMk.UseSystemPasswordChar = false;
        }

        private void lblXoa_Click(object sender, EventArgs e)
        {
            txtMk.Clear();
            txtTk.Clear();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát chương trình không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sqlDangNhap = "select count (*) from [User] where UserName = N'" + txtTk.Text + "' and Password = '" + txtMk.Text + "'";
            int ketqua = (int)lc.Scalar(sqlDangNhap);
            if (ketqua >= 1)
            {
                frm_Main BossGD = new frm_Main();
                BossGD.Show();
            }
            else
                MessageBox.Show("Lỗi đăng nhập","Thông báo");
        }
    }
}
