using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace little_dinosaur_jump
{
    public class Cactus
    {
        public int X { get; set; }
        public int Y { get; set; }
        private Image cactusImage;
        private Rectangle[] spriteRects;
        private int currentFrame;   // 当前图片
        private int totalFrames;    //总帧率数




        public Cactus()
        {
            X = 600;
            Y = 125; // 根据地面高度调整
    
            cactusImage = Properties.Resources.小仙人掌;// 确保图像已添加到资源中

            
            spriteRects = new Rectangle[]
            {
                new Rectangle(0, 0, 35, 72),    
                new Rectangle(37, 0, 70, 72),  
                new Rectangle(108, 0, 103, 72),  
                new Rectangle(0,0,100,20)
            };

            totalFrames = spriteRects.Length;
            currentFrame = 0;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(cactusImage, new Rectangle(X, Y, spriteRects[currentFrame].Width, spriteRects[currentFrame].Height), spriteRects[currentFrame], GraphicsUnit.Pixel);
            //g.DrawImage(backgroundImage, new Rectangle(backgroundX, backgroundY, spriteRects[3].Width, spriteRects[3].Height), spriteRects[3], GraphicsUnit.Pixel);
        }

        public void Update()
        {
            
            X -= 20; // 向左移动仙人掌
            if (X < -spriteRects[currentFrame].Width)
            {
                X = 800; //重置到右边缘
                Random random = new Random();
                currentFrame = random.Next() % 3;
            }
        }

        public Rectangle GetBounds()
        {
            return new Rectangle(X, Y, spriteRects[currentFrame].Width, spriteRects[currentFrame].Height);
        }


    }
}
