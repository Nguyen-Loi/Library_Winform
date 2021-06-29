using System;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL
{
    public class ConnectDB
    {
        string strCon = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        public SqlConnection sql = new SqlConnection("");

        public ConnectDB()
        {
            sql.ConnectionString = strCon;
            try
            {
                sql.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //public SqlConnection sql = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True");

        //public ConnectDB()
        //{
        //    try
        //    {
        //        sql.Open();
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}
    }
}
