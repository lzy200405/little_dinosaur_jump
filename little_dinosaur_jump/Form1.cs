using little_dinosaur_jump.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace little_dinosaur_jump
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private LoginBLL loginBll = new LoginBLL();

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbx_username.Text;
            string password = tbx_password.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("请输入用户名和密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string md5Password = Md5Helper.GetMd5(password);
            if (loginBll.QueryLoginInfo(username, md5Password))
            {
                Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
