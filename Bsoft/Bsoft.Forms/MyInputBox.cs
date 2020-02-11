using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bsoft.Forms 
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class MyInputBox : Bsoft .Design .FormDesginBase   
    {
        public MyInputBox()
        {
            InitializeComponent();
        }
        public MyInputBox(string _Title, string _Message,string _Lable, string _inputboxmsg)
        {
            InitializeComponent();
            Text = _Title;
            Label4.Text = _Lable;
            txtnputBox.Text = _inputboxmsg;
            lblMessage.Text = _Message;
        }

        public MyInputBox( string _Message,string _inputboxmsg)
        {
            InitializeComponent();
             
            txtnputBox.Text=_inputboxmsg;
            lblMessage.Text = _Message;

        }
        public MyInputBox(string _Message )
        {
            InitializeComponent();
            lblMessage.Text = _Message;
        }
        public string TextValue
        {
            get { return txtnputBox.Text; }
            set { txtnputBox.Text = value; }
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtnputBox.Text);
                DialogResult = DialogResult.OK;
            }
            catch { }
        }

        
    }
}

