using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bsoft.Controls
{
    public partial class LblGeneric : UserControl
    {
        public enum ControlTypes
        {
            TextBox,
            DateTimePicker,
            ComboBox,
            DateFromTo
        }
        public string Lable
        {
            get { return lblLable.Text; }
            set { lblLable.Text = value; }
        }


        public static int LableWidth = 150;
         


        public LblGeneric()
        {
            InitializeComponent();
            lblLable.Width = LableWidth;
            flowLayoutPanel1.Top = 1;
            ControlType = ControlTypes.TextBox;
            //dateTimePicker.Location = textBox.Location;
            //comboBox.Location = textBox.Location;
            //dateFromTo1.Location = textBox.Location;

            //comboBox.Size = textBox.Size;
            //dateTimePicker.Size = textBox.Size;

            //dateTimePicker.Anchor = textBox.Anchor;
            //comboBox.Anchor = textBox.Anchor;
            //dateFromTo1.Anchor = textBox.Anchor;

        }
        Control current = null;
       public  TextBox textBox = new TextBox();
       public DateTimePicker dateTimePicker = new DateTimePicker();
       public ComboBox comboBox = new ComboBox();
       public DateFromTo dateFromTo = new DateFromTo();
        ControlTypes _ControlType = ControlTypes.TextBox;
        public ControlTypes ControlType
        {
            get
            {
                return _ControlType;
            }
            set
            {
                panel1 .Width = LableWidth;
                _ControlType = value;
                if (current!=null)
                {
                    flowLayoutPanel1.Controls.Remove(current );
                }
                
                switch (value)
                {
                    case ControlTypes.TextBox:
                     
                        textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
                        
                        textBox.Size = new System.Drawing.Size(200, 22);

                        flowLayoutPanel1.Controls.Add(textBox);


                        current = textBox;
                        break;
                    case ControlTypes.DateTimePicker:
                        
                      

                        dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
                        dateTimePicker.CustomFormat = "dd-MMM-yyyy";
                        dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                        dateTimePicker.Size = new System.Drawing.Size(118, 22);
                        flowLayoutPanel1.Controls.Add(dateTimePicker);

                        current = dateTimePicker;
                        break;
                    case ControlTypes.ComboBox:
 
                        comboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
                        comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
                        comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                        comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        comboBox.FormattingEnabled = true;
                        comboBox.Size = new System.Drawing.Size(210, 24);
                        flowLayoutPanel1.Controls.Add(comboBox);

                        current = comboBox;
                        break;
                    case ControlTypes.DateFromTo:
                        dateFromTo.Location = new System.Drawing.Point(553, 4);
                        dateFromTo.Margin = new System.Windows.Forms.Padding(4);
                        dateFromTo.Name = "dateFromTo1";
                        dateFromTo.Size = new System.Drawing.Size(260, 63);

                        flowLayoutPanel1.Controls.Add(dateFromTo);

                        current = dateFromTo;

                        break;
                    default:
                        break;
                }
              
                flowLayoutPanel1.Height = current.Height + 2;
                panel1.Height = current.Height;
                current.Top = 1;
                current.Visible = true;
                current.Left = lblLable.Right;
                this.Height = flowLayoutPanel1.Height;
               // this.Width = current.Right + 2;
            }
        }
    }
}
