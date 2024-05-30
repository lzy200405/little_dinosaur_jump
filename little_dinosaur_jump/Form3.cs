using Common;
using little_dinosaur_jump.BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace little_dinosaur_jump
{
    public partial class Form3 : Form
    {
        LoginBLL loginBll = new LoginBLL();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbx_username.Text;
            string password = tbx_password1.Text;
            string password_again = tbx_password2.Text;
            string md5Password1 = Md5Helper.GetMd5(password);
            string md5Password2 = Md5Helper.GetMd5(password_again);
            Login login = new Login();
            login.User_name = username;
            login.Password = md5Password1;
            if (loginBll.QueryLoginInfo(username))
            {
                MessageBox.Show("用户名已存在!请重新输入！", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (md5Password1 != md5Password2)
            {
                MessageBox.Show("两次密码不相同！请检查你的密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                loginBll.RegistLoginfo(login);
                MessageBox.Show("注册成功！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
