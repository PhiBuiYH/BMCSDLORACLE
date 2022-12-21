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
    class BLLXacThuc
    {
        private DALXacThuc DALXacThuc = new DALXacThuc();

        //Lấy dữ liệu đưa vào datagridview
        public DataTable GetDataIntoDGV()
        {
            return DALXacThuc.ExecuteGetDataIntoDGV();
        }

        //Lấy tên của tài khoản đăng nhập
        public DataTable GetAccountName()
        {
            return DALXacThuc.ExecuteGetAccountName();
        }


        //Cập nhật lại tình trạng xác thực thành đã xác thực
        public int UpdateTTXacThuc1(string CMND)
        {
            return DALXacThuc.ExecuteUpdateTTXacThuc1(CMND);
        }

        //Cập nhật lại tình trạng xác thực thành không xác thực
        public int UpdateTTXacThuc2(string CMND)
        {
            return DALXacThuc.ExecuteUpdateTTXacThuc2(CMND);
        }
    }
}
