using CSDL.EF;
using CSDL.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string us = tbUser.Text;
            string pw = tbPass.Text;
            F_DangNhap fdn = new F_DangNhap();
            var result = fdn.GetSingleByCondition(x => x.TaiKhoan == us && x.MatKhau == pw ) ?? new DangNhap();
            if (result.ID != 0)
            {
                this.Hide();
                MainForm mf = new MainForm();
                mf.ShowDialog();
                this.Show();
            }
            else
            {
                lbMsg.Text = "Đăng nhập không thành công";
                lbMsg.Visible = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
