﻿using little_dinosaur_jump.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace little_dinosaur_jump
{
    public partial class DinosaurJump : Form
    {
        UserScoreBLL userscorebll=new UserScoreBLL();

        private Dinosaur dinosaur;
        private int dinosaurnum;
        private Cactus cactus;
        private int score;
        private string username;

        private Timer gameTimer;
        
        private Image backgroundImage;
        private int backgroundX;
        private int backgroundY;

        private Image gamerover;
        private Image restart;

        private bool isGameOver;
        private bool isPaused;

        public DinosaurJump()
        {
            InitializeComponent();
            InitGame();
            this.DoubleBuffered = true;

            backgroundImage = Properties.Resources.BackgroundImageLight; // 替换为你的背景图像资源名称
            backgroundX = 0;
            backgroundY = 200; // 设置背景图片的初始Y坐标
            dinosaurnum = 0;    //设置初始小恐龙图片

            gamerover = Properties.Resources.gameover;
            restart = Properties.Resources.restart;


            // 绑定菜单项点击事件为游戏停止
            菜单.Click += GamePause;

        }

        #region  游戏初始化
        private void InitGame()
        {
            gameTimer = new Timer();
            gameTimer.Interval = 50; // 设置动画帧切换间隔时间（毫秒）
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Stop();


            dinosaur = new Dinosaur();
            cactus = new Cactus();


            backgroundX = 0;
            backgroundY = 200; // 设置背景图片的初始Y坐标
            isPaused = true;
            isGameOver = false;

            score = 0;


            提示.Visible = true;

            ScoreText.Text = "0";
        }
        #endregion

        public DinosaurJump(string username)
        {
            this.username = username;

            InitializeComponent();
            InitGame();
            this.DoubleBuffered = true;

            backgroundImage = Properties.Resources.BackgroundImageLight; // 替换为你的背景图像资源名称
            backgroundX = 0;
            backgroundY = 200; // 设置背景图片的初始Y坐标
            dinosaurnum = 0;    //设置初始小恐龙图片

            gamerover = Properties.Resources.gameover;
            restart = Properties.Resources.restart;


            // 绑定菜单项点击事件为游戏停止
            菜单.Click += GamePause;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

       


        private void 提示_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                提示.Visible = false;
                isPaused = false;
                gameTimer.Start();
            }
        }


        #region 界面绘制

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

        private void UpdateBackground()             //更新背景
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

            dinosaur.Draw(e.Graphics,dinosaurnum);
            cactus.Draw(e.Graphics);
            
            // 绘制背景
            if ((backgroundX + backgroundImage.Width) >= this.Width)
            {
                backgroundX -= 20;
                e.Graphics.DrawImage(backgroundImage, backgroundX - 20, backgroundY, backgroundImage.Width, backgroundImage.Height);
            }
            else { backgroundX = 0; }


            if (isGameOver)
            {
                e.Graphics.DrawImage(gamerover, this.Width / 2 - 180, 50, gamerover.Width, gamerover.Height);
                e.Graphics.DrawImage(restart, this.Width / 2 - 40, 300, restart.Width, restart.Height);
            }

            //分数显示
            else
            {
                if (!isPaused)
                {
                    score++;
                    if (score == 5)
                    {
                        int temp = Convert.ToInt32(ScoreText.Text);
                        temp++;
                        ScoreText.Text = temp.ToString(); // 更新文本框显示的分数
                        score = 0;
                    }

                }
            }
        }

        #endregion


        private void GamePause(object sender, EventArgs e)
        {
            // 切换暂停状态
            if (!isPaused)
            {
                isPaused = true;
            }

            if (isPaused)
            {
                gameTimer.Stop(); // 停止游戏计时器
            }
            else
            {
                gameTimer.Start(); // 启动游戏计时器
            }
        }


        private void MainForm_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                // 关闭菜单并继续游戏
                isPaused = false;
                gameTimer.Start();
            }
        }


        protected override void OnKeyDown(KeyEventArgs e) //触发按键
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Space)
            {
                if (!isPaused)
                {
                    dinosaur.Jump();
                }
                if(isGameOver)
                {
                    InitGame();
                }
            }
        }

        #region  碰撞判断

        private bool CheckCollision()
        {
            return dinosaur.GetBounds().IntersectsWith(cactus.GetBounds());
        }
        #endregion


        #region gameover
        /// <summary>
        /// 游戏结束
        /// </summary>
        private void GameOver()
        {
            gameTimer.Stop();
            isGameOver = true;
            Score newscore = new Score();
            newscore.User_name = username;
            newscore.Score1=Convert.ToInt32(ScoreText.Text);
            userscorebll.UpdateScore(newscore);

        }
        #endregion


        #region restart
        /// <summary>
        /// 重新开始游戏
        /// </summary>
        private void RestartGame()
        {
            InitGame();
        }
        #endregion


        #region 角色切换
        private void 原生小恐龙ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dinosaurnum = 0;
            InitGame();
        }

        private void 皮卡丘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dinosaurnum = 1;
            InitGame();
        }

        private void 旋涡鸣人ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dinosaurnum = 2;
            InitGame();
        }
        #endregion


        #region 界面切换
        private void 商店ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Store store =new Store(this);
            store.Show();
        }

        private void 排行榜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Rank rank = new Rank(this);
            rank.Show();
        }


        #endregion

        private void DinosaurJump_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
