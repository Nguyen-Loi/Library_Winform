using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_TraSach:ConnectDB
    {
        public DataTable layDuLieuTraSach(DateTime ngayTraBatDau , DateTime ngayTraKetThuc)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("SP_LayDuLieuTraSach", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@param1", ngayTraBatDau));
            sqlcmd.Parameters.Add(new SqlParameter("@param2", ngayTraKetThuc));
            SqlDataAdapter sqldta = new SqlDataAdapter(sqlcmd);
            sqldta.Fill(dt);
            return dt;
        }       
        public DataTable layDuLieuTraSachTheoMaSach(string maSach)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("SP_LayDuLieuTraSachTheoMaSach", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@param1", int.Parse(maSach)));    
            SqlDataAdapter sqldta = new SqlDataAdapter(sqlcmd);
            sqldta.Fill(dt);
            return dt;
        }
        public DataTable layDulieuTraSachKhongDieuKien()
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("SP_LayDuLieuTraSachKhongDieuKien", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure; 
            SqlDataAdapter sqldta = new SqlDataAdapter(sqlcmd);
            sqldta.Fill(dt);
            return dt;
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
        public bool xoaDuLieuTraSachTheoMaSach(string maSach)
        {
            SqlCommand sqlcmd = new SqlCommand("SP_XoaTraSachTheoMaSach", sql);         
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@param1", maSach));               
            int r = sqlcmd.ExecuteNonQuery();
            if (r >= 0)
            {
                return true;
            }          
            return false;
        }
        public bool themDuLieuTraSach(string maDocGia,string maSach,string tenSach,DateTime ngayTra)
        {
            SqlCommand sqlcmd = new SqlCommand("SP_ThemTraSach", sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@param1", maDocGia));
            sqlcmd.Parameters.Add(new SqlParameter("@param2", maSach));
            sqlcmd.Parameters.Add(new SqlParameter("@param3", tenSach));
            sqlcmd.Parameters.Add(new SqlParameter("@param4", ngayTra));
            int r = sqlcmd.ExecuteNonQuery();
            try
            {
                if (r >= 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }           
            return false;
        }
    }
}
