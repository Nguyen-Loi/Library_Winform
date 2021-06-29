using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_TraSach
    {
        DAL_TraSach dalTS = new DAL_TraSach();
        public DataTable layDuLieuTraSach(DateTime ngayTraBatDau, DateTime NgayTraKetThuc)
        {
            return dalTS.layDuLieuTraSach(ngayTraBatDau,NgayTraKetThuc);
        }
        public DataTable layDulieuTraSachKhongDieuKien()
        {
            return dalTS.layDulieuTraSachKhongDieuKien();
        }
        public DataTable layDuLieuTraSachTheoMaSach(string maSach)
        {
            return dalTS.layDuLieuTraSachTheoMaSach(maSach);
        }
        public DataTable layDuLieuSachTheoMaSach(string maSach)
        {
            return dalTS.layDuLieuSachTheoMaSach(maSach);
        }
        public bool xoaDuLieuTraSachTheoMaSach(string maSach)
        {
            return dalTS.xoaDuLieuTraSachTheoMaSach(maSach);
        }
        public bool themDuLieuTraSach(string maDocGia, string maSach, string tenSach, DateTime ngayTra)
        {
            return dalTS.themDuLieuTraSach(maDocGia, maSach, tenSach, ngayTra);
        }
    }
}
