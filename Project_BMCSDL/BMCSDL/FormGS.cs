using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BMCSDL.BLL;

namespace BMCSDL
{
    public partial class FormGS : Form
    {
        private BLLGiamSat BLLGiamSat = new BLLGiamSat();

        public FormGS()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        private void FormGS_Load(object sender, EventArgs e)
        {
            // datagrid bộ phận xác thực
            DataTable tableXT = new DataTable();
            tableXT = BLLGiamSat.GetDataIntoDGVXT();
            dataGridViewXT.DataSource = tableXT;
            try
            {
                if(tableXT.Rows.Count > 0)
                {
                    for (int i = 1; i <= tableXT.Rows.Count; i++)
                    {
                        int id = Convert.ToInt16(tableXT.Rows[i-1][0].ToString());

                        DataTable tableAccountNameEachRow = new DataTable();
                        tableAccountNameEachRow = BLLGiamSat.GetAccountName(id);

                        dataGridViewXT.Rows[i-1].Cells[0].Value = tableAccountNameEachRow.Rows[0]["HOTEN"].ToString();
                        mydb.closeConnection();                  
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
             
            }
            mydb.closeConnection();
            dataGridViewXT.Columns[0].HeaderText = "Nhân viên";
            dataGridViewXT.Columns[1].HeaderText = "Mã hồ sơ";


            // datagrid bộ phận xét duyệt
            DataTable tableXD = new DataTable();
            tableXD = BLLGiamSat.GetDataIntoDGVXD();
            dataGridViewXD.DataSource = tableXD;
            try
            {
                if (tableXD.Rows.Count > 0)
                {
                    for (int i = 1; i <= tableXD.Rows.Count; i++)
                    {
                        int id = Convert.ToInt16(tableXD.Rows[i - 1][0].ToString());

                        DataTable tableAccountNameEachRow = new DataTable();
                        tableAccountNameEachRow = BLLGiamSat.GetAccountName(id);

                        dataGridViewXD.Rows[i - 1].Cells[0].Value = tableAccountNameEachRow.Rows[0]["HOTEN"].ToString();
                        mydb.closeConnection();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            mydb.closeConnection();
            dataGridViewXD.Columns[0].HeaderText = "Nhân viên";
            dataGridViewXD.Columns[1].HeaderText = "Mã hồ sơ";

            // datagrid bộ phận lưu trữ
            DataTable tableLT = new DataTable();
            tableLT = BLLGiamSat.GetDataIntoDGVLT();
            dataGridViewLT.DataSource = tableLT;
            try
            {
                if (tableLT.Rows.Count > 0)
                {
                    for (int i = 1; i <= tableLT.Rows.Count; i++)
                    {
                        int id = Convert.ToInt16(tableLT.Rows[i - 1][0].ToString());

                        DataTable tableAccountNameEachRow = new DataTable();
                        tableAccountNameEachRow = BLLGiamSat.GetAccountName(id);

                        dataGridViewLT.Rows[i - 1].Cells[0].Value = tableAccountNameEachRow.Rows[0]["HOTEN"].ToString();
                        mydb.closeConnection();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            mydb.closeConnection();
            dataGridViewLT.Columns[0].HeaderText = "Nhân viên";
            dataGridViewLT.Columns[1].HeaderText = "Mã hồ sơ";

            //Tên NV
            DataTable tableAccountName = new DataTable();
            tableAccountName = BLLGiamSat.GetAccountName(-1);
            if (tableAccountName.Rows.Count > 0)
            {

                labelTenNV.Text = "Xin chào " + tableAccountName.Rows[0]["HOTEN"].ToString().Trim() + "";
            }
        }

        private void dataGridViewXT_DoubleClick(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataGridViewXT.CurrentRow.Cells[1].Value.ToString());
            FormThongTinPassPort frmTTPP= new FormThongTinPassPort();

            DataTable table = new DataTable();
            table = BLLGiamSat.DoubleClickDGV(id);

            frmTTPP.dataGridViewPP.DataSource = table;
            frmTTPP.ShowDialog();
        }

        private void dataGridViewXD_DoubleClick(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataGridViewXD.CurrentRow.Cells[1].Value.ToString());
            FormThongTinPassPort frmTTPP = new FormThongTinPassPort();

            DataTable table = new DataTable();
            table = BLLGiamSat.DoubleClickDGV(id);

            frmTTPP.dataGridViewPP.DataSource = table;
            frmTTPP.ShowDialog();
        }

        private void dataGridViewLT_DoubleClick(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataGridViewLT.CurrentRow.Cells[1].Value.ToString());
            FormThongTinPassPort frmTTPP = new FormThongTinPassPort();

            DataTable table = new DataTable();
            table = BLLGiamSat.DoubleClickDGV(id);

            frmTTPP.dataGridViewPP.DataSource = table;
            frmTTPP.ShowDialog();
        }
    }
}
