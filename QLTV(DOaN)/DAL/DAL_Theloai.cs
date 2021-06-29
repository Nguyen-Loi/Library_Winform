using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_TheLoai : ConnectDB
    {
        public DataTable getDaTaFromTheLoai()
        {
            DataTable dt = new DataTable();
            string cmd = "SP_LayDuLieuTheLoai";
            SqlCommand sqlcmd = new SqlCommand(cmd, sql);         
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlcmd);
            sqlDA.Fill(dt);
            return dt;
        }     
    }
}
