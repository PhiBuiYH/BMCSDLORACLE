using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.ManagedDataAccess.Client;
using System.Data;
using BMCSDL;

namespace BMCSDL.DAL
{
    class DALDangNhap
    {
        private My_DB mydb = new My_DB();

        public DataTable ExecuteGetAccount(string TK, string MK)
        {
            OracleDataAdapter adapter = new OracleDataAdapter();
            DataTable table = new DataTable();
            OracleCommand command = new OracleCommand("SELECT * FROM TAIKHOAN WHERE TAIKHOAN=:taikhoan AND MATKHAU =:Pass", mydb.getConnection);
            command.Parameters.Add("taikhoan", OracleDbType.Varchar2).Value = TK;
            command.Parameters.Add("Pass", OracleDbType.Varchar2).Value = MK;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }
}
