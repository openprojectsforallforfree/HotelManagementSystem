using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsoft.AppCom;
using Bsoft.Data;

namespace UEMS.BLL
{
    public partial class ChangeDBStructure
    {
        private void insertAMenuToDb(string mnuname, string mnutext, int level)
        {
            StringBuilder SQLCreate = new StringBuilder();

            mnutext = mnutext.Replace("&", "");
            SQLCreate.Remove(0, SQLCreate.Length);
            SQLCreate.AppendFormat("INSERT INTO Rights_Menu (Name,Level,Description,text)  VALUES('{0}',{1},'{2}','{3}')", mnuname, level, "", mnutext);
            GlobalResources.SelectDBConnection.ExecuteNonQuery(SQLCreate.ToString());
        }


        private void GetmenusToDb(System.Windows.Forms.MenuStrip m)
        {
            //get from the app use loop
            foreach (System.Windows.Forms.ToolStripMenuItem mainmenu in m.Items)
            {
                if (mainmenu.Enabled)
                {
                    insertAMenuToDb(mainmenu.Name, mainmenu.Text, 0);
                    foreach (System.Windows.Forms.ToolStripItem submenu in mainmenu.DropDownItems)
                    {
                        if (submenu.GetType() == typeof(System.Windows.Forms.ToolStripMenuItem))
                        {
                            if (submenu.Enabled)
                            {
                                insertAMenuToDb(submenu.Name, submenu.Text, 1);
                            }
                        }
                    }
                }
            }

        }
        private  void giveAllRolestoAdmin()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = GlobalResources.SelectDBConnection .ExecuteDataTable("select id from Rights_Menu   ");

            foreach (System.Data.DataRow dr in dt.Rows)
            {
                string grpid = dr[0].ToString();
                string sql = string.Format("INSERT INTO Rights_Menu_Users ( fk_Rights_Users,fk_Rights_Menu,giveRight)  VALUES(1,{0},1)", dr[0].ToString());
                GlobalResources.SelectDBConnection .ExecuteNonQuery(sql);
            }
        }
        public void CreateUserRightsSimple()
        {
            if (!GlobalResources.DbStruct.DoesTableExists("Rights_Users"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE Rights_Users(
id Integer primary key autoincrement , 
Userid varchar(50),
Pw varchar(50) DEFAULT '3mlJcyGH6312vDYaUbAe+A==',
NEPNAME varchar,
ENGNAME varchar,
USERSTATUS varchar,
LASTLOGGEDON varchar(50),
LASTLOGGEDOUT varchar(50),
GRANTS varchar(50),
PersonId Integer)");


                GlobalResources.SelectDBConnection .ExecuteNonQuery(@"INSERT INTO Rights_Users (Userid,NEPNAME,ENGNAME,Pw,USERSTATUS)  
VALUES('Admin','प्रमुख संचालक ','Administrator', '3mlJcyGH6312vDYaUbAe+A==','1')");

            }

            if (!GlobalResources.DbStruct.DoesTableExists("Rights_Menu"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE Rights_Menu(
Id Integer primary key autoincrement , 
Name varchar,
text varchar,
level varchar,
Description varchar)");

                MainForm fm = new MainForm ();
                GetmenusToDb(fm.menuStrip1 );
                fm.Dispose();
            }

            if (!GlobalResources.DbStruct.DoesTableExists("Rights_Menu_Users"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE Rights_Menu_Users(
Id Integer primary key autoincrement , 
fk_Rights_Users Integer,
fk_Rights_Menu Integer,
giveRight varchar(1),CONSTRAINT FK_Rights_Users_fk_Rights_Users FOREIGN KEY (fk_Rights_Users) REFERENCES Rights_Users (Id), 
CONSTRAINT FK_Rights_Menu_fk_Rights_Menu FOREIGN KEY (fk_Rights_Menu) REFERENCES Rights_Menu (Id))");

                giveAllRolestoAdmin();
            }








        }
    }
}
