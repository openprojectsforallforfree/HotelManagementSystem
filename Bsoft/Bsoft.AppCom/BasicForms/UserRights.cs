using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Bsoft.Forms;
using Bsoft.Data;
using Bsoft.Common;

namespace Bsoft.AppCom.BasicForms
{
    public static class UserRights
    {

        public static void setRights(MenuStrip menuStripForRights)
        {
           
             
            //make admin asways visible
            if (GlobalValues.LoginUserName != null && GlobalValues.LoginUserName.ToLower().Trim() == "admin")
            {
                foreach (System.Windows.Forms.ToolStripMenuItem mainmenu in menuStripForRights.Items)
                {
                    if (mainmenu.Enabled == true)
                    {
                        mainmenu.Visible = true;
                    }

                    foreach (System.Windows.Forms.ToolStripItem submenu in mainmenu.DropDownItems)
                    {
                        if (submenu.Enabled == true)
                        {
                            submenu.Visible = true;
                        }
                    }
                }
                return;
            }
            string userRole = GetUserRoleId(GlobalValues.LoginUserIDPk);
            if (userRole.Length == 0)
            {
                MessageBoxMy.Show("Your roles are not assigend .Please Contact the administrator.", MessageBoxButtons.OK);
                Application.Exit();
            }
            if (GetUserActiveStatus (GlobalValues.LoginUserIDPk)=="0")
            {
                MessageBoxMy.Show("Your are not an active user of this system .Please Contact the administrator.", MessageBoxButtons.OK);
                Application.Exit();
            }
            try
            {
                string sql = string.Format(
                    @"select  rm.Name,rm.TEXT,rmu.giveright
                     from SuperAdmin_Rights_Menu rm 
                     left join SuperAdmin_Rights_Menu_Roles rmu
                     on rmu.fk_SuperAdmin_Rights_Menu =rm.id where rmu.fk_SuperAdmin_Rights_Roles ={0}", userRole
                    );
                DataRow drMenu;
                DataTable dtMenu = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());

                DataColumn[] dcPrimary = { dtMenu.Columns["name"] };
                dtMenu.PrimaryKey = dcPrimary;//For find function to work
                if (dtMenu.Rows.Count < 1)
                {
                    MessageBoxMy.Show("Rights assigment is not correct please contact the Software company.");
                    Application.Exit();
                }
                foreach (System.Windows.Forms.ToolStripMenuItem mainmenu in menuStripForRights.Items)
                {

                    drMenu = dtMenu.Rows.Find(mainmenu.Name);
                    setRight(mainmenu, drMenu);

                    foreach (System.Windows.Forms.ToolStripItem submenu in mainmenu.DropDownItems)
                    {
                        drMenu = dtMenu.Rows.Find(submenu.Name);
                        setRight(submenu, drMenu);
                    }
                }

            }
            catch { }
        }

        private static void setRight(System.Windows.Forms.ToolStripItem mnuItem, DataRow drMenu)
        {
            if (mnuItem is ToolStripMenuItem)
            {
                //Dont set the disabled menus these are application wise
                if (mnuItem.Enabled == false)
                {
                    return;
                }
                string right = Conversion.ToString(drMenu, "giveright");
                if (right == "1")
                {
                    mnuItem.Visible = true;
                }
                else
                {
                    mnuItem.Visible = false;
                }
            }
        }

        private static string GetUserRoleId(string userID)
        {
            return GlobalResources.SelectDBConnection.ExecuteScalar ("select fk_Group from SuperAdmin_Rights_Users where id = " + userID ).ToString ();
        }

        private static string GetUserActiveStatus(string userID)
        {
            return GlobalResources.SelectDBConnection.ExecuteScalar("select USERSTATUS from SuperAdmin_Rights_Users where id = " + userID).ToString ();
        }
    }
}
