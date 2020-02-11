using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Bsoft.Common;
using Bsoft.Forms;
using Bsoft.AppCom;
using Bsoft.Data;
using RestoSys.RestaurantBilling;
using RestoSys.UserControls;
namespace RestoSys
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmResotoBill : Friuts.EntryFormBase
    {

        public frmResotoBill()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Type == SoftwareTypes.Ticket)
            {
                Text = "Ticket Billing ";
            }
            else  
            {
                Text = "Restaurant Billing";
            }
            
            //tags tables
            TableView.lblMenu.Text = "Tables";
            menuView.ItemIsClicked += new Bsoft.Controls.menuView.refreshHandler(Menu_ItemIsClicked);
            TableView.ItemIsClicked += new Bsoft.Controls.menuView.refreshHandler(TableView_ItemIsClicked);
            //Fill Tables
            if (GlobalValues.UseOrder)
            {
                DataTable orderTables = RestoSys.RestoSysDAl.GetOrderTable();
                TableView.AddGroup("Tables", "Tables", "");
                foreach (DataRow dr in orderTables.Rows)
                {
                    TableView.AddItem("Tables", dr["Name"].ToString(), dr["Name"].ToString(), false);
                }
                TableView.StartTree();
            }
            else
            {
                NewOrderForNotUsingOrder();
            }
            //tags tables
            //Menus
            DataTable dtProductGroups = RestoSysDAl.GetItemsForMenu();
            foreach (DataRow drGroup in dtProductGroups.Rows)
            {
                GroupDetails g = new GroupDetails();
                g.code = "";
                g.Name = "";
                DataTable dtProductItems = RestoSysDAl.GetItems(drGroup["Id"].ToString());
                if (dtProductItems.Rows.Count > 0)
                {
                    menuView.AddGroup(drGroup["Name"].ToString(), drGroup["Name"].ToString(), g);
                    foreach (DataRow drItem in dtProductItems.Rows)
                    {
                        ItemDetails id = new ItemDetails();
                        id.code = drItem[ItemDetails.Fields.code].ToString();
                        id.description = drItem[ItemDetails.Fields.description].ToString();
                        id.rate = drItem[ItemDetails.Fields.rate].ToString().ToDecimal();
                        id.productId = drItem[ItemDetails.Fields.productId].ToString();
                        //get latest purchase id or set to 0
                        // id.purchaseId = RestoSysDAl.GetPurchageId(id.productId);
                        id.remarks = drItem[ItemDetails.Fields.remarks].ToString();
                        id.costPrice = drItem[ItemDetails.Fields.costPrice].ToString().ToDecimal();

                        menuView.AddItem(drGroup["Name"].ToString(), drItem[ItemDetails.Fields.description].ToString(), drItem[ItemDetails.Fields.description].ToString(), id);
                    }
                }
            }

            menuView.StartTree();
        }

        void TableView_ItemIsClicked(string currentTableName, object obj, bool isDecrease)
        {
            currentOrder.Visible = false;
            foreach (Control ctrl in this.panelOrder.Controls)
            {
                if (ctrl is AnOrder)
                {
                    AnOrder ic = (AnOrder)ctrl;
                    //if (ic.tagsControl.IsTag(currentTableName))
                    if (ic.tableName == currentTableName)
                    {
                        ic.Visible = true;
                        currentOrder = ic;
                        return;
                    }
                }
            }
            //add new
            AnOrder newOrder = new AnOrder();

            newOrder.Visible = true;
            newOrder.AddTable(currentTableName);
            newOrder.cancelOrder += new AnOrder.CancelOrderHandler(newOrder_cancelOrder);
            //newOrder.tagsControl.addMoreTagClicked += new TagsControl.AddClickedHandler(tagsControl_addMoreTagClicked);
            //newOrder.tagsControl.removeClicked += new TagsControl.RemoveClickedHandler(tagsControl_removeClicked);
            //newOrder.tagsControl.Text = "Bill For Tables : ";
            newOrder.lblTable.Text = "Bill For Table " + currentTableName;
            newOrder.Dock = DockStyle.Fill;


            TableView.ShowImage(currentTableName);
            TableView.Refresh();


            currentOrder = newOrder;
            this.panelOrder.Controls.Add(newOrder);
            menuView.Select();
            menuView.Focus();
        }

        void newOrder_cancelOrder(object sender)
        {
            if (GlobalValues.UseOrder)
            {
                panelOrder.Controls.Remove((AnOrder)sender);
                TableView.RemoveImage(((AnOrder)sender).tableName);
                sender = null;

                //make next order visible
                foreach (Control ctrl in this.panelOrder.Controls)
                {
                    if (ctrl is AnOrder)
                    {
                        AnOrder ic = (AnOrder)ctrl;
                        //currentTableName = ic.tableName;
                        ic.Visible = true;
                        currentOrder = ic;
                        return;

                    }
                }

            }
            else
            {
                currentOrder.grid.Rows.Clear();
                currentOrder.gridSummary.DataSource = null; 
            }
        }

        void tagsControl_removeClicked(string Table)
        {
            TableView.RemoveImage(Table);
        }

        private void NewOrderForNotUsingOrder()
        {

            //initialise sale by default
            TableView.Visible = false;
            menuView.Location = TableView.Location;
            panelOrder.Left = panelOrder.Left - TableView.Width;
            panelOrder.Width = panelOrder.Width + TableView.Width;
            AnOrder anOrder = new AnOrder();
            anOrder.lblTable.Text = "Bill  ";
            anOrder.cancelOrder += new AnOrder.CancelOrderHandler(newOrder_cancelOrder);
            anOrder.Visible = true;
            anOrder.Dock = DockStyle.Fill;
            anOrder.AddTable("NoOrderSystem");
            //anOrder.tagsControl.Visible = false;
            this.panelOrder.Controls.Add(anOrder);
            currentOrder = (AnOrder)anOrder;
        }


        AnOrder currentOrder = new AnOrder();
        void Menu_ItemIsClicked(string message, object obj, bool IsDecrease)
        {
            if (IsDecrease)
            {
                GridCalculator.DescreseQuantity(currentOrder.grid, ((ItemDetails)obj));
            }
            else
            {
                GridCalculator.IncreaseQuantity(currentOrder.grid, ((ItemDetails)obj), 1);
            }
           currentOrder. gridCalculator.DisplaySummaryGrid();
            menuView.Select();
            menuView.Focus();
        }
    }

    public class GroupDetails
    {
        public string Name;
        public string code;
    }


    public class ItemDetails
    {
        public string description;
        public decimal rate;
        public string code;
        public string productId;
        public string purchaseId;
        public decimal costPrice;
        public string remarks;

        public static class Fields
        {
            public const string productId = "productId";
            public const string purchaseId = "purchageId";
            public const string description = "description";
            public const string rate = "rate";//mrp
            public const string quantity = "quantity";
            public const string amount = "amount";
            public const string discount = "discount";
            public const string netAmount = "netAmount";
            public const string remarks = "remarks";
            public const string code = "code";
            public const string costPrice = "costPrice";//hidden form customer
        }

        public static DataTable GetFreshDataTable(DataGridView dataGridView)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn item in dataGridView.Columns)
            {
                dt.Columns.Add(item.Name);
            }
            return dt;
        }

       

    }

}
