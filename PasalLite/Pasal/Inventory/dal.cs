using System;
using System.Collections.Generic;
using System.Text;
using UEMS.BLL;
using Bsoft.Data;

namespace Pasal.Inventory
{
    public static class dal
    {
        #region getvalues
        //todo : get multiple quantity breakdown
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns> stock for given Inv_purchage Id </returns>
        public static double getStock(int id)
        {
            try
            {
                StringBuilder SQL = new StringBuilder();
                SQL.Append("SELECT quantity-  quantity_sold-quantity_damage-purchaseReturn+salesReturn   as Stock from Inv_Purchase where id=" + id.ToString());
                string quantity = "";
                quantity = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
                if (quantity != "")
                {
                    return Convert.ToDouble(quantity);
                }
            }
            catch
            {
                return 0;
            }
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>unit symbol from unit id</returns>
        public static string getUnit(string id)
        {
            string unit = "";
            StringBuilder SQL = new StringBuilder();

            SQL.Append("SELECT symbol from unit_Master where id = " + id);
            try
            {
                unit = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            }
            catch { return ""; }

            return unit;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Product_Company_Master id</param>
        /// <returns>gets name of product company </returns>
        public static string getCompany(string id)
        {
            string cmpny = "";
            StringBuilder SQL = new StringBuilder();
            SQL.Append("SELECT Name from Product_Company_Master where id = " + id);
            try
            {
                cmpny = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            }
            catch { return ""; }
            return cmpny;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Product_Group_Master id</param>
        /// <returns>name of group</returns>
        public static string getGroup(string id)
        {
            string grp = "";
            StringBuilder SQL = new StringBuilder();
            SQL.Append("SELECT Name from Product_Group_Master where id = " + id);
            try
            {
                grp = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            }
            catch { return ""; }
            return grp;
        }
        #endregion

        #region validations


        public static string GetProductIdFromCode(string groupCode, string code)
        { 
            string groupid;
            string product;
            try
            {
                groupid = GlobalResources.SelectDBConnection.ExecuteScalar("select id from Product_Group_Master where code = '" + groupCode + "'").ToString();
                StringBuilder SQL = new StringBuilder();
                SQL.Append("SELECT id from Product_Master where fk_Group = " + groupid + " and Code ='" + code + "'");
                product = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            }
            catch { product = null; }
            return product;

        }


        #endregion
    }
}
