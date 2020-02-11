using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
namespace slcok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Dock = DockStyle.Fill;

        }

        private void btnGenKey_Click(object sender, EventArgs e)
        {
            string ink = txtKeyText.Text;
            txtRegistrationKey.Text = Bsoft.Common.keys.getKey(Bsoft.Common.RegType.Adv , ink);
            Clipboard.SetText(txtRegistrationKey.Text);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Bsoft.Common.RegType t = Bsoft.Common.keys.getRegType(txtKeyText.Text, txtRegistrationKey.Text);
            MessageBox.Show(t.ToString());
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            txtKeyText.Text = txtIdKey.Text + txtAppName.Text + txtCompanyName.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to generate a full key.", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (MessageBox.Show("Please confirm if full payment is recieved", "Dhaten khala !!!", MessageBoxButtons.YesNoCancel ) == DialogResult.Yes)
                {
                    string ink = txtKeyText.Text;
                    txtRegistrationKey.Text = Bsoft.Common.keys.getKey(Bsoft.Common.RegType.Full, ink);
                    Clipboard.SetText(txtRegistrationKey.Text);
                }
            }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "gonzo")
                groupBox1.Visible = false;
        }





    }
}