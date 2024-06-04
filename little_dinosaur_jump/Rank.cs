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
    public partial class Rank : Form
    {
        private DinosaurJump dj;
        private UserScoreBLL userScoreBLL=new UserScoreBLL();
        public Rank()
        {
            InitializeComponent();
        }

        public Rank(DinosaurJump currentdj)
        {
            InitializeComponent();
            dj = currentdj;
        }

        public DinosaurJump DinosaurJump { get; }

        private void Rank_FormClosing(object sender, FormClosingEventArgs e)
        {
            dj.Show();
        }



        private void Rank_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“little_dinosaurDataSet1.Score”中。您可以根据需要移动或移除它。
            //this.scoreTableAdapter1.Fill(this.little_dinosaurDataSet1.Score);
            LoadData();
        }


        private void LoadData()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = userScoreBLL.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
