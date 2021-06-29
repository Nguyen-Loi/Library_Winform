using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_ChiTietMuon : ConnectDB
    {
        public DataTable getDaTaFromChiTietMuon()
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("SP_LayDuLieuChiTietMuon", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqldta = new SqlDataAdapter(sqlcmd);
            sqldta.Fill(dt);
            return dt;
        }
        public DataTable getDaTaFromChiTietMuonByMaSach(string maSach)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("SP_layDuLieuChiTietMuonByMaSach", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@Param1",int.Parse(maSach)));
            SqlDataAdapter sqldta = new SqlDataAdapter(sqlcmd);
            sqldta.Fill(dt);
            return dt;
        }
        public bool updateDaTaStatusFromChiTietMuon(string maDG, string maSH, string ghiChu,string tinhTrang)
        {
            SqlCommand sqlcmd = new SqlCommand("SP_SuaChiTietMuon", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@Param1", maDG));
            sqlcmd.Parameters.Add(new SqlParameter("@Param2", maSH));   
            sqlcmd.Parameters.Add(new SqlParameter("@Param5", ghiChu));
            sqlcmd.Parameters.Add(new SqlParameter("@Param6", tinhTrang));          
            int r = sqlcmd.ExecuteNonQuery();
            if (r > 0)
            {
                return true;
            }
            return false;
        }
        public bool addDataChiTietMuon(string maDG, string maSH,DateTime ngayThue , DateTime ngayTra ,string ghiChu, string tinhTrang)
        {
            SqlCommand sqlcmd = new SqlCommand("SP_ThemChiTietMuon", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@Param1", maDG));
            sqlcmd.Parameters.Add(new SqlParameter("@Param2", maSH));
            sqlcmd.Parameters.Add(new SqlParameter("@Param3", ngayThue));
            sqlcmd.Parameters.Add(new SqlParameter("@Param4", ngayTra));
            sqlcmd.Parameters.Add(new SqlParameter("@Param5", ghiChu));
            sqlcmd.Parameters.Add(new SqlParameter("@Param6", tinhTrang));
            int r = sqlcmd.ExecuteNonQuery();
            if (r > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable searchAlmostRight(string bienTable, string timkiem)
        {
            DataTable dt = new DataTable();
            string command = "Select * From chiTietMuon Where " + bienTable + " like " + "N'%" + timkiem + "%'";
            SqlCommand sqlcmd = new SqlCommand(command, sql);
            SqlDataAdapter sqldta = new SqlDataAdapter(sqlcmd);
            sqldta.Fill(dt);
            return dt;
        }

        public bool payBookFromChiTietMuon(string maDG, string maSH)
        {
            SqlCommand sqlcmd = new SqlCommand("SP_XoaChiTietMuon", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@Param1", maDG));
            sqlcmd.Parameters.Add(new SqlParameter("@Param2", maSH));      
            int r = sqlcmd.ExecuteNonQuery();
            if (r > 0)
            {
                return true;
            }
            return false;
        }       
        public bool deleteChiTietMuonByMaSach(string maSH)
        {
            SqlCommand sqlcmd = new SqlCommand("SP_XoaChiTietMuonTheoMaSach", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;     
            sqlcmd.Parameters.Add(new SqlParameter("@Param1", maSH));
            int r = sqlcmd.ExecuteNonQuery();
            if (r > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable getDaTaChiTietMuontrehan()
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("SP_LayDuLieuDanhSachHetHanChiTietMuon", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqldta = new SqlDataAdapter(sqlcmd);
            sqldta.Fill(dt);
            return dt;
        }
        public DataTable getDaTaChiTietMuonconhan()
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("SP_LayDuLieuDanhSachConHanChiTietMuon",sql);
            //SqlCommand sqlcmd = new SqlCommand("SELECT * FROM dbo.chiTietMuon WHERE ngayTra > GETDATE()", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqldta = new SqlDataAdapter(sqlcmd);
            sqldta.Fill(dt);
            return dt;
        }    
        public DataTable getDaTaChiTietMuonFromDateStartAndEnd(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("SP_LayDuLieuThongKeTongSoSachChiTietMuon", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@Param1", ngayBatDau));
            sqlcmd.Parameters.Add(new SqlParameter("@Param2", ngayKetThuc));
            SqlDataAdapter sqldta = new SqlDataAdapter(sqlcmd);
            sqldta.Fill(dt);
            return dt;
        }
        public DataTable getDATAChiTietMuonSachDaCu()
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("SP_SoLuongSachDaCu", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqldta = new SqlDataAdapter(sqlcmd);
            sqldta.Fill(dt);
            return dt;
        }
    }
}
