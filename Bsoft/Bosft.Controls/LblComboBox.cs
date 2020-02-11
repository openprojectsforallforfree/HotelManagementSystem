using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Bsoft.Controls
{
    public partial class lblComboBox : UserControl
    {
        public delegate void refreshHandler(string message);
        public event refreshHandler refreshcombo;
        public lblComboBox()
        {
            InitializeComponent();
        }

        public string Label
        {
            get { return lblLable.Text; }
            set { lblLable.Text = value; }
        }
        public Form ShowonClick { get; set; }
        private void lblLable_Click(object sender, EventArgs e)
        {
            if (ShowonClick != null)
            {
                ShowonClick.ShowDialog();
                //Call event here to refresh the combobox.
                try
                {
                    refreshcombo("now");
                }
                catch { }
                //ComboBoxDataLoader.LoadData("Id", "Title", "Course", cmbCourseId.cmbBox, true);
            }
        }

        private void lblComboBox_Resize(object sender, EventArgs e)
        {
            this.Height = cmbBox.Height + 2;
        }
    }
}
