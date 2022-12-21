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
    class BLLLuuTru
    {
        private DALLuuTru DALLuuTru = new DALLuuTru();

        //Lấy dữ liệu đưa vào datagridview
        public DataTable GetDataIntoDGV()
        {
            return DALLuuTru.ExecuteGetDataIntoDGV();
        }

        //Lấy tên của tài khoản đăng nhập
        public DataTable GetAccountName()
        {
            return DALLuuTru.ExecuteGetAccountName();
        }

        //Cập nhật lại tình trạng thông báo thành đã thông báo
        public int UpdateTTThongBao(string id)
        {
            return DALLuuTru.ExecuteUpdateTTThongBao(id);
        }
    }
}
