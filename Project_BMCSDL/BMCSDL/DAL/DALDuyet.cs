using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace BMCSDL.DAL
{
    class DALDuyet
    {
        private My_DB mydb = new My_DB();

        //Lấy dữ liệu đưa vào datagridview
        public DataTable ExecuteGetDataIntoDGV()
        {
            DataTable table = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter("select HOTEN,NGAYSINH,DIACHI,PHAI,CMND,NGAYCAPCMND,DIENTHOAI,EMAIL from TIN.PASSPORTDATA where TTXACTHUC='Đã xác thực' and TTXETDUYET='Chưa duyệt'", mydb.getConnectionNV());
            adapter.Fill(table);
            mydb.closeConnection();
            return table;
        }

        //Lấy tên của tài khoản đăng nhập
        public DataTable ExecuteGetAccountName()
        {
            DataTable table = new DataTable();
            OracleCommand command = new OracleCommand("SELECT * FROM TAIKHOAN WHERE id=:id", mydb.getConnection);
            command.Parameters.Add("id", OracleDbType.Int32).Value = GlobalVariables.GlobalUserID;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            adapter.Fill(table);

            return table;
        }

        //Cập nhật lại tình trạng duyệt thành đã duyệt
        public int ExecuteUpdateTTDuyet1(string CMND)
        {
            OracleCommand command = new OracleCommand("update TIN.PASSPORTDATA set TTXETDUYET = :xacthuc,IDUSERXD=:iduser where CMND=:cmnd", mydb.getConnectionNV());
            command.Parameters.Add("xacthuc", OracleDbType.NVarchar2, 50).Value = "Đã xét duyệt";
            command.Parameters.Add("iduser", OracleDbType.NVarchar2, 50).Value = GlobalVariables.GlobalUserID.ToString();
            command.Parameters.Add("cmnd", OracleDbType.Varchar2, 40).Value = CMND;

            int result = command.ExecuteNonQuery();

            return result;
        }

        //Cập nhật lại tình trạng duyệt thành không duyệt
        public int ExecuteUpdateTTDuyet2(string CMND)
        {
            OracleCommand command = new OracleCommand("update TIN.PASSPORTDATA set TTXETDUYET = :xacthuc,IDUSERXD=:iduser where CMND=:cmnd", mydb.getConnectionNV());
            command.Parameters.Add("xacthuc", OracleDbType.NVarchar2, 50).Value = "Không duyệt";
            command.Parameters.Add("iduser", OracleDbType.NVarchar2, 50).Value = GlobalVariables.GlobalUserID.ToString();
            command.Parameters.Add("cmnd", OracleDbType.Varchar2, 30).Value = CMND;

            int result = command.ExecuteNonQuery();

            return result;
        }
    }
}
