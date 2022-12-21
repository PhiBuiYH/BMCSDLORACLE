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
    class BLLGiamSat
    {
        private DALGiamSat DALGiamSat = new DALGiamSat();

        //Lấy dữ liệu đưa vào datagridview XT
        public DataTable GetDataIntoDGVXT()
        {
            return DALGiamSat.ExecuteGetDataIntoDGVXT();
        }

        //Lấy dữ liệu đưa vào datagridview XD
        public DataTable GetDataIntoDGVXD()
        {
            return DALGiamSat.ExecuteGetDataIntoDGVXD();
        }

        //Lấy dữ liệu đưa vào datagridview LT
        public DataTable GetDataIntoDGVLT()
        {
            return DALGiamSat.ExecuteGetDataIntoDGVLT();
        }

        //Lấy tên của tài khoản đăng nhập
        public DataTable GetAccountName(int id)
        {
            return DALGiamSat.ExecuteGetAccountName(id);
        }

        //Nhấn đúp DGV
        public DataTable DoubleClickDGV(int id)
        {
            return DALGiamSat.ExecuteDoubleClickDGV(id);
        }
    }
}
