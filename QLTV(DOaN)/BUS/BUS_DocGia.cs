using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{
   public class BUS_DocGia
    {
        DAL_DocGia daldg = new DAL_DocGia();
        public void  themDuLieuDocGia(string b, string c, string d, string e, string g, string h, string i)
        {
             daldg.InsertDataDocGia(b, c, d, e, g, h, i);
        }
        public void suaDuLieuDocGia(string a,string b, string c, string d, string e, string g, string h, string i)
        {
            daldg.ChangeDataDocGia(a,b, c, d, e, g, h, i);
        }
        public void xoaDuLieuDocGia(string b)
        {
            daldg.DeleteDataDocGia(b);
        }
        public DataTable DuLieuDocGia()
        {
           return daldg.GetDocGiaDaTa();
        }
        public DataTable DuLieuDocGiaTheoBang(string a,string b)
        {
           return daldg.GetDocGiaDaTaTheoBang(a,b);
        }
    }
}
