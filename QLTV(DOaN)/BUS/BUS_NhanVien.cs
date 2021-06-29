using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{
   public class BUS_NhanVien
    {
        DAL_NhanVien dalnv = new DAL_NhanVien();
        public DataTable getNhanVienDaTa()
        {
            return dalnv.GetNhanVienDaTa();
        }
        public DataTable GETAnhNhanVienTheoMaNV(string maNhanVien)
        {
            return dalnv.GETAnhNhanVienTheoMaNV(maNhanVien);
        }
        public DataTable getNewestNhanVienDaTa()
        {
            return dalnv.GetTheNewestNVData();
        }
        public DataTable getnhanvientheomanvs(string manv)
        {
            return dalnv.GETNhanVienTheoMaNV(manv);
        }
        public DataTable getNhanVienDaTaTheoBang(string bang, string dieukien)
        {
            return dalnv.GetNhanVienDaTaTheoBang(bang,dieukien);
        }
        public void themDuLieuNhanVien(string a,string b, string c, string d, byte[] arr)
        {
             dalnv.InsertDataNhanVien(a, b, c, d, arr);
        }
        public void SuaDuLieuNhanVienHasImage(string a, string b, string c, string d,string e,byte [] arr)
        {
            dalnv.ChangeDataNhanVienHasImage(a, b, c, d,e,arr);
        }
        public void SuaDuLieuNhanVien(string a, string b, string c, string d, string e)
        {
            dalnv.ChangeDataNhanVien(a, b, c, d, e);
        }
        public void xoaDuLieuNhanVien(string a)
        {
            dalnv.DeleteDataNhanVien(a);
        }
        public DataTable getmaNVtheoTenDangNhap(string tenDangNhap)
        {
            return dalnv.GETMaNVtheoTenDangNhap(tenDangNhap );
        }
    }
}
