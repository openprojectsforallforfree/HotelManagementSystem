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

    public partial class multichoiceCheckBox : UserControl
    {
        CheckBox[] UserCtrl = new CheckBox[20];
        public multichoiceCheckBox()
        {
            InitializeComponent();
        }

        private int count = 0;
        string _checkBoxes;
        public string Lable
        {
            get
            {

                _checkBoxes = "";

                for (int i = 0; i < count; i++)
                {
                    _checkBoxes += UserCtrl[i].Text + "::";
                }

                return _checkBoxes;


            }
            set
            {
                _checkBoxes = value;

                loadcheckBoxes(_checkBoxes);

            }

        }
      
        string _Text;
        public override  string Text
        {
            get
            {

                _Text = "";

                for (int i = 0; i < count; i++)
                {
                    
                    if (UserCtrl[i].Checked )
                    { _Text += "1" + "::";}
                    else
                    { _Text += "0" + "::";}
                }

                return _Text;


            }
            set
            {
                _Text = value;

                loadTexts(_Text);

            }

        }
        private void loadTexts(string str)
        {
            _Text = str;

            string[] substrings;
            int countText = 0;
            substrings = _Text.Split(new string[] { "::" }, StringSplitOptions.RemoveEmptyEntries);
            countText = substrings.Length;
            if (countText > count)
            { countText = count; }


            for (int i = 0; i < countText; i++)
            {
                if (substrings[i].ToString()=="1")
                { UserCtrl[i].Checked = true; }
                else
                { UserCtrl[i].Checked = false ; }

                
            }

        }
        private void loadcheckBoxes(string str)
        {
          
            
            string[] substrings;

            substrings = str.Split(new string[] { "::" }, StringSplitOptions.RemoveEmptyEntries);
            count = substrings.Length;
            if (count < 1) {return;}
            count--;

            flowPanel.Controls.Clear();
            foreach (Control ctrl in flowPanel.Controls)
            { this.Controls.Remove(ctrl); }
            flowPanel.Controls.Clear();

            Label lbl = new Label();
            flowPanel.Controls.Add(lbl);
            lbl.Parent = flowPanel;
            lbl.AutoSize = false  ;
            lbl.Height = Height;
            lbl.Width = 150;
            lbl.AutoEllipsis = true;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Text = substrings[0].ToString();
            lbl.Tag = "";
         
            for (int i = 0; i < count; i++)
            {
                UserCtrl[i] = new CheckBox ();

                flowPanel.Controls.Add(UserCtrl[i]);
                UserCtrl[i].Parent = flowPanel;

                UserCtrl[i].Text = substrings[i+1].ToString();
                UserCtrl[i].Tag = "";


               
            }

        }
    }
}
