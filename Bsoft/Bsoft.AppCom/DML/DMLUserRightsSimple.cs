using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsoft.AppCom;
using Bsoft.Data;
using System.Windows.Forms;

namespace Bsoft.AppCom
{
    //To recreate menu structure in db just delete the menurights table form Db.
    public class DMLUserRightsSimple
    {
        public void UpdateStructure(MenuStrip MainMenuStrip)
        {
            if (!GlobalResources.DbStruct.DoesTableExists("SuperAdmin_Rights_Roles"))
            {
                DbHelpers.CreateATable(@" CREATE TABLE SuperAdmin_Rights_Roles(  
                 Id Integer primary key identity(1,1) , 
                 Title varchar(50) Unique, 
                 Remarks varchar(150))");


                GlobalResources.SelectDBConnection.ExecuteNonQuery("INSERT INTO SuperAdmin_Rights_Roles (Title,Remarks)  VALUES('Admin','Has All the Rights')");
                GlobalResources.SelectDBConnection.ExecuteNonQuery("INSERT INTO SuperAdmin_Rights_Roles (Title,Remarks)  VALUES('Cashier','At the cash counter')");
                GlobalResources.SelectDBConnection.ExecuteNonQuery("INSERT INTO SuperAdmin_Rights_Roles (Title,Remarks)  VALUES('Manager','Manager')");

            }

            #region Common for simple and role user management
            if (!GlobalResources.DbStruct.DoesTableExists("SuperAdmin_Rights_Users"))
            {
                DbHelpers.CreateATable(@" 
                    CREATE TABLE SuperAdmin_Rights_Users(
                    id INTEGER primary key autoincrement , 
                    Userid varchar(15) unique,
                    Pw varchar(50) DEFAULT '3mlJcyGH6312vDYaUbAe+A==',
                    NEPNAME varchar(25),
                    ENGNAME varchar(25),
                    Address varchar(150),
                    Email varchar(150),
                    Phone varchar(50),
                    USERSTATUS varchar(1),
                    LASTLOGGEDON varchar(50),
                    LASTLOGGEDOUT varchar(50),
                    fk_Group integer,
                    PersonId Integer,       
                    CONSTRAINT FK_SuperAdmin_Rights_Users_fk_Group FOREIGN KEY (fk_Group) REFERENCES SuperAdmin_Rights_Roles (Id))");

                GlobalResources.SelectDBConnection.ExecuteNonQuery(@"INSERT INTO SuperAdmin_Rights_Users (Userid,NEPNAME,ENGNAME,Pw,USERSTATUS)  
                    VALUES('Admin','प्रमुख संचालक ','Administrator', '3mlJcyGH6312vDYaUbAe+A==','1')");

            }

            if (!GlobalResources.DbStruct.DoesTableExists("SuperAdmin_Rights_Menu"))
            {
                DbHelpers.CreateATable(@" 
                    CREATE TABLE SuperAdmin_Rights_Menu(
                    Id Integer primary key autoincrement , 
                    Name varchar(50),
                    text varchar(50),
                    level varchar(50),
                    Description varchar(150))");
              
            }
            #endregion
            #region without roles
//            if (!GlobalResources.DbStruct.DoesTableExists("SuperAdmin_Rights_Menu_Users"))
//            {
//                DbHelpers.CreateATable(@" 
//                CREATE TABLE SuperAdmin_Rights_Menu_Users(
//                Id Integer primary key autoincrement , 
//                fk_SuperAdmin_Rights_Users Integer,
//                fk_SuperAdmin_Rights_Menu Integer,
//                giveRight varchar(1),
//                CONSTRAINT FK_SuperAdmin_Rights_Users_fk_SuperAdmin_Rights_Users FOREIGN KEY (fk_SuperAdmin_Rights_Users) REFERENCES SuperAdmin_Rights_Users (Id), 
//                CONSTRAINT FK_SuperAdmin_Rights_Menu_fk_SuperAdmin_Rights_Menu FOREIGN KEY (fk_SuperAdmin_Rights_Menu) REFERENCES SuperAdmin_Rights_Menu (Id))");
//                RefreshMenusToDb(MainMenuStrip);
//            }
            #endregion

            #region With Roles
           
            if (!GlobalResources.DbStruct.DoesTableExists("SuperAdmin_Rights_Menu_Roles"))
            {
                DbHelpers.CreateATable(@" 
                CREATE TABLE SuperAdmin_Rights_Menu_Roles(
                Id Integer primary key autoincrement , 
                fk_SuperAdmin_Rights_Roles Integer,
                fk_SuperAdmin_Rights_Menu Integer,
                giveRight varchar(1),
                CONSTRAINT FK_SuperAdmin_Rights_Users_roles FOREIGN KEY (fk_SuperAdmin_Rights_Roles) REFERENCES SuperAdmin_Rights_Roles (Id), 
                CONSTRAINT FK_SuperAdmin_Rights_Menu_menu FOREIGN KEY (fk_SuperAdmin_Rights_Menu) REFERENCES SuperAdmin_Rights_Menu (Id))");
                RefreshMenusToDb(MainMenuStrip);
            }

            #endregion

        }

        //Trucnates rights and menu table and gives all rights to admin
        public void RefreshMenusToDb(System.Windows.Forms.MenuStrip m)
        {
            //get from the app use loop
            foreach (System.Windows.Forms.ToolStripMenuItem mainmenu in m.Items)
            {
                if (mainmenu.Enabled)
                {
                    InsertAMenuToDb(mainmenu.Name, mainmenu.Text, 0);
                    foreach (System.Windows.Forms.ToolStripItem submenu in mainmenu.DropDownItems)
                    {
                        if (submenu.GetType() == typeof(System.Windows.Forms.ToolStripMenuItem))
                        {
                            if (submenu.Enabled)
                            {
                                InsertAMenuToDb(submenu.Name, submenu.Text, 1);
                            }
                        }
                    }
                }
            }

            //Give All rights to Admin
            GiveAllRolestoAdmin();
        }

        private void InsertAMenuToDb(string mnuname, string mnutext, int level)
        {
            StringBuilder SQLCreate = new StringBuilder();

            mnutext = mnutext.Replace("&", "");
            SQLCreate.Remove(0, SQLCreate.Length);
            SQLCreate.AppendFormat("INSERT INTO SuperAdmin_Rights_Menu (Name,Level,Description,text)  VALUES('{0}',{1},'{2}','{3}')", mnuname, level, "", mnutext);
            GlobalResources.SelectDBConnection.ExecuteNonQuery(SQLCreate.ToString());
        }

        private void GiveAllRolestoAdmin()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = GlobalResources.SelectDBConnection.ExecuteDataTable("select id from SuperAdmin_Rights_Menu   ");
            foreach (System.Data.DataRow dr in dt.Rows)
            {
                string grpid = dr[0].ToString();
                string sql = string.Format("INSERT INTO SuperAdmin_Rights_Menu_Roles ( fk_SuperAdmin_Rights_Roles,fk_SuperAdmin_Rights_Menu,giveRight)  VALUES(1,{0},1)", dr[0].ToString());
                GlobalResources.SelectDBConnection.ExecuteNonQuery(sql);
            }
        }
    }
}
