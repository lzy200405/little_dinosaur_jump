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
using Model;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace little_dinosaur_jump
{
    public partial class DinosaurJump : Form
    {
        UserScoreBLL userscorebll=new UserScoreBLL();
        StoreBLL storebll=new StoreBLL();

        private Dinosaur dinosaur;
        private int dinosaurnum;
        private Cactus cactus;
        private int score;
        public string username;

        private Timer gameTimer;
        
        private Image backgroundImage;
        private int backgroundX;
        private int backgroundY;

        private Image gamerover;
        private Image restart;

        private bool isGameOver;
        private bool isPaused;

        private SoundPlayer backgroundPlayer;
        private bool isBackgroundMusicPlaying; // 标志位
        public DinosaurJump()
        {
            InitializeComponent();

            InitializeBackgroundMusic();
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

        // 加载背景音乐文件
        private void InitializeBackgroundMusic()
        {

            // 检查资源文件是否存在
            if (Properties.Resources.background_music != null)
            {
                // 初始化SoundPlayer


                // 加载背景音乐
                string musicPath = @"C:\Users\11484\OneDrive\Desktop\little_dinosaur_jump-master2\little_dinosaur_jump-master\background_music.wav"; // 替换为你的背景音乐文件路径
                backgroundPlayer = new SoundPlayer(musicPath);

            }

        }
        private void StartMusic()
        {
                if (!isBackgroundMusicPlaying)
                { 
                    backgroundPlayer.PlayLooping();
                    isBackgroundMusicPlaying=true;
                }
        }

        private void EndMusic()
        {
            if (isBackgroundMusicPlaying)
            {
                    backgroundPlayer.Stop();
                    isBackgroundMusicPlaying = false;
            }
        }
        public DinosaurJump(string username)
        {
            this.username = username;

            InitializeComponent();
            InitializeBackgroundMusic();
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
            isBackgroundMusicPlaying = false;

            score = 0;


            提示.Visible = true;

            ScoreText.Text = "0";
        }
        #endregion


        private void Form2_Load(object sender, EventArgs e)
        {
        }

       

        //游戏初始提示
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

            if (!isPaused)
            {
                StartMusic();
            }

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

        //暂停游戏
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
                EndMusic();
            }
            else
            {
                gameTimer.Start(); // 启动游戏计时器
            }
        }

        //点击主页面继续游戏
        private void MainForm_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                // 关闭菜单并继续游戏
                isPaused = false;
                gameTimer.Start();
            }
        }

        //游戏进行时是跳跃
        //游戏结束时是重新开始
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
            EndMusic(); // 游戏结束时停止背景音乐
            Score newscore = new Score();
            newscore.User_name = username;
            newscore.Score1=Convert.ToInt32(ScoreText.Text);
            DialogResult result = MessageBox.Show("游戏结束。是否选择复活？","", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                if(storebll.UseCoin(username))
                {
                    cactus.reset();
                    isGameOver=false;
                    gameTimer.Start();
                    StartMusic(); // 复活时重新播放背景音乐
                }
                else
                {
                    MessageBox.Show("复活币数量不足", "提示",MessageBoxButtons.OK);
                }
            }
            else 
            {
                EndMusic();
                userscorebll.UpdateScore(newscore); //更新分数
                storebll.GetMoney(username, newscore.Score1);//分数转积分
            }
            

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
            Store store =new Store(this,username);
            store.Show();
        }

        private void 排行榜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Rank rank = new Rank(this);
            rank.Show();
        }


        #endregion

        //退出游戏
        private void DinosaurJump_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
