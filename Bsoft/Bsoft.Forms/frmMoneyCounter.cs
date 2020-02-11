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

namespace Bsoft.Forms
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmMoneyCounter : Bsoft.Design.FormDesginBase
    {
        public frmMoneyCounter()
        {
            LblGeneric.LableWidth = 50;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddDenomiations();
        }

        private void AddDenomiations()
        { lblDeficit.Text="";
           GridUtility . SetDataGridViewProperties(grid);
            GridUtility gu = new GridUtility();
            gu.SetProperties(grid);
            grid.Rows.Clear();
            grid.EditMode = DataGridViewEditMode.EditOnEnter;
            grid.Rows.Add("Rs. 1,000", 1000, 0, 0);
            grid.Rows.Add("Rs. 500", 500, 0, 0);
            grid.Rows.Add("Rs. 250", 250, 0, 0);
            
            grid.Rows.Add("Rs. 100", 100, 0, 0);
            grid.Rows.Add("Rs. 50", 50, 0, 0);
            grid.Rows.Add("Rs. 25", 25, 0, 0);
            grid.Rows.Add("Rs. 20", 20, 0, 0);
            grid.Rows.Add("Rs. 10", 10, 0, 0);
            grid.Rows.Add("Rs. 5", 5, 0, 0);
            grid.Rows.Add("Rs. 2", 2, 0, 0);
            grid.Rows.Add("Rs. 1", 1, 0, 0);
            grid.Rows.Add("50 Paisa", 0.5, 0, 0);
            grid.Rows.Add("25 Paisa", 0.25, 0, 0);
            grid.Rows.Add("10 Paisa", 0.1, 0, 0);
            grid.Rows.Add("5 Paisa", 0.05, 0, 0);
            GridUtility.SetGridRowSerialNo(grid );
            grid.StandardTab = true;
            grid.RowHeadersWidth = 10;
            txtExpected.Text  = "0";
            txtTotal.Text = "0";
            // grid.Rows.Add("Total", 0, 0);
        }
        const int TotalRowIndex = 16;
        decimal totalAmount = 0;
        private void grid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != TotalRowIndex)
            {
                decimal amt = Conversion.ToDecimal(grid.Rows[e.RowIndex].Cells["colQuantity"].Value.ToString()) * Conversion.ToDecimal(grid.Rows[e.RowIndex].Cells["colValue"].Value.ToString());
                string val = Friuts.WinFormHelper.GetFormattedNumber(amt.ToString(), Friuts.ThousandSeparaterTypes.Nepali,2);
                grid.Rows[e.RowIndex].Cells["colAmount"].Value = val;
                totalAmount = GridUtility.GetSum(grid, "colAmount", 0, TotalRowIndex - 1);
                txtTotal.Text = Friuts.WinFormHelper.GetFormattedNumber( totalAmount.ToString(),Friuts .ThousandSeparaterTypes .Nepali,2 );
                if (txtExpected.Text.ToDecimal() != 0)
                {
                    decimal deficit = txtExpected.Text.ToDecimal() - totalAmount;
                    lblDeficit.Visible = true ;
                    lblDeficit.Text = "Total - Expected = Rs {0}.".With(deficit);
                }
                else
                {
                    lblDeficit.Visible = false;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AddDenomiations();
        }

        private void txtExpected_TextChanged(object sender, EventArgs e)
        {
            if (txtExpected.Text.ToDecimal() != 0)
            {
                decimal deficit = txtExpected.Text.ToDecimal() - totalAmount;
                lblDeficit.Text = "Total - Expected = Rs {0}.".With(deficit);
                lblDeficit.Visible = true ;
            }
            else
            {
                lblDeficit.Visible = false;
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
