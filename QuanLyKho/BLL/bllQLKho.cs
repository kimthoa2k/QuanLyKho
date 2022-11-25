using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.BLL
{
    internal class bllQLKho
    {
        DAL.dalQLKho dalQLKho = new DAL.dalQLKho();
        frm_User us;
        frm_UserModule Usmodule;
        frm_DanhMuc frm_DanhMuc;
        frm_DanhMucModule frm_DanhMucModule;
        frm_SanPham frm_SanPham;
        frm_SanPhamModule frm_SanPhamModule;
        frm_NhaCCModule NCC;
        frm_NhaCC frm_NhaCC;
        frm_PhieuNhap frm_PhieuNhap;
        frm_PhieuNhapModule PN;
        frm_PhieuXuat frm_PhieuXuat;
        frm_PhieuXuatModule PX;

        public bllQLKho(frm_User User)
        {
            this.us = User;
        }

        public bllQLKho(frm_UserModule frm_UserModule)
        {
            this.Usmodule = frm_UserModule;
        }

        public bllQLKho(frm_DanhMuc frm_DanhMuc)
        {
            this.frm_DanhMuc = frm_DanhMuc;
        }

        public bllQLKho(frm_DanhMucModule frm_DanhMucModule)
        {
            this.frm_DanhMucModule = frm_DanhMucModule;
        }

        public bllQLKho(frm_SanPham frm_SanPham)
        {
            this.frm_SanPham = frm_SanPham;
        }

        public bllQLKho(frm_SanPhamModule frm_SanPhamModule)
        {
            this.frm_SanPhamModule = frm_SanPhamModule;
        }

        public bllQLKho(frm_NhaCCModule frm_NhaCCModule)
        {
            this.NCC = frm_NhaCCModule;
        }

        public bllQLKho(frm_NhaCC frm_NhaCC)
        {
            this.frm_NhaCC = frm_NhaCC;
        }

        public bllQLKho(frm_PhieuNhap frm_PhieuNhap)
        {
            this.frm_PhieuNhap = frm_PhieuNhap;
        }

        public bllQLKho(frm_PhieuNhapModule frm_PhieuNhapModule)
        {
            this.PN = frm_PhieuNhapModule;
        }

        public bllQLKho(frm_PhieuXuat frm_PhieuXuat)
        {
            this.frm_PhieuXuat = frm_PhieuXuat;
        }

        public bllQLKho(frm_PhieuXuatModule frm_PhieuXuatModule)
        {
            this.PX = frm_PhieuXuatModule;
        }

        //frm_UserModule
        //Thêm user
        public void bllThem()
        {
            dalQLKho.dalThem(Usmodule.txtUser.Text, Usmodule.txtFullNameUser.Text, Usmodule.txtPassUser.Text, Usmodule.txtSDTUser.Text);
        }
        //Sửa User
        public void bllSua()
        {
            dalQLKho.dalSua(Usmodule.txtUser.Text, Usmodule.txtFullNameUser.Text, Usmodule.txtPassUser.Text, Usmodule.txtSDTUser.Text);
        }

        //frm_DanhMucModule
        //Thêm danh mục
        public void bllThemDM()
        {
            dalQLKho.dalThemDM(frm_DanhMucModule.txtMaDM.Text, frm_DanhMucModule.txtTenDM.Text, frm_DanhMucModule.txtMaNCCDM.Text);
        }
        //Sửa danh mục
        public void bllSuaDM()
        {
            dalQLKho.dalSuaDM(frm_DanhMucModule.txtMaDM.Text, frm_DanhMucModule.txtTenDM.Text, frm_DanhMucModule.txtMaNCCDM.Text);
        }

        //frm_SanPhamModule
        //Thêm sản phẩm
        public void bllThemSP()
        {
            dalQLKho.dalThemSP(frm_SanPhamModule.txtMaSP.Text, frm_SanPhamModule.txtTenSP.Text, frm_SanPhamModule.txtGhiChu.Text,float.Parse(frm_SanPhamModule.txtDonGia.Text), int.Parse(frm_SanPhamModule.txtSoLuong.Text),frm_SanPhamModule.txtMaDM.Text);
        }
        //Sửa sản phẩm
        public void bllSuaSP()
        {
            dalQLKho.dalSuaSP(frm_SanPhamModule.txtMaSP.Text, frm_SanPhamModule.txtTenSP.Text, frm_SanPhamModule.txtGhiChu.Text, float.Parse(frm_SanPhamModule.txtDonGia.Text), int.Parse(frm_SanPhamModule.txtSoLuong.Text), frm_SanPhamModule.txtMaDM.Text);
        }

        //frm_NCC Module
        //Thêm ncc
        public void bllThemNCC()
        {
            dalQLKho.dalThemNCC(NCC.txtMaNCC.Text, NCC.txtTenNCC.Text, NCC.txtSDT.Text, NCC.txtDiaChi.Text);
        }
        //Sửa ncc
        public void bllSuaNCC()
        {
            dalQLKho.dalSuaNCC(NCC.txtMaNCC.Text, NCC.txtTenNCC.Text, NCC.txtSDT.Text, NCC.txtDiaChi.Text);
        }

        //frm_PN Module
        //Thêm PN
        public void bllThemPN()
        {
            dalQLKho.dalThemPN(PN.txtMaPN.Text, PN.txtTenNCC.Text, PN.txtTenSP.Text, int.Parse(PN.txtSoLuong.Text) ,PN.datePKPN.Value, PN.txtNguoiNhap.Text);
        }
        //Sửa PN
        public void bllSuaPN()
        {
            dalQLKho.dalSuaPN(PN.txtMaPN.Text, PN.txtTenNCC.Text, PN.txtTenSP.Text, int.Parse(PN.txtSoLuong.Text), PN.datePKPN.Value, PN.txtNguoiNhap.Text);
        }

        //frm_PX Module
        //Thêm PX
        public void bllThemPX()
        {
            dalQLKho.dalThemPX(PX.txtMaPX.Text, PX.txtTenKH.Text, PX.txtTenSP.Text, int.Parse(PX.txtSoLuong.Text), PX.datePKPX.Value, PX.txtNguoiXuat.Text);
        }
        //Sửa PX
        public void bllSuaPX()
        {
            dalQLKho.dalSuaPX(PX.txtMaPX.Text, PX.txtTenKH.Text, PX.txtTenSP.Text, int.Parse(PX.txtSoLuong.Text), PX.datePKPX.Value, PX.txtNguoiXuat.Text);
        }
    }
}
