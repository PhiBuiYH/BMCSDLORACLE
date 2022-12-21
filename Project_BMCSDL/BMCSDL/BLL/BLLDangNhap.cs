using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.ManagedDataAccess.Client;
using System.Data;
using BMCSDL.DAL;

namespace BMCSDL.BLL
{
    class BLLDangNhap
    {
        private My_DB mydb = new My_DB();
        private DALDangNhap DALDangNhap = new DALDangNhap();

        public DataTable GetAccount(string TK, string MK)
        {
            return DALDangNhap.ExecuteGetAccount(TK, MK);
        }
    }
}
