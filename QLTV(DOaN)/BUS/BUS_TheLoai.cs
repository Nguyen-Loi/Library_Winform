using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_TheLoai
    {
        DAL_TheLoai dalTheLoai = new DAL_TheLoai();
        public DataTable getDaTaFromTheLoai()
        {
            return dalTheLoai.getDaTaFromTheLoai();
        }     
    }
}
