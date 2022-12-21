using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace BMCSDL.DAL
{
    class DALGiamSat
    {
        private My_DB mydb = new My_DB();

        //Lấy dữ liệu đưa vào datagridview XT
        public DataTable ExecuteGetDataIntoDGVXT()
        {
            DataTable table = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter("select IDUSERXT,ID from TIN.PASSPORTDATA where TTXACTHUC!='Chưa xác thực'", mydb.getConnectionNV());
            adapter.Fill(table);

            return table;
        }

        //Lấy dữ liệu đưa vào datagridview XD
        public DataTable ExecuteGetDataIntoDGVXD()
        {
            DataTable table = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter("select IDUSERXD,ID from TIN.PASSPORTDATA where TTXETDUYET!='Chưa duyệt'", mydb.getConnectionNV());
            adapter.Fill(table);

            return table;
        }

        //Lấy dữ liệu đưa vào datagridview LT
        public DataTable ExecuteGetDataIntoDGVLT()
        {
            DataTable table = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter("select IDUSERTT,ID from TIN.PASSPORTDATA where TTThongBao!='Chưa thông báo'", mydb.getConnectionNV());
            adapter.Fill(table);

            return table;
        }

        //Nhấn đúp DGV
        public DataTable ExecuteDoubleClickDGV(int id)
        {
            DataTable table = new DataTable();
            OracleCommand command = new OracleCommand("select HOTEN,NGAYSINH,DIACHI,PHAI,CMND,NGAYCAPCMND,DIENTHOAI,EMAIL,TTXACTHUC,TTXETDUYET,TTTHONGBAO from TIN.PASSPORTDATA where id=:id", mydb.getConnection);
            command.Parameters.Add("id", OracleDbType.Int32, 50).Value = id;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            adapter.Fill(table);

            return table;
        }

        //Lấy tên của tài khoản đăng nhập
        public DataTable ExecuteGetAccountName(int id)
        {
            //nếu id = -1 là lấy tên của account đăng nhập
            if (id == -1)
            {
                DataTable table = new DataTable();
                OracleCommand command = new OracleCommand("SELECT * FROM TAIKHOAN WHERE id=:id", mydb.getConnection);
                command.Parameters.Add("id", OracleDbType.Int32).Value = GlobalVariables.GlobalUserID;
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(table);

                return table;
            }
            //lấy tên theo từng dòng
            else
            {
                DataTable table = new DataTable();
                OracleCommand command = new OracleCommand("SELECT * from TIN.TAIKHOAN WHERE id =:id", mydb.getConnection);
                command.Parameters.Add("id", OracleDbType.Int32).Value = id;
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(table);

                return table;
            }
        }
    }
}
