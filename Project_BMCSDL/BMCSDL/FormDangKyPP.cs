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
using BMCSDL.DTO;

namespace BMCSDL
{
    public partial class FormDangKyPP : Form
    {
        BLLDangKyPP BLLDangKyPP = new BLLDangKyPP();
        PASSPORTDATA PASSPORTDATA = new PASSPORTDATA();
        My_DB mydb = new My_DB();
        public FormDangKyPP()
        {
            InitializeComponent();
        }

        private void buttonDangky_Click(object sender, EventArgs e)
        {
            string gender = "Nam";
            if (radioButtonNu.Checked)
            {
                gender = "Nữ";
            }
            mydb.openConnection();

            PASSPORTDATA.HOTEN = textBoxHoten.Text;
            PASSPORTDATA.DIACHI = textBoxDiachi.Text;
            PASSPORTDATA.PHAI = gender;
            PASSPORTDATA.CMND = textBoxCMND.Text;
            PASSPORTDATA.DIENTHOAI = textBoxDienthoai.Text;
            PASSPORTDATA.EMAIL = textBoxEmail.Text;
            PASSPORTDATA.TTXACTHUC = "Chưa xác thực";
            PASSPORTDATA.TTXETDUYET = "Chưa duyệt";
            PASSPORTDATA.TTTHONGBAO = "Chưa thông báo";
            PASSPORTDATA.NGAYSINH = dateTimeNgaySinh.Value;
            PASSPORTDATA.NGAYCAPCMND = dateTimeNgayCap.Value;         

            if (BLLDangKyPP.DangKy(PASSPORTDATA) == 1)
            {
                mydb.closeConnection();
                MessageBox.Show("Thông tin của bạn đã được gửi, vui lòng chờ phản hồi sau 5 - 7 ngày", "Đăng ký cung cấp PassPort", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
               
            }
            else
            {
                mydb.closeConnection();
                MessageBox.Show("Gửi thông tin không thành công");
            }
            

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
