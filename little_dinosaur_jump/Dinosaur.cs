using little_dinosaur_jump.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace little_dinosaur_jump
{
    public class Dinosaur
    {
        public int X { get; set; }
        public int Y { get; set; }
        private Image dinosaurImage;
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
            dinosaurImage = Properties.Resources.dino;
            // 确保图像已添加到资源中// 精灵图中恐龙图像的坐标和大小
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

        public void Draw(Graphics g)
        {
            g.DrawImage(dinosaurImage, new Rectangle(X, Y, spriteRects[currentFrame].Width, spriteRects[currentFrame].Height), spriteRects[currentFrame], GraphicsUnit.Pixel);
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

        public Rectangle GetBounds()
        {
            return new Rectangle(X, Y, spriteRects[currentFrame].Width, spriteRects[currentFrame].Height);
        }
    }
}

