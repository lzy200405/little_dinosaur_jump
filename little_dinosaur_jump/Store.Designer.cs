namespace little_dinosaur_jump
{
    partial class Store
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
            this.YourCoins = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Coindetial = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.YourMoney = new System.Windows.Forms.TextBox();
            this.numtextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // YourCoins
            // 
            this.YourCoins.BackColor = System.Drawing.Color.White;
            this.YourCoins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YourCoins.CausesValidation = false;
            this.YourCoins.Enabled = false;
            this.YourCoins.Location = new System.Drawing.Point(1070, 45);
            this.YourCoins.Margin = new System.Windows.Forms.Padding(5);
            this.YourCoins.Name = "YourCoins";
            this.YourCoins.ReadOnly = true;
            this.YourCoins.Size = new System.Drawing.Size(153, 32);
            this.YourCoins.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(399, 359);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(213, 32);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "输入购买数量:";
            // 
            // Coindetial
            // 
            this.Coindetial.BackColor = System.Drawing.Color.White;
            this.Coindetial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Coindetial.Enabled = false;
            this.Coindetial.Location = new System.Drawing.Point(386, 255);
            this.Coindetial.Margin = new System.Windows.Forms.Padding(5);
            this.Coindetial.Name = "Coindetial";
            this.Coindetial.ReadOnly = true;
            this.Coindetial.Size = new System.Drawing.Size(476, 32);
            this.Coindetial.TabIndex = 1;
            this.Coindetial.Text = "复活币：100积分";
            this.Coindetial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 518);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "确认购买";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YourMoney
            // 
            this.YourMoney.BackColor = System.Drawing.Color.White;
            this.YourMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YourMoney.Enabled = false;
            this.YourMoney.Location = new System.Drawing.Point(870, 45);
            this.YourMoney.Margin = new System.Windows.Forms.Padding(5);
            this.YourMoney.Name = "YourMoney";
            this.YourMoney.ReadOnly = true;
            this.YourMoney.Size = new System.Drawing.Size(153, 32);
            this.YourMoney.TabIndex = 3;
            // 
            // numtextbox
            // 
            this.numtextbox.Location = new System.Drawing.Point(661, 359);
            this.numtextbox.Name = "numtextbox";
            this.numtextbox.Size = new System.Drawing.Size(142, 39);
            this.numtextbox.TabIndex = 4;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 700);
            this.Controls.Add(this.numtextbox);
            this.Controls.Add(this.YourMoney);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Coindetial);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.YourCoins);
            this.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商店";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Store_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox YourCoins;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Coindetial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox YourMoney;
        private System.Windows.Forms.TextBox numtextbox;
    }
}