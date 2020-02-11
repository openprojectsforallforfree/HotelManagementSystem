using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bsoft.Controls;

namespace RestoSys.UserControls
{
    public partial class ProductSearchCriteria : UserControl
    {
        public ProductSearchCriteria()
        {
            InitializeComponent();
        }

        private void ProductSearchCriteria_Load(object sender, EventArgs e)
        {
            LblGeneric .LableWidth = 150;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        } 
    }
}
