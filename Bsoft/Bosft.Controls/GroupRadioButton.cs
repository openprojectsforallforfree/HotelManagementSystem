using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Bsoft.Controls
{

    [ToolboxBitmap(typeof(resfinder), "Bosft.Controls.bajra.jpg")]
    public partial class GroupRadioButton : UserControl
    {

        SMcMaster.TabOrderManager tom;
        public GroupRadioButton()
        {
            InitializeComponent();

            string[] sa = this.GetType().Assembly.GetManifestResourceNames();
            foreach (string s in sa)
                System.Diagnostics.Trace.WriteLine(s);

            smallheight = label1.Height + label1.Top * 2;
            tom = new SMcMaster.TabOrderManager(this);
        }
        private string radios_ = "";
 
        /// <summary>
        /// Seperate using comma
        /// </summary>
        public string radios
        {
            get
            {
                return radios_;
            }
            set
            {
                bool first = true;
                if (value == null)
                {
                    radios_ = "";
                }
                else
                {
                    radios_ = value;
                    string[] rad = radios_.Split(',');
                    foreach (string rd in rad)
                    {
                        RadioButton rb = new RadioButton();
                        rb.Name = rd;
                        rb.Text = rd.Replace(" ", "");
                        rb.CheckAlign = ContentAlignment.MiddleRight;
                        if (first)
                            rb.Checked = true;
                        first = false;
                        flowLayoutPanel1.Controls.Add(rb);

                    }
                }
            }
        }


        
        int smallheight = 0;
        public void sortAccrossFirst()
        {
            tom.SetTabOrder(SMcMaster.TabOrderManager.TabScheme.AcrossFirst);
        }
        public void sortDownFirst()
        {
            tom.SetTabOrder(SMcMaster.TabOrderManager.TabScheme.DownFirst);
        }
        private void makeallcontrolinvisible(bool visib)
        {
            foreach (Control c in this.Controls)
            {
                if (c.Name != "label1" & c.Name != "button1")
                {
                    c.Visible = visib;
                }
            }
        }

        public string lable
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
    }
}
internal class resfinder
{ }