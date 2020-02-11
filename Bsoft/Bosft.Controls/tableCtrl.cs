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
    public partial class TablesControl : FlowLayoutPanel
    {
        public delegate void TableClickHandler(object sender, string param);
        public event TableClickHandler TableCliked;

        public string Text
        {
            get
            {
                return lbl.Text;
            }
            set
            {
                lbl.Text = value;
            }
        }
        Label lbl = new Label();
        public TablesControl()
        {
          
            InitializeComponent();
            lbl.Text = "Tables";
            lbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl.Visible = true;
            this.Controls.Add(lbl);

        }

        public void AddTable(string tableName)
        {
            Button b = new Button();
            b.Click += new EventHandler(b_Click);
            b.Text = tableName;
            b.Height = 30;
            b.FlatStyle = FlatStyle.Flat;
            b.BackgroundImageLayout = ImageLayout.Zoom;
            b.Tag = "";
            this.Controls.Add(b);
            b.Visible = true;
        }

        void b_Click(object sender, EventArgs e)
        {
            TableCliked(sender, ((Button)sender).Text);
        }

        public void OccupyTable(string TableName)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button ic = (Button)ctrl;
                    if (ic.Text.Contains(TableName))
                    {
                        ic.Tag = "occupied";
                        ic.BackgroundImage = Bsoft.Controls.Properties.Resources.Man1;
                        return;
                    }

                }
            }
        }

        public void freeTable(string TableName)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button ic = (Button)ctrl;
                    if (ic.Text.Contains(TableName))
                    {
                        ic.Tag = "free";
                        ic.BackgroundImage = null;
                        return;
                    }

                }
            }
        }

    }
}
