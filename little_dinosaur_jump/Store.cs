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
        public Store()
        {
            
            InitializeComponent();
        }


        private void Store_FormClosing(object sender, FormClosingEventArgs e)
        {
            DinosaurJump form2 = new DinosaurJump();
            form2.Show();
        }
    }
}
