using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_Sach:ConnectDB
    {
        public DataTable getDaTaFromSach()
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("SP_LayDuLieuSach", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqldta = new SqlDataAdapter(sqlcmd);
            sqldta.Fill(dt);
            return dt;
        }
        public bool xoaSach(string maSH)
        {
            SqlCommand sqlcmd = new SqlCommand("SP_XoaSach", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@Param1", maSH));
         
            int r = sqlcmd.ExecuteNonQuery();
            if (r >= 0)
            {
                return true;
            }
            return false;
        }
        public bool addDaTaFromSach(string maTL , string maVT, string tenSach,string noiDung,int soTrang,
            string tacGia,string ngonNgu,string nhaXuatBan,DateTime ngayMuaSach,float giaThue,int soLuong,string tonTai)
        {
            SqlCommand sqlcmd = new SqlCommand("SP_ThemSach", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@Param2", maTL));
            sqlcmd.Parameters.Add(new SqlParameter("@Param3", maVT));
            sqlcmd.Parameters.Add(new SqlParameter("@Param4", tenSach));
            sqlcmd.Parameters.Add(new SqlParameter("@Param5", noiDung));
            sqlcmd.Parameters.Add(new SqlParameter("@Param6", soTrang));
            sqlcmd.Parameters.Add(new SqlParameter("@Param7", tacGia));
            sqlcmd.Parameters.Add(new SqlParameter("@Param8", ngonNgu));
            sqlcmd.Parameters.Add(new SqlParameter("@Param9", nhaXuatBan));
            sqlcmd.Parameters.Add(new SqlParameter("@Param10", ngayMuaSach));
            sqlcmd.Parameters.Add(new SqlParameter("@Param11", giaThue));
            sqlcmd.Parameters.Add(new SqlParameter("@Param12", soLuong));
            sqlcmd.Parameters.Add(new SqlParameter("@Param13", tonTai));
            int r = sqlcmd.ExecuteNonQuery();
            if(r>=0)
            {
                return true;
            }
            return false;
        }
        public bool SuaDuLieuSach(string maSH, string maTL, string maVT, string tenSach, string noiDung, int soTrang,
            string tacGia, string ngonNgu, string nhaXuatBan, DateTime ngayMuaSach, float giaThue, string tonTai)
        {
            SqlCommand sqlcmd = new SqlCommand("SP_SuaSach", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@Param1", maSH));
            sqlcmd.Parameters.Add(new SqlParameter("@Param2", maTL));
            sqlcmd.Parameters.Add(new SqlParameter("@Param3", maVT));
            sqlcmd.Parameters.Add(new SqlParameter("@Param4", tenSach));
            sqlcmd.Parameters.Add(new SqlParameter("@Param5", noiDung));
            sqlcmd.Parameters.Add(new SqlParameter("@Param6", soTrang));
            sqlcmd.Parameters.Add(new SqlParameter("@Param7", tacGia));
            sqlcmd.Parameters.Add(new SqlParameter("@Param8", ngonNgu));
            sqlcmd.Parameters.Add(new SqlParameter("@Param9", nhaXuatBan));
            sqlcmd.Parameters.Add(new SqlParameter("@Param10", ngayMuaSach));
            sqlcmd.Parameters.Add(new SqlParameter("@Param11", giaThue));
            sqlcmd.Parameters.Add(new SqlParameter("@Param12", tonTai));
            int r = sqlcmd.ExecuteNonQuery();
            if (r > 0)
            {
                return true;
            }
            return false;
        }
        public bool SuaSoLuongSach(string maSH,int soLuong)
        {
            SqlCommand sqlcmd = new SqlCommand("SP_SuaSoLuongSach", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@Param1", maSH));
            sqlcmd.Parameters.Add(new SqlParameter("@Param2", soLuong));         
            int r = sqlcmd.ExecuteNonQuery();
            if (r > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable layDuLieuSachTheoMaSach(string maSach)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("SP_LayDuLieuSachTheoMaSach", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@param1", int.Parse(maSach)));
            SqlDataAdapter sqldta = new SqlDataAdapter(sqlcmd);
            sqldta.Fill(dt);
            return dt;
        }
        public DataTable searchAlmostRight(string bienTable , string timkiem)
        {
            DataTable dt = new DataTable();
            string command = "Select * From Sach Where " + bienTable + " LIKE " + "N'%" + timkiem + "%'";          
            SqlCommand sqlcmd = new SqlCommand(command, sql);
            SqlDataAdapter sqldta = new SqlDataAdapter(sqlcmd);
            sqldta.Fill(dt);
            return dt;
        }
    }
}
