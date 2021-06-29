using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dalTK = new DAL_TaiKhoan();
        public DataTable getTaiKhoan(string tenDangNhap)
        {
            return dalTK.getTaiKhoan(tenDangNhap);
        }
        public DataTable showAll()
        {
            return dalTK.ShowALl();
        }
        public DataTable loGin(string tenDangNhap, string matKhau)
        {
            return dalTK.Login(tenDangNhap, matKhau);
        }
        public DataTable getDaTaNhanVienFromLoGin(int maNV)
        {
            return dalTK.getDaTaNhanVienFromLoGin(maNV);
        }
        public bool updateDaTaTaiKhoan(string tenDangNhap, string tenHienThi, string maNV, string Quyen, string matKhau)
        {
            return dalTK.updateDaTaTaiKhoan(tenDangNhap, tenHienThi, maNV, Quyen, matKhau);
        }
        public bool updateDaTaNhanVien(string maNV, string tenNV, string phai, string diaChi, string dienThoai)
        {
            return dalTK.updateDaTaNhanVien(maNV, tenNV, phai, diaChi, dienThoai);
        }
        public bool THemDataTK(string tenDangNhap, string tenHienThi, string maNV, string Quyen, string matKhau)
        {
            return dalTK.ThemTaiKhoan(tenDangNhap, tenHienThi, maNV, Quyen, matKhau);
        }
        public bool RemovedataTK(string tenDangNhap)
        {
            return dalTK.RemoveTaiKhoan(tenDangNhap);
        }
        public bool RemovedataTKbyMANV(string maNV)
        {
            return dalTK.RemoveTaiKhoanByMaNV(maNV);
        }
        public DataTable getMatKhau(string tendangnhap)
        {
            return dalTK.getMatKhauKhiDangNhap(tendangnhap);
        }
        public void doiMatKhau(string tendangnhap,string matkhau)
        {
            dalTK.updateMatKhau(tendangnhap, matkhau);
        }
    }
}
