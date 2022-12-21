using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace BMCSDL.DAL
{
    class DALLuuTru
    {
        private My_DB mydb = new My_DB();

        //Lấy dữ liệu đưa vào datagridview
        public DataTable ExecuteGetDataIntoDGV()
        {
            DataTable table = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter("select id, TTXACTHUC, TTXETDUYET from TIN.PASSPORTDATA where TTXACTHUC='Đã xác thực' and TTXETDUYET!='Chưa duyệt' and TTTHONGBAO='Chưa thông báo'", mydb.getConnectionNV());
            adapter.Fill(table);           
            mydb.closeConnectionNV();

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

        //Cập nhật lại tình trạng thông báo thành đã thông báo
        public int ExecuteUpdateTTThongBao(string id)
        {
            OracleCommand command = new OracleCommand("update TIN.PASSPORTDATA set TTTHONGBAO = :xacthuc,IDUSERTT=:iduser where ID=:id", mydb.getConnectionNV());
            command.Parameters.Add("xacthuc", OracleDbType.NVarchar2, 50).Value = "Đã thông báo";
            command.Parameters.Add("iduser", OracleDbType.NVarchar2, 50).Value = GlobalVariables.GlobalUserID.ToString();
            command.Parameters.Add("id", OracleDbType.Int32).Value = Int32.Parse(id);
            mydb.openConnectionNV();

            int result = command.ExecuteNonQuery();

            return result;
        }
    }
}
