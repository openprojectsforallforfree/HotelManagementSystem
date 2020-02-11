using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using Bsoft.Common;
using System.Windows.Forms;

namespace Bsoft.Controls
{
    public partial class Discount : UserControl
    {
        bool UserEnteredValue = false;
        public delegate void discountUpdatedH(decimal percent, decimal discountAmount, bool userEnteredValue);
        public event discountUpdatedH DiscountUpdated;
        //Discount percent can be of more than 2 digit decimal but amount cannot be
        public Discount()
        {
            InitializeComponent();
            DiscountAmount = 0;
            txtPercent.Font = this.Font;
            txtAmount.Font = this.Font;

        }
        public void SetFont()
        {
            txtPercent.Font = this.Font;
            txtAmount.Font = this.Font;
        }
        #region To Validate
        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtAmount.Value.ToDecimal() <= amount)//valid
            {
                DiscountAmount = txtAmount.Value.ToDecimal();
            }
            else
            {
                toolErrorMessage.Show("Discount should be less than amount", this, 0, 0, 500);
                txtAmount.Value = getMoney(discountAmount);
                txtAmount.SelectionStart = txtAmount.Text.Length;
            }
            UserEnteredValue = true;
            if (DiscountUpdated != null)
            {
                DiscountUpdated(DiscountPercent, DiscountAmount, UserEnteredValue);
            }
        }

        private void txtPercent_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPercent.Value.ToDecimal() <= 100)//valid
            {
                DiscountPercent = (Math.Round(txtPercent.Value.ToDecimal(), 6));
            }
            else
            {
                toolErrorMessage.Show("Discount should be less than 100", this, 0, 0, 500);
                txtPercent.Value = Math.Round(discountPercent, 6).ToString ();
                txtPercent.SelectionStart = txtPercent.Text.Length;
            }
            UserEnteredValue = true;
            if (DiscountUpdated != null)
            {
                DiscountUpdated(DiscountPercent, DiscountAmount, UserEnteredValue);
            }
        }

        #endregion

        #region DiscountCalculations
        private decimal amount;
        public decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {

                amount = value;
                //As changind discount amount is not good percent is changed
                if (amount == 0)
                {
                    discountPercent = 0;
                    txtPercent.Value = (Math.Round(discountPercent, 6)).ToString();
                    discountAmount = 0;
                    txtAmount.Value = getMoney(discountAmount);
                }
                else
                {
                    discountPercent = (discountAmount / amount) * 100;
                    txtPercent.Value=(Math.Round(discountPercent, 6)).ToString();
                }


            }
        }
        private string getMoney(decimal amount)
        {
            return Math.Round(amount, 2).ToString();
        }
        private decimal discountAmount;

        public decimal DiscountAmount
        {
            get
            {
                return discountAmount;
            }
            set
            {
                discountAmount = value;
                if (amount == 0)
                {
                    discountPercent = 0;
                    txtPercent.Value = (Math.Round(discountPercent, 6)).ToString();
                    discountAmount = 0;
                    txtAmount.Value = getMoney(discountAmount);
                }
                else
                {
                    discountPercent = (discountAmount / amount) * 100;
                    txtPercent.Value = (Math.Round(discountPercent, 6)).ToString();
                    if (txtAmount.Focused != true)
                    {
                        txtAmount.Value = getMoney(discountAmount);
                    }

                }

            }
        }

        private decimal discountPercent;

        public decimal DiscountPercent
        {
            get
            {
                if (amount == 0)
                {
                    discountPercent = 0;
                }
                else
                {
                    discountPercent = discountAmount / amount * 100;
                }
                return discountPercent;
            }
            set
            {
                discountPercent = value;
                discountAmount = (discountPercent / 100) * amount;
                txtAmount.Value = getMoney(discountAmount);

                if (txtPercent.Focused != true)
                {
                    txtPercent.Value = (Math.Round(discountPercent, 6)).ToString();
                }
            }
        }
        #endregion

        private void txtAmount_Validating(object sender, CancelEventArgs e)
        {
            if (txtAmount.Value.ToDecimal() <= amount)//valid
            {
                DiscountAmount = getMoney(txtAmount.Value.ToDecimal()).ToDecimal();
            }
            txtAmount.Value = getMoney(discountAmount);
            if (DiscountUpdated != null)
            {
                DiscountUpdated(DiscountPercent, DiscountAmount, UserEnteredValue);
            }
        }

        private void txtPercent_Validating(object sender, CancelEventArgs e)
        {
            if (txtPercent.Value.ToDecimal() <= 100)//valid
            {
                DiscountPercent = (Math.Round(txtPercent.Value.ToDecimal(), 6));
            }
            txtPercent.Value = (Math.Round(discountPercent, 6)).ToString();
            if (DiscountUpdated != null)
            {
                DiscountUpdated(DiscountPercent, DiscountAmount, UserEnteredValue);
            }
        }

        private void txtAmount_Validated(object sender, EventArgs e)
        {
            //if (DiscountUpdated !=null)
            //{
            //    DiscountUpdated(DiscountPercent, DiscountAmount, UserEnteredValue);
            //}
        }

        private void txtPercent_Validated(object sender, EventArgs e)
        {
            //if (DiscountUpdated != null)
            //{
            //    DiscountUpdated(DiscountPercent, DiscountAmount, UserEnteredValue);
            //}

        }

        private void Discount_Resize(object sender, EventArgs e)
        {
            panelAmount.Left = 1;
            panelAmount.Width = this.Width - panelDiscount.Width - 2;
            panelDiscount.Left = this.Width - panelDiscount.Width - 1;
            txtAmount.Width = panelAmount.Width - txtAmount.Left - 1;
        }
    }
}
