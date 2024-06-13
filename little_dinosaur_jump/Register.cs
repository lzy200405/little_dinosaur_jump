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
    public partial class Register : Form
    {
        LoginBLL loginBll = new LoginBLL();
        public Register()
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
            Model.Login login = new Model.Login();
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
        private void Register_Load(object sender, EventArgs e)
        {
            string imagePath = @"C:\Users\11484\OneDrive\Desktop\little_dinosaur_jump-master2\little_dinosaur_jump-master\login.jpg"; // 用实际的文件路径替换这里的路径

            Image backgroundImage = Image.FromFile(imagePath);

            // 设置窗体背景图片并调整布局
            this.BackgroundImage = backgroundImage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
