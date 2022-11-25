using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QuanLyKho
{
    internal class LopChung
    {
        string chuoiKetNoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Downloads\QuanLyKho\QuanLyKho\QuanLyKho\DBQuanLyKho.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopChung()
        {
            conn = new SqlConnection(chuoiKetNoi);
        }

        //Tạo chuỗi kn + open,close chuỗi
        public SqlConnection ChuoiKetNoi()
        {
           return conn = new SqlConnection(chuoiKetNoi);
        }

        public void OpenKN()
        {
            conn.Open();
        }

        public void CloseKN()
        {
            conn.Close();
        }
        //Hết chuỗi kn + open,close chuỗi

        public DataTable load(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void NonQuery(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            try
            {
                int ketQua = comm.ExecuteNonQuery();
                if (ketQua >= 1)
                    MessageBox.Show("Thành công", "Thông báo");
                else
                    MessageBox.Show("Thất bại", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        //Ktr Tài Khoản
        public object Scalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }
    }
}
