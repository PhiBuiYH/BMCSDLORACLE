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
    class BLLDuyet
    {
        private DALDuyet DALDuyet = new DALDuyet();

        //Lấy dữ liệu đưa vào datagridview
        public DataTable GetDataIntoDGV()
        {
            return DALDuyet.ExecuteGetDataIntoDGV();
        }

        //Lấy tên của tài khoản đăng nhập
        public DataTable GetAccountName()
        {
            return DALDuyet.ExecuteGetAccountName();
        }

        //Cập nhật lại tình trạng duyệt thành đã duyệt
        public int UpdateTTDuyet1(string CMND)
        {
            return DALDuyet.ExecuteUpdateTTDuyet1(CMND);
        }

        //Cập nhật lại tình trạng duyệt thành không duyệt
        public int UpdateTTDuyet2(string CMND)
        {
            return DALDuyet.ExecuteUpdateTTDuyet2(CMND);
        }
    }
}
