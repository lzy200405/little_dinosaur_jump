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
        public Rank()
        {
            InitializeComponent();
        }

        private void Rank_FormClosing(object sender, FormClosingEventArgs e)
        {
            DinosaurJump form2 = new DinosaurJump();
            form2.Show();
        }
    }
}
