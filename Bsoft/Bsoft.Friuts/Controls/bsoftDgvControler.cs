using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fruits.Controls
{
    public partial class bsoftDgvControler : UserControl
    {
        public bsoftDgvControler()
        {
            InitializeComponent();
        }
        private void txtPageSize_Enter(object sender, EventArgs e)
        {
            txtpageSize.SelectAll();
        }

        private void txtPgNo_Enter(object sender, EventArgs e)
        {
            txtPgNo.SelectAll();
        }
        

        public  void setData(int pageno,int totalpage,int rowcount,int pagesize)
        {
            txtpageSize.Text = pagesize.ToString();
            txtPgNo.Text = pageno.ToString();
            lblTotalPage .Text = string .Format ( "of {0} page",totalpage .ToString ());
            lblbeforepage.Text = "";
            lblrowsize.Text = string.Format("Page Size:" );
            lblLast.Text = string.Format("Total Records:{0}", rowcount.ToString());
        }

        private void txtPageSize_MouseUp(object sender, MouseEventArgs e)
        {
            txtpageSize.SelectAll();

        }

        private void txtPgNo_MouseUp(object sender, MouseEventArgs e)
        {
            txtPgNo.SelectAll();
        }
         

        private void bsoftDgvControler_Load(object sender, EventArgs e)
        {
            Height = tlControler.Height;
            Visible = false;
        }

         
    }
}
