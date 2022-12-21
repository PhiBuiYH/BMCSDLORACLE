using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace BMCSDL.DAL
{
    class DALTraThongTin
    {
        private My_DB mydb = new My_DB();

        //Lấy dữ liệu đưa vào datagridview
        public DataTable ExecuteGetDataIntoDGV()
        {
            DataTable table = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter("select CMND,HOTEN,NGAYSINH,GIOITINH,QUOCTICH,DIACHI,PHUONG,QUANHUYEN,TINH,NGAYCAP from TIN.Resident", mydb.getConnectionNV());
            adapter.Fill(table);
            mydb.closeConnection();
            return table;
        }

        //Tìm thông qua CMND
        public DataTable ExecuteFindByCMND(int CMND)
        {
            DataTable table = new DataTable();
            OracleCommand comnand = new OracleCommand("SELECT CMND,HOTEN,NGAYSINH,GIOITINH,QUOCTICH,DIACHI,PHUONG,QUANHUYEN,TINH,NGAYCAP from TIN.Resident WHERE CMND = " + CMND);
            comnand.Connection = mydb.getConnectionNV();
            OracleDataAdapter adapter = new OracleDataAdapter(comnand);
            
            adapter.Fill(table);

            return table;
        }

    }
}
