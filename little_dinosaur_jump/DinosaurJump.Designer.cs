namespace little_dinosaur_jump
{
    partial class DinosaurJump
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单 = new System.Windows.Forms.ToolStripMenuItem();
            this.切换角色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.原生小恐龙ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.皮卡丘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.旋涡鸣人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商店ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.排行榜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.提示 = new System.Windows.Forms.TextBox();
            this.ScoreText = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1178, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单
            // 
            this.菜单.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.切换角色ToolStripMenuItem,
            this.商店ToolStripMenuItem,
            this.排行榜ToolStripMenuItem});
            this.菜单.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.菜单.Name = "菜单";
            this.菜单.Size = new System.Drawing.Size(87, 40);
            this.菜单.Text = "菜单";
            // 
            // 切换角色ToolStripMenuItem
            // 
            this.切换角色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.原生小恐龙ToolStripMenuItem,
            this.皮卡丘ToolStripMenuItem,
            this.旋涡鸣人ToolStripMenuItem});
            this.切换角色ToolStripMenuItem.Name = "切换角色ToolStripMenuItem";
            this.切换角色ToolStripMenuItem.Size = new System.Drawing.Size(232, 44);
            this.切换角色ToolStripMenuItem.Text = "切换角色";
            // 
            // 原生小恐龙ToolStripMenuItem
            // 
            this.原生小恐龙ToolStripMenuItem.Name = "原生小恐龙ToolStripMenuItem";
            this.原生小恐龙ToolStripMenuItem.Size = new System.Drawing.Size(260, 44);
            this.原生小恐龙ToolStripMenuItem.Text = "原生小恐龙";
            this.原生小恐龙ToolStripMenuItem.Click += new System.EventHandler(this.原生小恐龙ToolStripMenuItem_Click);
            // 
            // 皮卡丘ToolStripMenuItem
            // 
            this.皮卡丘ToolStripMenuItem.Name = "皮卡丘ToolStripMenuItem";
            this.皮卡丘ToolStripMenuItem.Size = new System.Drawing.Size(260, 44);
            this.皮卡丘ToolStripMenuItem.Text = "皮卡丘";
            this.皮卡丘ToolStripMenuItem.Click += new System.EventHandler(this.皮卡丘ToolStripMenuItem_Click);
            // 
            // 旋涡鸣人ToolStripMenuItem
            // 
            this.旋涡鸣人ToolStripMenuItem.Name = "旋涡鸣人ToolStripMenuItem";
            this.旋涡鸣人ToolStripMenuItem.Size = new System.Drawing.Size(260, 44);
            this.旋涡鸣人ToolStripMenuItem.Text = "旋涡鸣人";
            this.旋涡鸣人ToolStripMenuItem.Click += new System.EventHandler(this.旋涡鸣人ToolStripMenuItem_Click);
            // 
            // 商店ToolStripMenuItem
            // 
            this.商店ToolStripMenuItem.Name = "商店ToolStripMenuItem";
            this.商店ToolStripMenuItem.Size = new System.Drawing.Size(232, 44);
            this.商店ToolStripMenuItem.Text = "商店";
            this.商店ToolStripMenuItem.Click += new System.EventHandler(this.商店ToolStripMenuItem_Click);
            // 
            // 排行榜ToolStripMenuItem
            // 
            this.排行榜ToolStripMenuItem.Name = "排行榜ToolStripMenuItem";
            this.排行榜ToolStripMenuItem.Size = new System.Drawing.Size(232, 44);
            this.排行榜ToolStripMenuItem.Text = "排行榜";
            this.排行榜ToolStripMenuItem.Click += new System.EventHandler(this.排行榜ToolStripMenuItem_Click);
            // 
            // 提示
            // 
            this.提示.BackColor = System.Drawing.Color.White;
            this.提示.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.提示.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.提示.Location = new System.Drawing.Point(373, 498);
            this.提示.Name = "提示";
            this.提示.ReadOnly = true;
            this.提示.Size = new System.Drawing.Size(406, 32);
            this.提示.TabIndex = 1;
            this.提示.TabStop = false;
            this.提示.Text = "按空格开始游戏";
            this.提示.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScoreText
            // 
            this.ScoreText.BackColor = System.Drawing.Color.White;
            this.ScoreText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScoreText.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ScoreText.Location = new System.Drawing.Point(988, 70);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.ReadOnly = true;
            this.ScoreText.Size = new System.Drawing.Size(157, 32);
            this.ScoreText.TabIndex = 2;
            this.ScoreText.TabStop = false;
            // 
            // DinosaurJump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.提示);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DinosaurJump";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小恐龙快跑";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DinosaurJump_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.提示_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单;
        private System.Windows.Forms.ToolStripMenuItem 切换角色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商店ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 排行榜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 原生小恐龙ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 皮卡丘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 旋涡鸣人ToolStripMenuItem;
        private System.Windows.Forms.TextBox 提示;
        private System.Windows.Forms.TextBox ScoreText;
    }
}