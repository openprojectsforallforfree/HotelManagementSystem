using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UEMS;

namespace Bsoft.Controls
{
    public partial class DiscountControl : UserControl
    {
        bool notCalculating = true;
        decimal _amount = 0;
        private decimal _discount, _percent;
        public delegate void discountUpdatedH(decimal percent, decimal discountAmount);
        public event discountUpdatedH discountUpdated;
        public DiscountControl()
        {
            InitializeComponent();
            //Value updated is event for shadow text box.
            txtDiscount.ValueUpdated += new txtShadowTextBox.valueSetHandler(txtDiscount_ValueUpdated);
            txtDiscountPercent.ValueUpdated += new txtShadowTextBox.valueSetHandler(txtDiscountPercent_ValueUpdated);
        }

      
        public decimal Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                updateDiscount ();
            }
        }

        public decimal DiscountAmount
        {
            get { return _discount ; }
            set
            {
                _discount = value;
                updatePercent();
            }
        }

        public decimal DiscountPercent
        {
            get { return _percent; }
            set
            {
                _percent = value;
                updateDiscount  ();
            }
        }

        private void updateDiscount()
        {
            notCalculating = false;
            decimal.TryParse(txtDiscountPercent.Value, out _percent);
            _discount = (_percent /(decimal ) 100) * _amount;
            _discount = Math.Round(_discount, 2);
            txtDiscount.Value = _discount.ToString();
            notCalculating = true;
        }

        private void updatePercent()
        {
            notCalculating = false;
            if (_amount == 0 || _amount < _discount)
            {
                _discount = 0;
                txtDiscount.Value = "0";
                txtDiscountPercent.Value = "0";
                notCalculating = true;

                return;
            }
            _percent = (_discount / _amount) * (decimal)100;
            _percent = Math.Round(_percent, 2);
            txtDiscountPercent.Value = _percent.ToString();
            notCalculating = true;
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToDecimal(txtDiscount.Value) > _amount)
            {
                e.Handled = true;
            }
        }

        private void txtDiscountPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToSingle(txtDiscountPercent.Value) > 99)
            {
                e.Handled = true;
            }
        }

        private void txtDiscountPercent_Enter(object sender, EventArgs e)
        {
            txtDiscountPercent.SelectionStart = 0;
            txtDiscountPercent.SelectionLength = txtDiscountPercent.Value.Length;
            txtDiscountPercent.SelectAll();
        }

        private void txtDiscount_Enter(object sender, EventArgs e)
        {
            txtDiscount.SelectAll();
        }

        void txtDiscountPercent_ValueUpdated()
        {
            if (notCalculating)
            {
                updateDiscount();
            }
        }

        void txtDiscount_ValueUpdated()
        {
            if (notCalculating)
            {
                updatePercent();
            }
            //call event
            if (discountUpdated != null)
            {
                discountUpdated(_percent, _discount);
            }
        }
    }
}
