using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UEMS
{   //Programmed By Dhiraj 
    //2009 Nov 26
    //Uses label in format Title::alable:blable:clable
    //Users text in format 1:2:3
    //Uses lable count as the main one
    public partial class multiChoiceTextBox : UserControl
    {
        lblTxtSmall[] UserCtrl = new lblTxtSmall[20];
        public multiChoiceTextBox()
        {
            InitializeComponent();
        }

         
        
        private int count=0;
        string _Text;
        public string Text
        {
            get {

                _Text = "";

                for (int i = 0; i < count ; i++)
                {
                    if (UserCtrl[i].txtBox.Text.Trim() == "")
                    {
                        UserCtrl[i].txtBox.Text = "0";
                    }
                    _Text += UserCtrl[i].txtBox.Text + "::";
                }

                return _Text ;
                
            }
            set {_Text = value;

            loadTexts (_Text);
            
            }
        
        }

        string _Lable;
        public string Lable
        {
            get
            {

                _Lable = "";

                for (int i = 0; i < count; i++)
                {
                    _Lable += UserCtrl[i].lblLable .Text +"::";
                }

                return _Lable;


            }
            set
            {
                _Lable = value;

                loadLables(_Lable);

            }

        }
        private void loadTexts(string str)
        {
            _Text = str;
            
            string[] substrings;
            int countText = 0;
            substrings = _Text.Split(new string[] { "::" }, StringSplitOptions.RemoveEmptyEntries);
            countText = substrings.Length;
            if (countText>count  )
            { countText = count; }
           

            for (int i = 0; i < countText; i++)
            {
         
          
                UserCtrl[i].txtBox.Text = substrings[i].ToString();
                UserCtrl[i].Tag = "";
            }

        }
        private  void loadLables(string str)
        {
            _Lable  = str;
            
            string[] substrings;

            substrings = _Lable.Split(new string[] { "::" }, StringSplitOptions.RemoveEmptyEntries);
            count = substrings.Length;
            if (count < 1) { return; }
            count--;
            flowPanel.Controls.Clear();
            foreach (Control ctrl in flowPanel.Controls)
            { this.Controls.Remove(ctrl); }
            flowPanel.Controls.Clear();


            Label lbl = new Label();
            flowPanel.Controls.Add(lbl);
            lbl.Parent = flowPanel;
            lbl.AutoSize = false;
            lbl.Height = Height;
            lbl.Width = 50;
            lbl.AutoEllipsis = true;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Text = substrings[0].ToString();
            lbl.Tag = "";

            for (int i = 0; i < count; i++)
            {
                UserCtrl[i] = new lblTxtSmall();

                flowPanel.Controls.Add(UserCtrl[i]);
                UserCtrl[i].Parent = flowPanel;

                UserCtrl[i].lblLable.Text = substrings[i+1].ToString();
                UserCtrl[i].Tag = "";
             }

        }
    }
}
