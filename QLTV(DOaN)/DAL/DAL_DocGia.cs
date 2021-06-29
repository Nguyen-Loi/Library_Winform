using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
   public class DAL_DocGia:ConnectDB
    {
        public DataTable GetDocGiaDaTa()
        {
            DataTable dtb = new DataTable();
            string command = "SP_LayDuLieuDocGia";
            SqlCommand cmd = new SqlCommand(command, sql);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtb);
            return dtb;
        }
        public DataTable GetDocGiaDaTaTheoBang(string tenbang, string dieukien)
        {
            DataTable dtb = new DataTable();
            string command = "Select * From DocGia Where " + tenbang + " LIKE " + "N'%" + dieukien + "%'";
            SqlCommand cmd = new SqlCommand(command, sql);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtb);
            return dtb;
        }
        public void InsertDataDocGia( string b, string c, string d, string e, string g, string h,string i)
        {
            string command = "SP_ThemDocGia";
            SqlCommand cmd = new SqlCommand(command, sql);
            cmd.CommandType = CommandType.StoredProcedure;          
            cmd.Parameters.Add(new SqlParameter("@param2", b));
            cmd.Parameters.Add(new SqlParameter("@param3", c));
            cmd.Parameters.Add(new SqlParameter("@param4", d));
            cmd.Parameters.Add(new SqlParameter("@param5", e));
            cmd.Parameters.Add(new SqlParameter("@param6", g));
            cmd.Parameters.Add(new SqlParameter("@param7", h));
            cmd.Parameters.Add(new SqlParameter("@param8", i));
            cmd.ExecuteNonQuery();

        }
        public void DeleteDataDocGia(string a)
        {
            string command = "delete from DocGia where maDG  like '" + a + "'";
            SqlCommand cmd = new SqlCommand(command, sql);




            cmd.ExecuteNonQuery();

        }
        public void ChangeDataDocGia(string a, string b, string c, string d, string e,string g,string h,string i)
        {
            string command = "SP_SuaDocGia";
            SqlCommand cmd = new SqlCommand(command, sql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@param1", a));
            cmd.Parameters.Add(new SqlParameter("@param2", b));
            cmd.Parameters.Add(new SqlParameter("@param3", c));
            cmd.Parameters.Add(new SqlParameter("@param4", d));
            cmd.Parameters.Add(new SqlParameter("@param5", e));
            cmd.Parameters.Add(new SqlParameter("@param6", g));
            cmd.Parameters.Add(new SqlParameter("@param7", h));
            cmd.Parameters.Add(new SqlParameter("@param8", i));
            cmd.ExecuteNonQuery();

        }
    }
}
