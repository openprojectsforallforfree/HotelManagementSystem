using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace Bsoft.Controls
{
    //  [Designer("System.Windows.Forms.Design.PanelDesigner, System.Design")]
    //  Important
    //  to add control make UserControl then add then again remake into FlowLayoutPanel
    public partial class LableFlowLayout : FlowLayoutPanel
    //   public partial class LableFlowLayout : UserControl 
    {
        SMcMaster.TabOrderManager tom;
        public LableFlowLayout()
        {
            InitializeComponent();
            smallheight = label1.Height + label1.Top * 2;
            tom = new SMcMaster.TabOrderManager(this);
            //sortDownFirst();
            bigheight = label1.Bottom;
        }

        int bigheight = 0;
        int smallheight = 0;
        //public void sortAccrossFirst()
        //{
        //    tom.SetTabOrder(SMcMaster.TabOrderManager.TabScheme.AcrossFirst);
        //}

        //public void sortDownFirst()
        //{
        //    tom.SetTabOrder(SMcMaster.TabOrderManager.TabScheme.DownFirst);
        //}

        //private void makeallcontrolinvisible(bool visib)
        //{
        //    foreach (Control c in this.Controls)
        //    {
        //        if (c.Enabled && c.Name != "label1" & c.Name != "button1")
        //        {
        //            c.Visible = visib;
        //        }
        //    }
        //}

        //private void label1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    togglevisibility();
        //}
        string sign = "";

        //const string plus = " + ";
        //const string minus = " - ";
        private string lable_ = "";
        public string lable
        {
            get
            {
                return lable_;
            }
            set
            {
                lable_ = value;
                label1.Text = sign + value;
            }
        }

      

        private void LableFlowLayout_Enter(object sender, EventArgs e)
        {
            label1.BackColor = Color.SkyBlue; //sortDownFirst();
        }

        private void LableFlowLayout_Leave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent  ;
        }

        private void LableFlowLayout_Resize(object sender, EventArgs e)
        {
            label1.Width = Width - 2;
            label1.Left = 0;
        }

        //private void button1_Enter(object sender, EventArgs e)
        //{
        //    if (sign == plus)
        //    {
        //        sign = minus;
        //        label1.Text = sign + lable;
        //        makeallcontrolinvisible(true);
        //        Height = bigheight;
        //    }
        //    if (Controls.Count > 2)
        //        Controls[2].Select();
        //}
        //private void togglevisibility()
        //{
        //    //Old way
        //    if (sign == plus)
        //    {
        //        sign = minus;
        //        label1.Text = sign + lable;
        //        makeallcontrolinvisible(true);
        //        Height = bigheight;
        //    }
        //    else if (sign == minus)
        //    {
        //        sign = plus;
        //        bigheight = Height;
        //        label1.Text = sign + lable;
        //        makeallcontrolinvisible(false);
        //        Height = smallheight;
        //    }
        //}

        //private void button1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    togglevisibility();
        //}

        //private void LableFlowLayout_ControlAdded(object sender, ControlEventArgs e)
        //{
           
                
        //}
    }
}
