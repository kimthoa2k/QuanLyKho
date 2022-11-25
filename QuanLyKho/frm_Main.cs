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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        //Show form con lên form main
        private Form activeForm = null;
        private void openFormChild(Form child)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm=child;

            //Đặt thuộc tính cho form child
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelMain.Controls.Add(child);
            panelMain.Tag = child;
            child.BringToFront();

            //Show child
            child.Show();
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            openFormChild(new frm_User());
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            openFormChild(new frm_DanhMuc());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            openFormChild(new frm_SanPham());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openFormChild(new frm_NhaCC());
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            openFormChild(new frm_PhieuNhap());
        }

        private void btnPhieuXuat_Click(object sender, EventArgs e)
        {
            openFormChild(new frm_PhieuXuat());
        }
    }
}
