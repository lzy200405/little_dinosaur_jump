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
   
    public partial class Store : Form
    {
        private DinosaurJump dj;
        public Store()
        {
            
            InitializeComponent();
        }
        public Store(DinosaurJump currentdj) 
        {
            InitializeComponent();
            dj= currentdj;
        }



        private void Store_FormClosing(object sender, FormClosingEventArgs e)
        {
            dj.Show();
        }
    }
}
