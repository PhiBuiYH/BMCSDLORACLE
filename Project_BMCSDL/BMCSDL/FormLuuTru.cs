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
    public partial class FormLuuTru : Form
    {
        private BLLLuuTru BLLLuuTru = new BLLLuuTru();

        public FormLuuTru()
        {
            InitializeComponent();
        }
        My_DB mydb=new My_DB();
        private void FormLuuTru_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = BLLLuuTru.GetDataIntoDGV();

            dataGridViewPassPort.DataSource = table;
            if (textBoxHoten.Text == "")
            {
                buttonGuiTT.Enabled = false;
               
            }
            dataGridViewPassPort.Columns[0].HeaderText = "Mã hồ sơ";
            dataGridViewPassPort.Columns[1].HeaderText = "Tình trạng xác thực";
            dataGridViewPassPort.Columns[2].HeaderText = "Tình trạng xét duyệt";

            //Ten NV
            DataTable tableAccountName = new DataTable();
            tableAccountName = BLLLuuTru.GetAccountName();
            if (tableAccountName.Rows.Count > 0)
            {

                labelTenNV.Text = "Xin chào " + tableAccountName.Rows[0]["HOTEN"].ToString().Trim() + "";
            }

        }

        private void dataGridViewPassPort_Click(object sender, EventArgs e)
        {
            textBoxHoten.Text = dataGridViewPassPort.CurrentRow.Cells[0].Value.ToString();
            buttonGuiTT.Enabled = true;
            
        }

        private void buttonGuiTT_Click(object sender, EventArgs e)
        {
            
            if (BLLLuuTru.UpdateTTThongBao(textBoxHoten.Text) == 1)
            {
                mydb.closeConnectionNV();
                MessageBox.Show("Gửi thông báo thành công", "Thông báo được duyệt PASSPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FormLuuTru_Load(sender, e);
                dataGridViewPassPort.Update();
                dataGridViewPassPort.Refresh();
            }
            else
            {
                mydb.closeConnectionNV();
                MessageBox.Show("Gửi thông báo ko thành công");
            }
        }
    }
}
