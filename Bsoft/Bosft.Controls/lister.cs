using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Collections;
using System.Text;
using System.Windows.Forms;

namespace Bsoft.Controls
{
    public partial class lister : UserControl
    {
        public lister()
        {
            InitializeComponent();
            
        }

        #region Private members
        DataTable dtLister;
        private void setdata(DataTable dt)
        {
            listView1.Columns[0].Text = dt.Columns[0].ToString();
            listView1.Columns[1].Text = dt.Columns[1].ToString();
            listView1.BeginUpdate();
            listView1.Items.Clear();

            ArrayList items = new ArrayList();
            foreach (System.Data.DataRow dr in dt.Rows)
            {
                items.Clear();
                foreach (System.Data.DataColumn dc in dt.Columns)
                {
                    items.Add(dr[dc].ToString().Trim());
                }
                string[] listItems = (string[])items.ToArray(typeof(string));

                listView1.Items.Add(new ListViewItem(listItems));
            }

            listView1.EndUpdate();
            //  SetAlternatingRowColors(listView1, Color.LightGray   , Color.White );
        }
        #endregion

        /// <summary>
        /// Must contain two columns the name of the tile is derived from names 
        /// of the title in datatable
        /// Intellegenly makes correction to datatabe as well!
        /// </summary>
        public DataTable Datatable
        {
            get
            {
                return dtLister;
            }
            set
            {
                if (value != null)
                {
                  
                    // to convert into our format 
                    //intellegenlty if not in so .
                    if (hoizontal)
                    {
                        dtLister = value;
                        listView1.Columns.Clear();
                        listView1.Items.Clear();
                        foreach (System.Data.DataColumn dc in dtLister.Columns)
                        {
                            listView1.Columns.Add(dc.ToString(), dc.ToString().Length * 12 );
                        }
                       
                        listView1.BeginUpdate();
                       

                        ArrayList items = new ArrayList();
                        foreach (System.Data.DataRow dr in dtLister.Rows)
                        {
                            items.Clear();
                            foreach (System.Data.DataColumn dc in dtLister.Columns)
                            {
                                items.Add(dr[dc].ToString().Trim());
                            }
                            string[] listItems = (string[])items.ToArray(typeof(string));

                            listView1.Items.Add(new ListViewItem(listItems));
                        }

                        listView1.EndUpdate();
                    }
                    else
                    {
                        if (value.Columns.Count < 2)
                        {
                        }
                        else if (value.Columns.Count == 2)
                        {
                            dtLister = value;
                            setdata(dtLister);
                        }
                        else
                        {
                            if (value.Columns.Count > 2)
                            {
                                dtLister = new DataTable("Sample");
                                dtLister.Columns.Add("Title");
                                dtLister.Columns.Add("Value");
                                foreach (DataColumn dc in value.Columns)
                                {
                                    dtLister.Rows.Add(dc.ToString(), value.Rows[0][dc].ToString());
                                }
                                setdata(dtLister);
                            }
                        }
                    }

                }
            }
        }
        /// <summary>
        /// If true horizontal 
        /// else vertical
        /// </summary>
        /// 
        [Description("If true horizontal else vertical")]
        [Category ("Bsoft")]
        public bool hoizontal
        { get; set; }


        #region Listview relaged


        private void lister_SizeChanged(object sender, EventArgs e)
        {

            if (hoizontal == false)
            {
                listView1.Columns[0].Width = 100;
                int secondcolwidht = Width - 105;
                if (secondcolwidht > 0)
                    listView1.Columns[1].Width = secondcolwidht;
            }
        }

        // <summary>
        /// method for adding alternating row colows in a ListView control
        /// </summary>
        /// <param name="lst">ListView we're working with</param>
        /// <param name="color1">furst color to use</param>
        /// <param name="color2">second color to use</param>
        public void SetAlternatingRowColors(ListView lst, Color color1, Color color2)
        {
            //loop through each ListViewItem in the ListView control

            foreach (ListViewItem item in lst.Items)
            {
                if ((item.Index % 2) == 0)
                    item.BackColor = color1;
                else
                    item.BackColor = color2;
            }
        }
        #endregion

    }
}
