using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UEMS
{
[System.ComponentModel.DesignerCategory("form")]
    public partial class test : Friuts.EntryFormBase    
    {
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }
 

        private void btnOk_Click(object sender, EventArgs e)
        {
             MessageBox.Show("ok");
         
        }

        private void roundRectButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("r ok");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("r ok");
        }
    }
}
