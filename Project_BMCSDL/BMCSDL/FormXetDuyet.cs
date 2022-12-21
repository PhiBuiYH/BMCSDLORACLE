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
    public partial class FormXetDuyet : Form
    {
        private BLLDuyet BLLDuyet = new BLLDuyet();

        public FormXetDuyet()
        {
            InitializeComponent();
        }
        My_DB mydb=new My_DB();
        private void FormXetDuyet_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = BLLDuyet.GetDataIntoDGV();

            dataGridViewPassPort.DataSource = table;
            mydb.closeConnectionNV();
            if (textBoxHoten.Text == "")
            {
                buttonDuyet.Enabled = false;
                buttonKhongDuyet.Enabled = false;
            }
            dataGridViewPassPort.Columns[0].HeaderText = "Họ Tên";
            dataGridViewPassPort.Columns[1].HeaderText = "Ngày sinh";
            dataGridViewPassPort.Columns[2].HeaderText = "Địa chỉ";
            dataGridViewPassPort.Columns[3].HeaderText = "Giới tính";
            dataGridViewPassPort.Columns[4].HeaderText = "CMND";
            dataGridViewPassPort.Columns[5].HeaderText = "Ngày cấp";
            dataGridViewPassPort.Columns[6].HeaderText = "Điện thoại";
            dataGridViewPassPort.Columns[7].HeaderText = "Email";
            
            

            //Tên Nhân viên
            DataTable tableAccountName = new DataTable();
            tableAccountName = BLLDuyet.GetAccountName();
            if (tableAccountName.Rows.Count > 0)
            {
                labelTenNV.Text = "Xin chào " + tableAccountName.Rows[0]["HOTEN"].ToString().Trim() + "";
            }

        }

        private void dataGridViewPassPort_Click(object sender, EventArgs e)
        {
            textBoxHoten.Text = dataGridViewPassPort.CurrentRow.Cells[0].Value.ToString();
            dateTimeNgaySinh.Value = (DateTime)dataGridViewPassPort.CurrentRow.Cells[1].Value;
            textBoxDiachi.Text = dataGridViewPassPort.CurrentRow.Cells[2].Value.ToString();
            string gender = dataGridViewPassPort.CurrentRow.Cells[3].Value.ToString();
            if (gender == "Nam")
            {
                radioButtonNam.Checked = true;
            }
            else
            {
                radioButtonNu.Checked = true;
            }
            textBoxCMND.Text = dataGridViewPassPort.CurrentRow.Cells[4].Value.ToString();
            dateTimeNgayCap.Value= (DateTime)dataGridViewPassPort.CurrentRow.Cells[5].Value;
            textBoxDIenthoai.Text = dataGridViewPassPort.CurrentRow.Cells[6].Value.ToString();
            textBoxEmail.Text = dataGridViewPassPort.CurrentRow.Cells[7].Value.ToString();
            buttonDuyet.Enabled = true;
            buttonKhongDuyet.Enabled = true;
        }

        private void buttonDuyet_Click(object sender, EventArgs e)
        {
            
            if (BLLDuyet.UpdateTTDuyet1(textBoxCMND.Text) == 1)
            {
                mydb.closeConnectionNV();
                MessageBox.Show("Xét duyệt thành công", "Xét duyệt PASSPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FormXetDuyet_Load(sender, e);
                dataGridViewPassPort.Update();
                dataGridViewPassPort.Refresh();
                textBoxCMND.Text = "";
                textBoxDiachi.Text = "";
                textBoxDIenthoai.Text = "";
                textBoxEmail.Text = "";
                textBoxHoten.Text = "";

            }
            else
            {
                mydb.closeConnectionNV();
                MessageBox.Show("Xét duyệt ko thành công");
            }
        }

        private void buttonKhongDuyet_Click(object sender, EventArgs e)
        {
            
            if (BLLDuyet.UpdateTTDuyet2(textBoxCMND.Text) == 1)
            {
                mydb.closeConnectionNV();
                MessageBox.Show("Xét duyệt loại bỏ thành công", "Xét duyệt PASSPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FormXetDuyet_Load(sender, e);
                dataGridViewPassPort.Update();
                dataGridViewPassPort.Refresh();

            }
            else
            {
                mydb.closeConnectionNV();
                MessageBox.Show("Xét duyệt ko thành công");
            }
        }
    }
}
