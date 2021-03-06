using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Bsoft.Common;
using Bsoft.Controls;
using Friuts;
using Bsoft.Data;
using System.Data;

using Bsoft.Forms;
using Bsoft.AppCom;

//Help use following syntax for the ANSI standard
//CREATE TABLE Orders
//(
//O_Id int NOT NULL,
//OrderNo int NOT NULL,
//P_Id int,
//PRIMARY KEY (O_Id),
//CONSTRAINT fk_PerOrders FOREIGN KEY (p_id)
//REFERENCES questiontype(Id)
//)


namespace Bsoft.AppCom
{
    public class ChangeBasicDBStructure
    {
        #region Member variables.Constructors & Finalizers.
        public void UpdateStructure()
        {
            StringBuilder SQLCreate = new StringBuilder();
           
            if (!GlobalResources.DbStruct.DoesTableExists("SuperAdmin_ConstantValues"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE SuperAdmin_ConstantValues( ");
                SQLCreate.Append(" \n Id INTEGER primary key AUTOINCREMENT ");
                SQLCreate.Append(" \n, VariableName varchar(50) ");
                SQLCreate.Append(" \n, Value varchar(150) )");
                DbHelpers.CreateATable(SQLCreate.ToString());
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO SuperAdmin_ConstantValues (VariableName,Value)  VALUES('RegistrationKey','Un-Registered');");
                SQLCreate.Append("INSERT INTO SuperAdmin_ConstantValues (VariableName,Value)  VALUES('FirstKey','Un-Registered')");
                ConstantValues.Org_Name = "You Company Name";
                ConstantValues.Org_District = "Kathmandu";

                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
            }
        }

        public void DeleteAllViews()
        {
            DataTable dt= GlobalResources.DbStruct.GetAllView ();
            foreach (DataRow dr in dt.Rows)
            {

                GlobalResources.DbStruct.Con.ExecuteNonQuery("Drop View " +  dr["name"].ToString ());
            }
        }

        #endregion



    }
}





