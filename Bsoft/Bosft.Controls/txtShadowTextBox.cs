using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Bsoft.Controls
{///Shadow text box eleminates the need of Extra label to denote what the textbox is for
    ///Programmed by Dhiraj 25 nov 2009
    public partial class txtShadowTextBox : VtextBox
    {

        public txtShadowTextBox()
        {

            InitializeComponent();

        }
        public delegate void valueSetHandler();
        public event valueSetHandler ValueUpdated;
        public HorizontalAlignment Alignment
        {
            get { return _alignment; }
            set { _alignment = value; }
        }
        private string _label;
        private string _value="";

        private HorizontalAlignment _alignment = HorizontalAlignment.Left;
        public string Label
        {
            get { return _label; }
            set
            {
                _label = value;
                if (_alignment == HorizontalAlignment.Left)
                {
                    Text = _label + _value;
                }
                else
                {
                    Text = _value + _label;
                }
            }
        }

        public string Value
        {
            get
            {
                try
                {
                    string v = Text;
                    if (_label != null && Text.Contains(_label))
                    {
                        if (_alignment == HorizontalAlignment.Left)
                        {
                            v = Text.Substring(_label.Length, Text.Length - _label.Length);

                        }
                        else
                        {
                            v = Text.Substring(0, Text.Length - _label.Length);

                        }
                    }
                    return v;
                }
                catch
                {
                    throw;
                }

            }
            set
            {
                try
                {
                    if (_alignment == HorizontalAlignment.Left)
                    {
                        Text = _label + value;
                    }
                    else
                    {
                        Text = value + _label;
                    }
                    if (ValueUpdated != null)
                    {
                        ValueUpdated();
                    }

                }
                catch
                {
                    throw;
                }

            }
        }

        private void txtShadowTextBox_Enter(object sender, EventArgs e)
        {
            this.Text = Value;
            SelectionStart = 0;
            SelectAll();
        }

        private void txtShadowTextBox_Leave(object sender, EventArgs e)
        {
            Value = Text;
        }

    }


}
