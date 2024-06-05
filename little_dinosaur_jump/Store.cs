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

namespace little_dinosaur_jump
{
   
    public partial class Store : Form

    {
        private StoreBLL storeBLL=new StoreBLL();
        private DinosaurJump dj;
        private string username;

        public Store()
        {            
            InitializeComponent();
        }

        public Store(DinosaurJump currentdj,string username) 
        {
            InitializeComponent();
            dj= currentdj;
            this.username = username;
            YourMoney_Textload(username);
            YourCoin_Textload(username);
        }



        private void Store_FormClosing(object sender, FormClosingEventArgs e)
        {
            dj.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(numtextbox.Text);
            if(storeBLL.BuyCoin(username,num))
            {
                MessageBox.Show("购买成功","提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("购买失败，余额不足!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            YourCoin_Textload(username);
            YourMoney_Textload(username);
        }

        private void YourMoney_Textload(string username)
        {
            int money;
            money=storeBLL.QueryMoney(username);
            YourMoney.Text = $"你的积分余额:{money}";
        }

        private void YourCoin_Textload(string username)
        {
            int coin;
            coin = storeBLL.QueryCoin(username);
            YourCoins.Text = $"你的复活币数量:{coin}";
        }
    }
}
