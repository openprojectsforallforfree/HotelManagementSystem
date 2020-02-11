using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using UEMS.BLL;
using System.Linq;
using Bsoft.Data;
using Bsoft.Languages;
using Bsoft.Common;
namespace Bsoft.AppCom.UserMgtSimple
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class SuperAdmin_Rights_Users_Ent : Friuts.EntryFormBase
    {
        public SuperAdmin_Rights_Users_Ent()
        {
            InitializeComponent();
            lblENGNAME.Text = Language.LanguageString.Name;
            //lblPw.Text = Language.LanguageString.PassWord;
            lblUSERSTATUS.Text = Language.LanguageString.Active;
            lblUserid.Text = Language.LanguageString.UserId;
            grpSuperAdmin_Rights_Menu_User.Text = Language.LanguageString.UserRoles;
        }
        private void SuperAdmin_Rights_Users_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>
            loadColumnlist();
            //ColumnList.AddNewEditColumn("LASTLOGGEDON", ColumnTypes.String, txtLASTLOGGEDON);
            //ColumnList.AddNewEditColumn("LASTLOGGEDOUT", ColumnTypes.String, txtLASTLOGGEDOUT);
            //ColumnList.AddNewEditColumn("GRANTS",ColumnTypes.String, txtGRANTS );
            //ColumnList.AddNewEditColumn("PersonId", ColumnTypes.Number, txtPersonId);

            loadAllMenu();
        }
        private void loadColumnlist()
        {
            TableName = "SuperAdmin_Rights_Users";
            ColumnList.Clear();
            ColumnList.AddNewEditColumn("id", ColumnTypes.Number, txtid, true, false);
            ColumnList.AddNewEditColumn("Userid", ColumnTypes.String, txtUserid);
            //pw will be default 123
            //if (FormTypes.EntryForm  == FormType )
            //{
            //    ColumnList.AddNewEditColumn("Pw", ColumnTypes.String, "3mlJcyGH6312vDYaUbAe+A==");
            //}

            ColumnList.AddNewEditColumn("NEPNAME", ColumnTypes.String, txtNEPNAME);
            ColumnList.AddNewEditColumn("ENGNAME", ColumnTypes.String, txtENGNAME);
            ColumnList.AddNewEditColumn("USERSTATUS", ColumnTypes.String, chkUSERSTATUS);
        }
        private void loadAllMenu()
        {
            StringBuilder sql = new StringBuilder();
            sql.Remove(0, sql.Length);
            sql.Append("SELECT	DISTINCT id,text FROM SuperAdmin_Rights_Menu  ");
            DataTable Menus = null;
            Menus = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());


            int i;
            for (i = 0; i < Menus.Rows.Count; i++)
            {
                ComboItem itm = new ComboItem(Menus.Rows[i]["id"].ToString(),
                    Menus.Rows[i]["text"].ToString(), ColumnTypes.Number);
                chkRightsList.Items.Add(itm);

            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (FormType == FormTypes.EntryForm)
            {
                if (Save(false))
                {
                    PrimaryKeyValue = getLatestIdFromSQL("Id").ToString();
                    txtid.Text = PrimaryKeyValue.ToString();
                    SaveSecurityRights(txtid.Text);
                    FormType = FormTypes.EditForm;
                    loadColumnlist();
                    LoadData();
                }
            }
            else
            {
                if (Save())
                {
                    SaveSecurityRights(txtid.Text);
                }
                // SaveSecurityRights();
            }


        }

        private void SaveSecurityRights(string userid)
        {
            StringBuilder Sql = new StringBuilder();
            Sql.Remove(0, Sql.Length);
            Sql.Append("DELETE FROM SuperAdmin_Rights_Menu_Users ");
            Sql.AppendFormat("\n WHERE fk_SuperAdmin_Rights_Users = {0}", userid);
            GlobalResources.SelectDBConnection.ExecuteNonQuery(Sql.ToString());

            for (int i = 0; i < chkRightsList.Items.Count; i++)
            {
                if (chkRightsList.GetItemCheckState(i) == CheckState.Checked)
                {
                    ComboItem RightsID = (ComboItem)chkRightsList.Items[i];
                    if (RightsID.Key != "")
                    {
                        Sql.Remove(0, Sql.Length);
                        Sql.Append("INSERT INTO SuperAdmin_Rights_Menu_Users ");
                        Sql.Append("\n( fk_SuperAdmin_Rights_Users, fk_SuperAdmin_Rights_Menu, giveRight )");
                        Sql.AppendFormat("  VALUES ( ");
                        Sql.AppendFormat("\n{0}", userid);
                        Sql.AppendFormat("\n ,{0}", RightsID.Key.ToString());
                        Sql.Append("\n, '1' ");
                        Sql.Append(" ) ");
                        GlobalResources.SelectDBConnection.ExecuteNonQuery(Sql.ToString());
                    }
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private bool IsvalidUser()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(@"SELECT
	DISTINCT  Nepname 
FROM
	SuperAdmin_Rights_Users  a
WHERE
	a.USERSTATUS ==1
	and 
	a.id ='{0}'", txtid.Text);

            DataTable Rights = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());
            if (Rights == null || Rights.Rows.Count < 1)
            {
                return false;//No right 
            }
            return true;
        }

        private void DataLoadToListCheckBox()
        {
            if (!IsvalidUser())
            {
                //remove all rights
                return;
            }
            StringBuilder sql = new StringBuilder();
            sql.Remove(0, sql.Length);
            sql.AppendFormat(@"SELECT menu.id menuid ,menu.TEXT menuText, rights.giveRight  
FROM SuperAdmin_Rights_Menu menu 
left  join  SuperAdmin_Rights_Menu_Users rights on menu.Id=rights.fk_SuperAdmin_Rights_Menu   
left join  SuperAdmin_Rights_Users Users on Users.id = rights.fk_SuperAdmin_Rights_Users 
where
Users.id = '{0}'
    
   ", txtid.Text);
            DataTable Rights = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());
            var drs = from DataRow dr in Rights.Rows
                      select dr["menuid"].ToString();
            List<string> drlst = drs.ToList();

            //Get the menus fields
            if (txtUserid.Text.ToUpper().ToString() == "ADMIN")
            {
                for (int i = 0; i < chkRightsList.Items.Count; i++)
                {
                    chkRightsList.SetItemChecked(i, true);
                }

            }
            else if (drlst.Count > 0 && FormType == FormTypes.EditForm)
            {

                for (int i = 0; i < chkRightsList.Items.Count; i++)
                {
                    ComboItem chkitem = (ComboItem)chkRightsList.Items[i];
                    if (drlst.Contains(chkitem.Key.ToString()))
                    {
                        chkRightsList.SetItemChecked(i, true);
                    }
                }


            }
        }
        public override bool LoadData()
        {
            base.LoadData();
            if (FormType == FormTypes.EditForm)
            {
                pnlUSERSTATUS.Visible = true;
                FormUtility.adjustHt(this, flowLayoutPanel1, grpSuperAdmin_Rights_Menu_User, true);
                DataLoadToListCheckBox();
            }
            return true;
        }
        private void SuperAdmin_Rights_Users_Ent_Shown(object sender, EventArgs e)
        {
            if (FormType == FormTypes.EditForm)
            {
                pnlUSERSTATUS.Visible = true;
                 FormUtility.adjustHt(this, flowLayoutPanel1, grpSuperAdmin_Rights_Menu_User, true);
            }
            else
            {
                pnlUSERSTATUS.Visible = false;
                 FormUtility.adjustHt(this, flowLayoutPanel1, grpSuperAdmin_Rights_Menu_User, false);
            }

        }

        private void chkUSERSTATUS_CheckedChanged(object sender, EventArgs e)
        {
            FormUtility.adjustHt(this, flowLayoutPanel1, grpSuperAdmin_Rights_Menu_User, chkUSERSTATUS.Checked);
        }

        private void grpSuperAdmin_Rights_Menu_User_Enter(object sender, EventArgs e)
        {

        }
    }
}
