using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestoSys.Reports
{
    public partial class frmTestBill : Form
    {
        public frmTestBill()
        {
            InitializeComponent();
        }
        Invoice i = new Invoice();
        private void frmTestBill_Load(object sender, EventArgs e)
        {
 
            DataTable dt = new DataTable();

          
             dt.Columns .Add ("description");
             dt.Columns .Add ("rate");
             dt.Columns .Add ("quantity");
             dt.Columns .Add ("netamount");
             dt.Rows.Add("1","Biscuit","3","5","15");
             dt.Rows.Add("1", "tea", "3", "5", "1595.44");
             dt.Rows.Add("1", "milk", "3", "5", "1593.44");
             
            i.Print("1", "2", "3", "4", "43", "324.60", "8", "","",dt);
             Invoice .PanNo = "";
        }
       
        private void frmTestBill_Paint(object sender, PaintEventArgs e)
        {
            
            i.prntit(e.Graphics);
        }
    }
}
