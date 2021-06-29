using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_TaiKhoan:ConnectDB
    {
        public DataTable ShowALl()
        {
            DataTable dt = new DataTable();
            string cmd = "select * from TaiKhoan where Quyen != 'Admin'";
            SqlCommand sqlcmd = new SqlCommand(cmd, sql);          
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlcmd);
            sqlDA.Fill(dt);
            return dt;
        }
        public DataTable getTaiKhoan(string tenDangNhap)
        {
            DataTable dt = new DataTable();
            string cmd = "SP_LayDuLieuTaiKhoanKhiDangNhap";
            SqlCommand sqlcmd = new SqlCommand(cmd, sql);
            sqlcmd.Parameters.Add(new SqlParameter("@param1", tenDangNhap));
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlcmd);
            sqlDA.Fill(dt);
            return dt;
        }
        public void updateMatKhau(string tenDangNhap, string matKhau)
        {           
            SqlCommand sqlcmd = new SqlCommand("SP_DoiMatKhau",sql);
            sqlcmd.Parameters.Add(new SqlParameter("@param1", matKhau));
            sqlcmd.Parameters.Add(new SqlParameter("@param2", tenDangNhap));
            sqlcmd.CommandType = CommandType.StoredProcedure;
            
            sqlcmd.ExecuteNonQuery();
         
        }
        public DataTable getMatKhauKhiDangNhap(string tenDangNhap)
        {
            DataTable dt = new DataTable();
            string cmd = "Select matKhau from TaiKhoan where tenDangNhap ='"+tenDangNhap+"'";
            SqlCommand sqlcmd = new SqlCommand(cmd, sql);
          
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlcmd);
            sqlDA.Fill(dt);
            return dt;
        }
        public DataTable Login(string tenDangNhap, string matKhau)
        {
            DataTable dt = new DataTable();
            string cmd = "SP_DangNhap";
            SqlCommand sqlcmd = new SqlCommand(cmd, sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@param1", tenDangNhap));
            sqlcmd.Parameters.Add(new SqlParameter("@param2", matKhau));
            SqlDataAdapter sqldtA = new SqlDataAdapter(sqlcmd);
            sqldtA.Fill(dt);
            return dt;
        }
        public DataTable getDaTaNhanVienFromLoGin(int maNV)
        {
            DataTable dt = new DataTable();
            string cmd = "SP_LayDuLieuNhanVienTuDangNhap";
            SqlCommand sqlcmd = new SqlCommand(cmd, sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@param1", maNV));
            SqlDataAdapter sqldtA = new SqlDataAdapter(sqlcmd);
            sqldtA.Fill(dt);
            return dt;
        }    
        public bool updateDaTaTaiKhoan(string tenDangNhap , string tenHienThi , string maNV , string Quyen , string matKhau)
        {         
            string cmd = "SP_SuaTaiKhoan";
            SqlCommand sqlcmd = new SqlCommand(cmd, sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@param1", tenDangNhap));
            sqlcmd.Parameters.Add(new SqlParameter("@param2", tenHienThi));
            sqlcmd.Parameters.Add(new SqlParameter("@param3", maNV));
            sqlcmd.Parameters.Add(new SqlParameter("@param4", Quyen));
            sqlcmd.Parameters.Add(new SqlParameter("@param5", matKhau));
            int r = sqlcmd.ExecuteNonQuery();
            if(r>=0)
            {
                return true;
            }
            return false;
        }
        public bool ThemTaiKhoan(string tenDangNhap, string tenHienThi, string maNV, string Quyen, string matKhau)
        {
            string cmd = "SP_ThemTaiKhoan";
            SqlCommand sqlcmd = new SqlCommand(cmd, sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@param1", tenDangNhap));
            sqlcmd.Parameters.Add(new SqlParameter("@param2", tenHienThi));
            sqlcmd.Parameters.Add(new SqlParameter("@param3", maNV));
            sqlcmd.Parameters.Add(new SqlParameter("@param4", Quyen));
            sqlcmd.Parameters.Add(new SqlParameter("@param5", matKhau));
            int r = sqlcmd.ExecuteNonQuery();
            if (r >= 0)
            {
                return true;
            }
            return false;
        }
        public bool RemoveTaiKhoan(string tenDangNhap)
        {
            string cmd = "SP_XoaTaiKhoan";
            SqlCommand sqlcmd = new SqlCommand(cmd, sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@param1", tenDangNhap));
          
            int r = sqlcmd.ExecuteNonQuery();
            if (r >= 0)
            {
                return true;
            }
            return false;
        }
        public bool RemoveTaiKhoanByMaNV(string maNV)
        {
           
            string cmd = "SP_XoaTaiKhoan";
            SqlCommand sqlcmd = new SqlCommand(cmd, sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add("@param1", maNV);
          

            int r = sqlcmd.ExecuteNonQuery();
            if (r >= 0)
            {
                return true;
            }
            return false;
        }
        public bool updateDaTaNhanVien(string maNV, string tenNV, string phai, string diaChi, string dienThoai)
        {
            string cmd = "SP_SuaNhanVien";
            SqlCommand sqlcmd = new SqlCommand(cmd, sql);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@param1", maNV));
            sqlcmd.Parameters.Add(new SqlParameter("@param2", tenNV));
            sqlcmd.Parameters.Add(new SqlParameter("@param3", phai));
            sqlcmd.Parameters.Add(new SqlParameter("@param4", diaChi));
            sqlcmd.Parameters.Add(new SqlParameter("@param5", dienThoai));
            int r = sqlcmd.ExecuteNonQuery();
            if (r >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
