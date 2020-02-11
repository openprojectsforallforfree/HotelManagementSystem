using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bsoft.Common;
using Bsoft.Controls;
using Bsoft.Common.Utilities;
using Bsoft.Forms;
using Friuts;
using Fruits;
namespace test
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vtextBox1.MaxValue = 90;
        }

    }
}
