using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestoSys
{
    public partial class TagsControl : FlowLayoutPanel
    {
        public delegate void AddClickedHandler(object sender);
        public event AddClickedHandler addMoreTagClicked;
        public bool AddVisible {
            get {
                return plusButton.Visible;
            }

            set {
                plusButton.Visible = value;
            }
        }
        public delegate void RemoveClickedHandler(string Table);
        public event RemoveClickedHandler removeClicked;
        Button plusButton;
        Label label = new Label();
        public string Text
        {
            get
            {
                return label.Text;
            }
            set
            {
                label.Text = value;
            }
        }
        public TagsControl()
        {
            InitializeComponent();
            label.Visible = true;
            label.AutoSize = true;
            label.TextAlign = ContentAlignment.MiddleLeft;
            this.Controls.Add(label);
            label.Text = Text;
            plusButton = new Button();
            plusButton.Text = "+";
            plusButton.FlatStyle = FlatStyle.Flat;
            plusButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            plusButton.AutoSize = true;
            plusButton.Visible = true;
            plusButton.TabStop = false;
            this.Controls.Add(plusButton);

            plusButton.Click += new EventHandler(b_Click);
        }

        void b_Click(object sender, EventArgs e)
        {
            addMoreTagClicked(this);
        }


        void btag_Click(object sender, EventArgs e)
        {
            if (this.Controls.Count < 4)
            {
                return;
            }
            removeClicked(((Button)sender).Text);
            this.Controls.Remove((Button)sender);
        }

        public void AddTag(string tag)
        {
            Button b = new Button();
            b.Text = tag;
            b.FlatStyle = FlatStyle.Flat;
            b.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            b.AutoSize = true;
            b.Visible = true;
            b.TabStop = false;
            b.Click += new EventHandler(btag_Click);
            this.Controls.Add(b);
            this.Controls.SetChildIndex(plusButton, this.Controls.Count);
        }

        public bool IsTag(string tag)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    if (ctrl.Text.ToLower () ==tag.ToLower ())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
