using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Bsoft.Controls
{
    public partial class lblTextBox : UserControl
    {
        public lblTextBox()
        {
            InitializeComponent();
        }

        public override  string Text
        {
            get {  return vtxtBox.Text; }
             set  {  vtxtBox.Text=value ; }
        }
        [Category("Bsoft")]
        [Description("Label")]
        public string Label
        {
            get { return lblLable .Text; }
            set { lblLable.Text = value; }
        }
        [Category("Bsoft")]
        [Description("Validation")]
        public Bsoft.Controls.VtextBox.ValidationTypeEnum Validation
        {
            get {return  vtxtBox.ValidationType; }
            set { vtxtBox.ValidationType = value ; }
        }

        [Category("Bsoft")]
        [Description("Multiline")]
        public bool  Multiline
        {
            get { return vtxtBox.Multiline ; }
            set { vtxtBox.Multiline = value;
            
            }
        }

        //[Category("Bsoft")]
        //[Description("Size")]
        //public System .Drawing .Size  SizeofTextBox
        //{
        //    get { return vtxtBox.Size ; }
        //    set { vtxtBox.Size = value; }
        //}
        private void lblTextBox_Enter(object sender, EventArgs e)
        {
            vtxtBox.Select();
            vtxtBox.Focus();
        }

        public Form ShowonClick { get; set; }

        private void lblLable_Click(object sender, EventArgs e)
        {
            if (ShowonClick !=null)
            ShowonClick.ShowDialog();
        }

        private void lblTextBox_Resize(object sender, EventArgs e)
        {
            this.Height = vtxtBox.Height+2;
        }

      
    }
}
