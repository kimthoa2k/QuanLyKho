using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKho.DAL
{
    internal class dalQLKho
    {
        LopChung lc;
        frm_User us;
        frm_UserModule Usmodule;

        public dalQLKho()
        {
            lc = new LopChung();
        }

        public dalQLKho(frm_User User)
        {
            this.us = User;
        }

        public dalQLKho(frm_UserModule frm_UserModule)
        {
            this.Usmodule = frm_UserModule;
        }

        //frm_UserModule
        //Thêm user
        public void dalThem(string user,string fname,string pass,string phone)
        {
            string sqlThem = "insert into [User] values( N'" + user + "',N'" + fname + "',N'" + pass + "','" + phone + "')";
            lc.NonQuery(sqlThem);
        }
        //Sửa user
        public void dalSua(string user, string fname, string pass, string phone)
        {
            string sqlCapNhat = "update [User] set FullName = N'" + fname + "' , Password = N'" + pass + "', Phone = '" + phone + "'  where UserName = N'" + user + "'";
            lc.NonQuery(sqlCapNhat);
        }

        //frm_DanhMucModule
        //Thêm danh muc
        public void dalThemDM(string madm, string tendm, string mancc)
        {
            string sqlThem = "insert into [DanhMuc] values(N'" + madm + "',N'" + tendm + "',N'" + mancc + "')";
            lc.NonQuery(sqlThem);
        }
        //Sửa danh muc
        public void dalSuaDM(string madm, string tendm, string mancc)
        {
            string sqlCapNhat = "update [DanhMuc] set TenDM = N'" + tendm + "',MaNCC = N'" + mancc + "' where MaDM = N'" + madm + "'";
            lc.NonQuery(sqlCapNhat);
        }

        //frm_SanPhamModule
        //Thêm SanPham
        public void dalThemSP(string masp, string tensp, string gchu, float dongia, int soluong,string madm)
        {
            string sqlThem = "insert into [SanPham] values(N'" + masp + "',N'" + tensp + "',N'" + gchu + "',convert(float,'" + dongia + "'),convert(int,'" + soluong + "'),'" + madm+ "')";
            lc.NonQuery(sqlThem);
        }
        //Sửa SanPham
        public void dalSuaSP(string masp, string tensp, string gchu, float dongia, int soluong, string madm)
        {
            string sqlCapNhat = "update [SanPham] set TenSP = N'" + tensp + "',GhiChu = N'" + gchu + "',DonGia = convert(float, '" + dongia + "'), SoLuong = convert(int,'" + soluong + "'),MaDM = N'" + madm + "' where MaSP = N'" + masp + "'";
            lc.NonQuery(sqlCapNhat);
        }

        //frm_ncc Module
        //Thêm ncc
        public void dalThemNCC(string mancc, string tenncc, string sdt, string diachi)
        {
            string sqlThem = "insert into [NhaCC] values(N'" + mancc + "',N'" + tenncc + "',N'" + sdt + "',N'" + diachi + "')";
            lc.NonQuery(sqlThem);
        }
        //Sửa ncc
        public void dalSuaNCC(string mancc, string tenncc, string sdt, string diachi)
        {
            string sqlCapNhat = "update [NhaCC] set TenNCC = N'" + tenncc + "',SDT = N'" + sdt + "',DiaChi = N'" + diachi + "' where MaNCC = N'" + mancc + "'";
            lc.NonQuery(sqlCapNhat);
        }

        //frm_PN Module
        //Thêm PN
        public void dalThemPN(string mapn,string tenncc,string tensp,int soluong,DateTime ngayn,string nguoin)
        {
            string sqlThem = "insert into [PhieuNhap] values(N'" + mapn + "',N'" + tenncc + "',N'" + tensp + "',convert(int,'" + soluong + "'),convert(dateTime,'" + ngayn + "',103),N'" + nguoin + "')";
            lc.NonQuery(sqlThem);
        }
        //Sửa PN
        public void dalSuaPN(string mapn, string tenncc, string tensp, int soluong, DateTime ngayn, string nguoin)
        {
            string sqlCapNhat = "update [PhieuNhap] set TenNCC = N'" + tenncc + "',TenSP = N'" + tensp + "', SoLuongNhap = convert(int,'" + soluong + "') ,NgayNhap = convert(dateTime,'" + ngayn + "',103),NguoiNhap = N'" + nguoin + "' where MaPN = N'" + mapn + "'";
            lc.NonQuery(sqlCapNhat);
        }

        //frm_PX Module
        //Thêm PX
        public void dalThemPX(string mapx, string tenkh, string tensp, int soluong, DateTime ngayx, string nguoix)
        {
            string sqlThem = "insert into [PhieuXuat] values(N'" + mapx + "',N'" + tenkh + "',N'" + tensp + "',convert(int,'" + soluong + "'),convert(dateTime,'" + ngayx + "',103),N'" + nguoix + "')";
            lc.NonQuery(sqlThem);
        }
        //Sửa PX
        public void dalSuaPX(string mapx, string tenkh, string tensp, int soluong, DateTime ngayx, string nguoix)
        {
            string sqlCapNhat = "update [PhieuNhap] set TenKH = N'" + tenkh + "',TenSP = N'" + tensp + "', SoLuongNhap = convert(int,'" + soluong + "') ,NgayXuat = convert(dateTime,'" + ngayx + "',103), NguoiXuat = N'" + nguoix + "' where MaPX = N'" + mapx + "'";
            lc.NonQuery(sqlCapNhat);
        }
    }
}
