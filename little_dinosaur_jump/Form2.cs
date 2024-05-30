using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace little_dinosaur_jump
{
    public partial class Form2 : Form
    {
     
        private Dinosaur dinosaur;
        private Cactus cactus;
        private Timer gameTimer;
        private bool isGameOver;
        private Image backgroundImage;
        private int backgroundX;
        private int backgroundY;

        public Form2()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            InitGame();

            gameTimer = new Timer();
            gameTimer.Interval = 50; // 设置动画帧切换间隔时间（毫秒）
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
            isGameOver = false;
            backgroundImage = Properties.Resources.BackgroundImage; // 替换为你的背景图像资源名称
            backgroundX = 0;
            backgroundY = 200; // 设置背景图片的初始Y坐标
        }
        private void InitGame()
        {
            dinosaur = new Dinosaur();
            cactus = new Cactus();
            backgroundX = 0;
            backgroundY = 200; // 设置背景图片的初始Y坐标
        }

        private void GameTimer_Tick(object sender, EventArgs e)//更新界面
        {
            cactus.Update();
            dinosaur.Update(); // 更新恐龙的当前帧
            UpdateBackground(); // 更新背景位置
            this.Invalidate(); // 触发 Paint 事件
            if (CheckCollision())
            {
                GameOver();
            }
            this.Invalidate(); // 触发 Paint 事件
        }

        private void UpdateBackground()
        {
            backgroundX -= 5; // 背景移动速度
            if (backgroundX <= -this.Width)
            {
                backgroundX = 0; // 重置背景位置
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // 绘制背景
            for (int i = 0; i <= 1; i++)
            {
                e.Graphics.DrawImage(backgroundImage, backgroundX + i * this.Width, backgroundY, this.Width, backgroundImage.Height);
            }
            if (!isGameOver)
            {
                dinosaur.Draw(e.Graphics);
                cactus.Draw(e.Graphics);
            }

        }

        protected override void OnKeyDown(KeyEventArgs e) //触发按键
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Space)
            {
                dinosaur.Jump();
            }
        }/// <summary>
        /// 碰撞判断
        /// </summary>
        /// <returns></returns>
        private bool CheckCollision()
        {
            return dinosaur.GetBounds().IntersectsWith(cactus.GetBounds());
        }

        /// <summary>
        /// 游戏结束
        /// </summary>
        private void GameOver()
        {
            gameTimer.Stop();
            var result = MessageBox.Show("是否重新开始游戏?", "Game Over", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {
                this.Close(); // 关闭应用程序
            }
        }
        /// <summary>
        /// 重新开始游戏
        /// </summary>
        private void RestartGame()
        {
            InitGame();
            gameTimer.Start();
        }

        /// <summary>
        /// 初始化游戏
        /// </summary>
     

    

    }
}
