using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
 
using System.Text;
using System.Windows.Forms;

namespace Bsoft.Controls
{
    public partial class listerGrid : UserControl
    {
        public listerGrid()
        {
            InitializeComponent();


            grid.ColumnHeadersHeight = 35;
            grid.RowHeadersWidth = 54;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = true;
            grid.MultiSelect = false;
            grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(223)))), ((int)(((byte)(224)))));
            grid.SelectionMode =   DataGridViewSelectionMode.CellSelect;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
              
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.RowHeadersVisible = false;
            grid.ColumnHeadersVisible = false;

            grid.AutoResizeColumns();
            grid.StandardTab = true; //required...
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

        
           
           
        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
         
                SendKeys.Send("{TAB}");
         
        }

        
    }
}
