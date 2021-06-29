using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
  public  class DAL_NhanVien:ConnectDB
    {
        public DataTable GetNhanVienDaTa()
        {
            DataTable dtb = new DataTable();
            string command = "SP_LayDuLieuNhanVien";
            SqlCommand cmd = new SqlCommand(command, sql);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtb);
            return dtb;
        }     
        public DataTable GetTheNewestNVData()
        {
            DataTable dtb = new DataTable();
            string command = "select Top 1 * from NhanVien Order by maNV desc ";
            SqlCommand cmd = new SqlCommand(command, sql);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtb);
            return dtb;
        }
        public DataTable GETAnhNhanVienTheoMaNV(string maNhanVien)
        {
            DataTable dtb = new DataTable();    
            SqlCommand cmd = new SqlCommand("SP_LayAnhTuMaNhanVien", sql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@param1", int.Parse(maNhanVien)));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtb);
            return dtb;
        }
        public DataTable GETNhanVienTheoMaNV(string a)
        {
            DataTable dtb = new DataTable();
            string command = "select * from NhanVien where maNV='" + a + "'";
            SqlCommand cmd = new SqlCommand(command, sql);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtb);
            return dtb;
        }
        public DataTable GETMaNVtheoTenDangNhap(string a)
        {
            DataTable dtb = new DataTable();
            string command = "select maNV from TaiKhoan where tenDangNhap='"+a+"'";
            SqlCommand cmd = new SqlCommand(command, sql);          
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtb);
            return dtb;
        }
        public DataTable GetNhanVienDaTaTheoBang(string tenbang,string dieukien)
        {
            DataTable dtb = new DataTable();
            string command = "Select * From NhanVien Where " + tenbang + " LIKE " + "N'%" + dieukien + "%'";
            SqlCommand cmd = new SqlCommand(command, sql);
    
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtb);
            return dtb;
        }
        public void InsertDataNhanVien(string a,string b,string c,string d,byte[]arr)
        {
            string command = "SP_ThemNhanVien";
            SqlCommand cmd = new SqlCommand(command, sql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@param2", a));
            cmd.Parameters.Add(new SqlParameter("@param3", b));
            cmd.Parameters.Add(new SqlParameter("@param4", c));
            cmd.Parameters.Add(new SqlParameter("@param5", d));
            cmd.Parameters.Add(new SqlParameter("@param6", arr));

            cmd.ExecuteNonQuery();
           
        }
        public void DeleteDataNhanVien(string a)
        {
            string command = "delete from NhanVien where MaNV like '"+a+"'";
            SqlCommand cmd = new SqlCommand(command, sql);
            cmd.ExecuteNonQuery();
        }
        public void ChangeDataNhanVienHasImage(string a, string b, string c, string d,string e,byte [] arr)
        {
            string command = "SP_SuaNhanVienCoAnh";
            SqlCommand cmd = new SqlCommand(command, sql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@param1", a));
            cmd.Parameters.Add(new SqlParameter("@param2", b));
            cmd.Parameters.Add(new SqlParameter("@param3", c));
            cmd.Parameters.Add(new SqlParameter("@param4", d));
            cmd.Parameters.Add(new SqlParameter("@param5", e));
            cmd.Parameters.Add(new SqlParameter("@param6", arr));
            cmd.ExecuteNonQuery();
        }
        public void ChangeDataNhanVien(string a, string b, string c, string d, string e)
        {
            string command = "SP_SuaNhanVienCoAnh";
            SqlCommand cmd = new SqlCommand(command, sql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@param1", a));
            cmd.Parameters.Add(new SqlParameter("@param2", b));
            cmd.Parameters.Add(new SqlParameter("@param3", c));
            cmd.Parameters.Add(new SqlParameter("@param4", d));
            cmd.Parameters.Add(new SqlParameter("@param5", e));    
            cmd.ExecuteNonQuery();
        }
    }
}
