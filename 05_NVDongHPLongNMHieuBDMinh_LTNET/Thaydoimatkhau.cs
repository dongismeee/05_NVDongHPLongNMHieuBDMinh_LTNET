using Nhom5_QuanLyNhanSu.DataAccess;
using Nhom5_QuanLyNhanSu.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_NVDongHPLongNMHieuBDMinh_LTNET
{
    public partial class Thaydoimatkhau : Form
    {

        public static string mnv_update;
        public Thaydoimatkhau()
        {
            InitializeComponent();
        }
        TaiKhoanDAL dal = new TaiKhoanDAL();
        TaiKhoan tk = new TaiKhoan();
        private void Thaydoimatkhau_Load(object sender, EventArgs e)
        {
            mnv_update = Form1.mnv;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMatKhau_Cu.Text != "" && txtPassword.Text != "" && txtNhapLai_Password.Text != "")
            {
                if (dal.KiemTra(mnv_update, txtMatKhau_Cu.Text))
                {
                    if (txtPassword.Text.Equals(txtNhapLai_Password.Text))
                    {
                        dal.Update(mnv_update, txtPassword.Text);
                        MessageBox.Show("Đổi mật khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu nhập không khớp");
                    }

                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtMatKhau_Cu.UseSystemPasswordChar = false;
                txtPassword.UseSystemPasswordChar = false;
                txtNhapLai_Password.UseSystemPasswordChar = false;
            } 
            else
                txtMatKhau_Cu.UseSystemPasswordChar = true;
                txtPassword.UseSystemPasswordChar = true;
                txtNhapLai_Password.UseSystemPasswordChar = true;
        }
    }
}
