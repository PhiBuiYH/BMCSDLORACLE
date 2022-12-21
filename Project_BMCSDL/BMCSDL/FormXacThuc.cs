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
    public partial class FormXacThuc : Form
    {
        private BLLXacThuc BLLXacThuc = new BLLXacThuc();

        public FormXacThuc()
        {
            InitializeComponent();
        }
        My_DB mydb=new My_DB();
        private void FormXacThuc_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = BLLXacThuc.GetDataIntoDGV();
            dataGridViewPassPort.DataSource = table;
            
            if (textBoxHoten.Text == "")
            {
                buttonXT.Enabled = false;
                buttonKhongXT.Enabled = false;

            }
            dataGridViewPassPort.Columns[0].HeaderText = "Họ Tên";
            dataGridViewPassPort.Columns[1].HeaderText = "Ngày sinh";
            dataGridViewPassPort.Columns[2].HeaderText = "Địa chỉ";
            dataGridViewPassPort.Columns[3].HeaderText = "Giới tính";
            dataGridViewPassPort.Columns[4].HeaderText = "CMND";
            dataGridViewPassPort.Columns[5].HeaderText = "Ngày cấp";
            dataGridViewPassPort.Columns[6].HeaderText = "Điện thoại";
            dataGridViewPassPort.Columns[7].HeaderText = "Email";
            
            //label tên nhân viên
            DataTable tableAccountName = new DataTable();
            tableAccountName = BLLXacThuc.GetAccountName();

            if (tableAccountName.Rows.Count > 0)
            {   
                labelTenNV.Text = "Xin chào " + tableAccountName.Rows[0]["HOTEN"].ToString().Trim() +"";
            }
        }

        private void dataGridViewPassPort_Click(object sender, EventArgs e)
        {
            textBoxHoten.Text =dataGridViewPassPort.CurrentRow.Cells[0].Value.ToString();
            dateTimeNgaySinh.Value= (DateTime)dataGridViewPassPort.CurrentRow.Cells[1].Value;
            textBoxDiachi.Text= dataGridViewPassPort.CurrentRow.Cells[2].Value.ToString();
            string gender = dataGridViewPassPort.CurrentRow.Cells[3].Value.ToString();
            if (gender == "Nam")
            {
                radioButtonNam.Checked = true;
            }
            else
            {
                radioButtonNu.Checked = true;
            }
            textBoxCMND.Text= dataGridViewPassPort.CurrentRow.Cells[4].Value.ToString();
            dateTimeNgayCap.Value = (DateTime)dataGridViewPassPort.CurrentRow.Cells[5].Value;
            textBoxDIenthoai.Text= dataGridViewPassPort.CurrentRow.Cells[6].Value.ToString();
            textBoxEmail.Text = dataGridViewPassPort.CurrentRow.Cells[7].Value.ToString();
            buttonXT.Enabled = true;
            buttonKhongXT.Enabled = true;
        }

        private void buttonTraTT_Click(object sender, EventArgs e)
        {
            FormTraThongTin frmTraThongTin=new FormTraThongTin();
            frmTraThongTin.ShowDialog();
        }

        private void buttonXT_Click(object sender, EventArgs e)
        {
            if (BLLXacThuc.UpdateTTXacThuc1(textBoxCMND.Text) == 1)
            {
                mydb.closeConnectionNV();
                MessageBox.Show("Cập nhật thành công", "Xác thực PASSPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FormXacThuc_Load(sender, e);
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
            }
        }

        //private void buttonKhongXT_Click(object sender, EventArgs e)
        //{

        //    OracleCommand command = new OracleCommand("update PASSPORTDATA set TTXACTHUC = :xacthuc", mydb.getConnectionNV());
        //    command.Parameters.Add("xacthuc", OracleDbType.NVarchar2, 50).Value = "Không duyệt";
        //    mydb.openConnectionNV();
        //    if ((command.ExecuteNonQuery() == 1))
        //    {
        //        mydb.closeConnectionNV();
        //        MessageBox.Show("Cập nhật thành công", "Xác thực PASSPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        this.FormXacThuc_Load(sender, e);

        //    }
        //    else
        //    {
        //        mydb.closeConnectionNV();

        //    }
        //}

        private void buttonKhongXT_Click_1(object sender, EventArgs e)
        {          
            if (BLLXacThuc.UpdateTTXacThuc2(textBoxCMND.Text) == 1)
            {
                mydb.closeConnectionNV();
                MessageBox.Show("Cập nhật thành công", "Không xác thực PASSPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FormXacThuc_Load(sender, e);
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

            }
        }
    }
}
