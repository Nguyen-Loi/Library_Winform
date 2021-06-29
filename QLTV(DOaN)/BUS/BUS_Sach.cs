using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_Sach
    {
        DAL_Sach dalSach = new DAL_Sach();
        public DataTable getDaTaFromSach()
        {
            return dalSach.getDaTaFromSach();
        }
        public bool addDaTaFromSach(string maTL, string maVT, string tenSach, string noiDung, int soTrang,
            string tacGia, string ngonNgu, string nhaXuatBan, DateTime ngayMuaSach, float giaThue,int soLuong, string tonTai)
        {
            return dalSach.addDaTaFromSach(maTL,maVT,tenSach,noiDung,soTrang,tacGia,
                ngonNgu,nhaXuatBan,ngayMuaSach,giaThue,soLuong,tonTai);
        }
        public DataTable searchAlmostRight(string bienTable, string timkiem)
        {
            return dalSach.searchAlmostRight(bienTable, timkiem);
        }

        public bool SuaDuLieuSach(string maSH, string maTL, string maVT, string tenSach, string noiDung, int soTrang,
            string tacGia, string ngonNgu, string nhaXuatBan, DateTime ngayMuaSach, float giaThue,string tonTai)
        {
            return dalSach.SuaDuLieuSach(maSH,maTL, maVT, tenSach, noiDung, soTrang, tacGia,
                ngonNgu, nhaXuatBan, ngayMuaSach, giaThue, tonTai);
        }
        public bool SuaSoLuongSach(string maSH, int soLuong)
        {
            return dalSach.SuaSoLuongSach(maSH, soLuong);
        }
        public DataTable layDuLieuSachTheoMaSach(string maSach)
        {
            return dalSach.layDuLieuSachTheoMaSach(maSach);
        }
        public bool xoaSach(string maSH)
        {
            return dalSach.xoaSach(maSH);
        }
    }
}
