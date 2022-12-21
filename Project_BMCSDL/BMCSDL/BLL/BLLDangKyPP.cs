using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.ManagedDataAccess.Client;
using System.Data;
using BMCSDL.DAL;
using BMCSDL.DTO;

namespace BMCSDL.BLL
{
    class BLLDangKyPP
    {
        private DALDangKyPP DALDangKyPP = new DALDangKyPP();

        //Insert thêm vào PASSPORTDATA
        public int DangKy(PASSPORTDATA pp)
        {
            return DALDangKyPP.ExecuteDangKy(pp);
        }
        }
}
