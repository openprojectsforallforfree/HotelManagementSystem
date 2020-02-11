using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Bsoft.Data;
using Bsoft.Common;

namespace RestoSys.Tags
{
    public static class clsDataAccess
    {
        private static DataTable _TagGroups = new DataTable();
        static clsDataAccess()
        {
            string sql = @"
                select tg.id Id,tg.title title, tg.remarks Remarks, tt.Title Type from taggroup tg
                left join  TagType  tt on
                tt.Id = tg.TagTypeId ";
            _TagGroups = GlobalResources.SelectDBConnection.ExecuteDataTable(sql);
        }

        public static DataTable TagGroups
        {
            get
            {
                return _TagGroups;
            }
        }


        public static DataTable tags(string grpID)
        {
            string sql = "select Value from  tag where TagGroupId =" + grpID;
            DataTable tags = GlobalResources.SelectDBConnection.ExecuteDataTable(sql);
            return tags;
        }


        public static bool SaveData(string ItemId, DataTable dt)
        {
            string sql = "DELETE FROM Item_Tag where ItemId = " + ItemId;
            SetTagId(dt);
            GlobalResources.SelectDBConnection.ExecuteNonQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                sql = "INSERT INTO Item_Tag (TagId,ItemId) VALUES({0},{1})".With(dr["TagId"].ToString(), ItemId);
                GlobalResources.SelectDBConnection.ExecuteNonQuery(sql);
            }
            return true;
        }

        private static void SetTagId(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                string sqlSelect = "SELECT Id FROM TAG WHERE TagGroupId ='{0}' and Value ='{1}' ".With(dr["TagGrpId"].ToString(), dr["TagValue"].ToString());
                string tagid = string.Empty;
                try
                {
                    tagid = GlobalResources.SelectDBConnection.ExecuteScalar(sqlSelect).ToString();
                }
                catch
                {
                    string sqlInsert = @"INSERT INTO Tag
    (  TagGroupId, Value)
VALUES
    ( '{0}','{1}')".With(dr["TagGrpId"].ToString(), dr["TagValue"].ToString());
                    GlobalResources.SelectDBConnection.ExecuteNonQuery(sqlInsert).ToString();
                    tagid = GlobalResources.SelectDBConnection.ExecuteScalar(sqlSelect).ToString();
                }
                dr["TagId"] = tagid;
            }
        }

        public static DataTable GetTags(string ItemId)
        {
            string sql = @"select it.id,it.TagId tagid,t.TagGroupId Taggroupid,t.value value from item_tag it
left join tag t on t.id = it.TagId
where it.ItemId =" + ItemId;
            DataTable tags = GlobalResources.SelectDBConnection.ExecuteDataTable(sql);
            return tags;
        }
    }
}
