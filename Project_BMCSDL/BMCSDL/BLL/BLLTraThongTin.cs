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
    class BLLTraThongTin
    {
        private DALTraThongTin DALTraThongTin = new DALTraThongTin();

        //Lấy dữ liệu đưa vào datagridview
        public DataTable GetDataIntoDGV()
        {
            return DALTraThongTin.ExecuteGetDataIntoDGV();
        }

        //Tìm thông qua CMND
        public DataTable FindByCMND(int CMND)
        {
            return DALTraThongTin.ExecuteFindByCMND(CMND);
        }
    }
}
