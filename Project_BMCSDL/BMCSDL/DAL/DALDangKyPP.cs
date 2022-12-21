using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.ManagedDataAccess.Client;
using System.Data;
using BMCSDL.DTO;

namespace BMCSDL.DAL
{
    class DALDangKyPP
    {
        private My_DB mydb = new My_DB();

        //Insert thêm vào PASSPORTDATA
        public int ExecuteDangKy(PASSPORTDATA pp)
        {
            OracleCommand command = new OracleCommand("INSERT INTO PASSPORTDATA (HOTEN,DIACHI,PHAI,CMND,DIENTHOAI,EMAIL,TTXACTHUC,TTXETDUYET,TTTHONGBAO,NGAYSINH,NGAYCAPCMND)" + "VALUES (:hoten,:diachi,:phai,:cmnd,:dienthoai,:email,:ttxacthuc,:ttxetduyet,:ttthongbao,:ngaysinh,:ngaycapcmnd)", mydb.getConnection);
            command.Parameters.Add("hoten", OracleDbType.NVarchar2, 50).Value = pp.HOTEN;
            command.Parameters.Add("diachi", OracleDbType.NVarchar2, 200).Value = pp.DIACHI;
            command.Parameters.Add("phai", OracleDbType.NVarchar2, 20).Value = pp.PHAI;
            command.Parameters.Add("cmnd", OracleDbType.NVarchar2, 15).Value = pp.CMND;
            command.Parameters.Add("dienthoai", OracleDbType.NVarchar2, 20).Value = pp.DIENTHOAI;
            command.Parameters.Add("email", OracleDbType.NVarchar2, 30).Value = pp.EMAIL;
            command.Parameters.Add("ttxacthuc", OracleDbType.NVarchar2, 30).Value = pp.TTXACTHUC;
            command.Parameters.Add("ttxetduyet", OracleDbType.NVarchar2, 30).Value = pp.TTXETDUYET;
            command.Parameters.Add("ttthongbao", OracleDbType.NVarchar2, 30).Value = pp.TTTHONGBAO;
            command.Parameters.Add("ngaysinh", OracleDbType.Date).Value = pp.NGAYSINH;
            command.Parameters.Add("ngaycapcmnd", OracleDbType.Date).Value = pp.NGAYCAPCMND;
            command.CommandType = CommandType.Text;

            int result = command.ExecuteNonQuery();

            return result;
        }
    }
}
