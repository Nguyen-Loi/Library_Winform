using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_ViTri
    {
        DAL_ViTri dalViTri = new DAL_ViTri();
        public DataTable getDaTaFromViTri()
        {
            return dalViTri.getDaTaFromViTri();
        }
    }
}
