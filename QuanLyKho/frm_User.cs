using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class frm_User : Form
    {
        LopChung lc;
        BLL.bllQLKho bll;
        SqlDataReader dr;
        frm_UserModule UsM = new frm_UserModule();
        public frm_User()
        {
            InitializeComponent();
            bll = new BLL.bllQLKho(this);
            lc = new LopChung();
            LoadUser();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frm_UserModule UsM = new frm_UserModule();
            UsM.btnSave.Enabled = true;
            UsM.btnUpdate.Enabled = false;
            UsM.ShowDialog();
            LoadUser();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvUser.Columns[e.ColumnIndex].Name;

            //Thực hiện Edit
            if (ColName == "Edit")
            {  
                UsM.txtUser.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                UsM.txtFullNameUser.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                UsM.txtPassUser.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                UsM.txtSDTUser.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();

                //Thực hiện Edit nên tắt nút save và mở update
                UsM.btnSave.Enabled = false;
                UsM.btnUpdate.Enabled = true;
                UsM.txtUser.Enabled = false;
                UsM.ShowDialog();
            }
            else if (ColName == "delete")
            {
                DialogResult dialog;
                dialog = MessageBox.Show("Bạn có muốn xóa user không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    //UsM.txtUser.Enabled = true;
                    SqlCommand comm = new SqlCommand("delete from [User] where Phone LIKE '" + dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString() + "'", lc.ChuoiKetNoi());
                    lc.OpenKN();
                    try
                    {
                        int ketQua = comm.ExecuteNonQuery();
                        if (ketQua >= 1)
                            MessageBox.Show("Xóa user thành công", "Thông báo");
                        else
                            MessageBox.Show("Thất bại", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    lc.CloseKN(); 
                }
            }
            LoadUser();
        }

        public void LoadUser()
        {
            int i = 0;
            dgvUser.Rows.Clear();
            SqlCommand comm = new SqlCommand("select * from [User]", lc.ChuoiKetNoi());
            lc.OpenKN();
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUser.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            lc.CloseKN();
        }
    }
}

