using Nhom5_QuanLyNhanSu.Business;
using Nhom5_QuanLyNhanSu.DataAccess;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _05_NVDongHPLongNMHieuBDMinh_LTNET
{
    public partial class Form1 : Form
    {
        static int count = 0;
        public static bool kt;
        public static bool ktq;
        public static string mnv;
        public Form1()
        {
            InitializeComponent();
        }
        TaiKhoanDAL dal = new TaiKhoanDAL();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            kt = false;
            if (txtNhanVien.Text != "" && txtPassword.Text != "")
            {
                if (dal.KiemTra(txtNhanVien.Text, txtPassword.Text))
                {
                    kt = true;
                    if(dal.KiemTraQuyen(txtNhanVien.Text, txtPassword.Text))
                    {
                        ktq = true;
                        MessageBox.Show("Đăng Nhập Thành Công - ADMIN", "Thông báo");
                        {
                            mnv = txtNhanVien.Text;
                            this.Hide();
                        }
                    }
                    else
                    {
                        ktq = false;
                        MessageBox.Show("Đăng Nhập Thành Công - USER", "Thông báo");
                        {
                            mnv = txtNhanVien.Text;
                            this.Hide();
                            Menu menu = new Menu();
                            menu.Show();
                            //Thaydoimatkhau tdmk = new Thaydoimatkhau();
                            //tdmk.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo");
                    txtNhanVien.Focus();
                    count = count + 1;
                    if (count >= 3)
                    {
                        btnDangNhap.Enabled = false;
                        MessageBox.Show("Không được nhập quá 3 lần", "Thông báo");
                    }

                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
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
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }
    }
}