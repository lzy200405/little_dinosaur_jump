namespace little_dinosaur_jump
{
    partial class Rank
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rank));
            this.little_dinosaurDataSet = new little_dinosaur_jump.little_dinosaurDataSet();
            this.scoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreTableAdapter = new little_dinosaur_jump.little_dinosaurDataSetTableAdapters.ScoreTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.little_dinosaurDataSet1 = new little_dinosaur_jump.little_dinosaurDataSet1();
            this.scoreTableAdapter1 = new little_dinosaur_jump.little_dinosaurDataSet1TableAdapters.ScoreTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.little_dinosaurDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.little_dinosaurDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // little_dinosaurDataSet
            // 
            this.little_dinosaurDataSet.DataSetName = "little_dinosaurDataSet";
            this.little_dinosaurDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreBindingSource
            // 
            this.scoreBindingSource.DataMember = "Score";
            this.scoreBindingSource.DataSource = this.little_dinosaurDataSet;
            // 
            // scoreTableAdapter
            // 
            this.scoreTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.scoreBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(786, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "User_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "User_name";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.scoreDataGridViewTextBoxColumn.Width = 150;
            // 
            // scoreBindingSource1
            // 
            this.scoreBindingSource1.DataMember = "Score";
            this.scoreBindingSource1.DataSource = this.little_dinosaurDataSet1;
            // 
            // little_dinosaurDataSet1
            // 
            this.little_dinosaurDataSet1.DataSetName = "little_dinosaurDataSet1";
            this.little_dinosaurDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreTableAdapter1
            // 
            this.scoreTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 118);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rank_FormClosing);
            this.Load += new System.EventHandler(this.Rank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.little_dinosaurDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.little_dinosaurDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private little_dinosaurDataSet little_dinosaurDataSet;
        private System.Windows.Forms.BindingSource scoreBindingSource;
        private little_dinosaurDataSetTableAdapters.ScoreTableAdapter scoreTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private little_dinosaurDataSet1 little_dinosaurDataSet1;
        private System.Windows.Forms.BindingSource scoreBindingSource1;
        private little_dinosaurDataSet1TableAdapters.ScoreTableAdapter scoreTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}