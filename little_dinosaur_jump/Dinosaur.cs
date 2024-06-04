using little_dinosaur_jump.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace little_dinosaur_jump
{
    public class Dinosaur
    {
        public int X { get; set; }
        public int Y { get; set; }
        private Image[] dinosaurImage;
        private Rectangle[] spriteRects;
        private int currentFrame;   // 当前图片
        private int totalFrames;    //总帧率数
        private int jumpHeight;
        private int jumpSpeed;
        private int gravity;
        private bool isJumping;


        public Dinosaur()
        {
            X = 50;
            Y = 150; // 根据地面高度调整

            // 初始化数组
            dinosaurImage = new Image[4];

            dinosaurImage[0] = Properties.Resources.dino;            //恐龙

            dinosaurImage[1]= Properties.Resources.pikachu_cours;   //皮卡丘

            dinosaurImage[2] = Properties.Resources.naruto_run;     //漩涡鸣人
            
            ImageAnimator.Animate(dinosaurImage[1], OnFrameChanged);
            ImageAnimator.Animate(dinosaurImage[2], OnFrameChanged);


            // 精灵图中恐龙图像的坐标和大小
            spriteRects = new Rectangle[]
            {
            new Rectangle(0, 0, 44, 47),    // 第一帧
            new Rectangle(88, 0, 44, 47),   // 第二帧
            new Rectangle(132, 0, 44, 47),  // 第三帧
            };


            jumpHeight = 0;
            jumpSpeed = 50;
            gravity = 10;
            totalFrames = spriteRects.Length;
            currentFrame = 0;
            isJumping = false;
        }




        public void Draw(Graphics g, int i)
        {
            switch (i)
            {
                case 0:
                    g.DrawImage(dinosaurImage[i], new Rectangle(X, Y, spriteRects[currentFrame].Width, spriteRects[currentFrame].Height), spriteRects[currentFrame], GraphicsUnit.Pixel);
                    break;
                case 1:
                    ImageAnimator.UpdateFrames(dinosaurImage[i]);
                    g.DrawImage(dinosaurImage[i], X, Y);
                    break;
                case 2:
                    ImageAnimator.UpdateFrames(dinosaurImage[i]);
                    g.DrawImage(dinosaurImage[i], X, Y);
                    break;
            }
        }
            

        public void Jump()// 实现跳跃逻辑
        {
            if (!isJumping)
            {
                isJumping = true;
            }
        }


        internal void Update()  //实现动画的更新
        {
            int tempY = Y;
            if (isJumping)
            {
                Y -= jumpSpeed;
                jumpHeight += jumpSpeed;
                jumpSpeed -= gravity;
                if(jumpHeight < 0)
                {
                    isJumping=false;
                    jumpHeight = 0;
                    jumpSpeed = 50;
                    Y = tempY;
                }
            }
            currentFrame++;
            if (currentFrame >= totalFrames)
            {
                currentFrame = 0;
            }
        }

        private void OnFrameChanged(object sender, EventArgs e)
        {
            // 强制重绘以显示下一帧
            if (Form.ActiveForm != null)
            {
                Form.ActiveForm.Invalidate();
            }
        }

        public Rectangle GetBounds()
        {
            return new Rectangle(X, Y, spriteRects[currentFrame].Width, spriteRects[currentFrame].Height);
        }
    }
}

