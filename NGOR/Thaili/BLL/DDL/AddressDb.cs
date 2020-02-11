using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using Bsoft.Common;
using Bsoft.Data;

namespace UEMS.BLL
{
    public partial class ChangeDBStructure
    {
        private void DefaultDataInsertInDistrict()
        {
            this.SQL.Remove(0, this.SQL.Length);
            this.SQL.Append("DELETE FROM DISTRICT");
            int del = GlobalResources.SelectDBConnection .ExecuteNonQuery(this.SQL.ToString());
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (15,1,    'TAPLEJUNG', 1, 'ताप्लेजुङ')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (16,1,\t'PANCHTHAR', 49, 'पाँचथर')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (17,1,\t'ILAM',\t94,'इलाम')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (18,1,\t'JHAPA',142,'झापा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (19,2,\t'MORANG',193,'मोरङ')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (20,2,\t'SUNSARI',259,'सुनसरी')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (21,2,\t'DHANKUTA',311,'धनकुटा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (22,2,\t'TERHATHUM',347,\t'तेह्रथुम')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (23,2,\t'SANKHUWASABHA',\t378\t,'संखुवासभा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (24,2,\t'BHOJPUR',\t414\t,'भोजपुर')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (25,3,\t'SOLUKHUMBU',\t477\t,'सोलुखुम्बु')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (26,3,\t'OKHALDHUNGA',\t511\t,'ओखलढुङ्गा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (27,3,\t'KHOTANG',\t565\t,'खोटाङ')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (28,3,\t'UDAYAPUR',\t641\t,'उदयपुर')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (29,3,\t'SAPTARI',\t688\t,'सप्तरी')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (30,3,\t'SIRAHA',\t803\t,'सिराहा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (31,4,\t'DHANUSA',\t915\t,'धनुषा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (32,4,\t'MAHOTARI',\t1018\t,'महोत्तरी')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (33,4,\t'SARLAHI',\t1095\t,'सर्लाही')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (34,4,\t'SINDHULI',\t1195\t,'सिन्धुली')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (35,4,\t'RAMECHHAP',\t1250\t,'रामेछाप')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (36,4,\t'DOLAKHA',\t1305\t,'दोलखा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (37,5,\t'SINDHUPALCHOKE',\t1359\t,'सिन्धुपाल्चोक')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (38,5,\t'KAVRE',\t1438\t,'काभ्रे')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (39,5,\t'LALITPUR',\t1533\t,'ललितपुर')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (40,5,\t'BHAKTAPUR',\t1574\t,'भतपुर')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (41,5,\t'KATHMANDU',\t1596\t,'काठमाण्डौ')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (42,5,\t'NUWAKOT',\t1663\t,'नुवाकोट')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (43,5,\t'RASUWA\t1724',\t,'रसुुवा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (44,5,\t'DHADING',\t1742\t,'धादिङ')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (45,6,\t'MAKWANPUR',\t1792\t,'मकवानपुर')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (46,6,\t'RAUTAHAT',\t1836\t,'रौतहट')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (47,6,\t'BARA',\t1937\t,'बारा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (48,6,\t'PARSA',\t2042\t,'पर्सा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (49,6,\t'CHITAWAN',\t2125\t,'चितवन')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (50,7,\t'GORKHA',\t2164\t,'गोरखा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (51,7,\t'LAMJUNG',\t2232\t,'लम्ाजुङ')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (52,7,\t'TANAHU',\t2293\t,'तनहु')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (53,7,\t'SYANGJA',\t2338\t,'स्याङ्जा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (54,7,\t'KASKI',\t2406\t,'कास्की')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (55,7,\t'MANANG',\t2454\t,'मनाङ')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (56,8,\t'MUSTANG',\t2466\t,'मुस्ताङ')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (57,8,\t'MYAGDI',\t2482\t,'म्याग्दी')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (58,8,\t'PARBAT',\t2522\t,'पर्वत')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (59,8,\t'BAGLUNG',\t2576\t,'बागलुङ')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (60,9,\t'GULMI',\t2638\t,'गुल्मी')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (61,9,\t'PALPA',\t2717\t,'पाल्पा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (62,9,\t'NAWALPARASI',\t2782\t,'नवलपरासी')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (63,9,\t'RUPANDEHI',\t2859\t,'रूपन्देही')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (64,9,\t'KAPILBASTU',\t2945\t,'कपिलवस्तु')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (65,9,\t'ARGHAKHANCHI',\t3024\t,'अर्घाखाँची')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (66,10,\t'PYUTHAN',\t3065\t,'प्युठान')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (67,10,\t'ROLPA',\t3114\t,'रोल्पा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (68,10,\t'RUKUM',\t3165\t,'रूकुम')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (69,10,\t'SALYAN',\t3208\t,'सल्यान')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (70,10,\t'DANG',\t3255\t,'दाङ')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (71,11,\t'BANKE',\t3295\t,'बाँके')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (72,11,\t'BARDIYA',\t3342\t,'बर्दिया')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (73,11,\t'SURKHET',\t3376\t,'सुर्खेत')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (74,11,\t'DAILEKH',\t3427\t,'दैलेख')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (75,11,\t'JAJARKOT',\t3487\t,'जाजरकोट')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (76,12,\t'DOLPA',\t3517\t,'डोल्पा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (77,12,\t'JUMLA',\t3540\t,'जुम्ला')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (78,12,\t'KALIKOT',\t3570\t,'कालीकोट')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (79,12,\t'MUGU',\t3599\t,'मुगु')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (80,12,\t'HUMLA',\t3623\t,'हुम्ला')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (81,13,\t'BAJURA',\t3649\t,'बाजुरा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (82,13,\t'BAJHANG',\t3676\t,'बझाङ')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (83,13,\t'ACHHAM',\t3723\t,'अछाम')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (84,13,\t'DOTI',\t3798\t,'डोटी')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (85,13,\t'KAILALI',\t3851\t,'कैलाली')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (86,14,\t'KANCHANPUR',\t3895\t,'कञ्चनपुर')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (87,14,\t'DADELDHURA',\t3915\t,'डडेलधुरा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into District (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (88,14,\t'BAITADI',\t3940\t,'बैतड')");
        }

        private void DefaultDataINsertInZone()
        {
            this.SQL.Remove(0, this.SQL.Length);
            this.SQL.Append("DELETE FROM ZONE");
            int del = GlobalResources.SelectDBConnection .ExecuteNonQuery(this.SQL.ToString());
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into ZONE (ZONEID,PARENTID,ZONENAME,SERIAL,NEPNAME) values (1,0,'MECHI',1,'मेची')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into ZONE (ZONEID,PARENTID,ZONENAME,SERIAL,NEPNAME) values (2,0,'KOSHI',193,'कोशी')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into ZONE (ZONEID,PARENTID,ZONENAME,SERIAL,NEPNAME) values (3,0,'SAGARMATHA',477,'सगरमाथा')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into ZONE (ZONEID,PARENTID,ZONENAME,SERIAL,NEPNAME) values (4,0,'JANAKPUR',915,'जनकपुर')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into ZONE (ZONEID,PARENTID,ZONENAME,SERIAL,NEPNAME) values (5,0,'BAGAMATI',1359,'वागमती')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into ZONE (ZONEID,PARENTID,ZONENAME,SERIAL,NEPNAME) values (6,0,'NARAYANI',1792,'नारायणी')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into ZONE (ZONEID,PARENTID,ZONENAME,SERIAL,NEPNAME) values (7,0,'GANDAKI',2164,'गण्डकी')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into ZONE (ZONEID,PARENTID,ZONENAME,SERIAL,NEPNAME) values (8,0,'DHAWALAGIRI',2454,'धवलागिरी')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into ZONE (ZONEID,PARENTID,ZONENAME,SERIAL,NEPNAME) values (9,0,'LUMBINI',2638,'लुम्बिनी')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into ZONE (ZONEID,PARENTID,ZONENAME,SERIAL,NEPNAME) values (10,0,'RAPTI',3065,'रापती')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into ZONE (ZONEID,PARENTID,ZONENAME,SERIAL,NEPNAME) values (11,0,'VERI',3295,'भेरी')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into ZONE (ZONEID,PARENTID,ZONENAME,SERIAL,NEPNAME) values (12,0,'KARNALI',3517,'र्कणाली')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into ZONE (ZONEID,PARENTID,ZONENAME,SERIAL,NEPNAME) values (13,0,'SETI',3649,'सेती')");
            GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into ZONE (ZONEID,PARENTID,ZONENAME,SERIAL,NEPNAME) values (14,0,'MAHAKALI',3895,'महाकाली')");
        }


        public void createAddressDataStructure()
        {
            StringBuilder SQLCreate = new StringBuilder();
            bool Status = false;
            int Rslt = 0;


            if (!GlobalResources.DbStruct .DoesTableExists("VDC"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE VDC(");
                SQLCreate.Append("\n  VDCID number PRIMARY KEY NOT NULL UNIQUE ");
                SQLCreate.Append("\n , DistrictID number (4)");
                SQLCreate.Append("\n , VDCNAME NVARCHAR2 (50)");
                SQLCreate.Append("\n , ZoneID number (4)");
                SQLCreate.Append("\n , SERIAL number (2)");
                SQLCreate.Append("\n , NEPNAME NVARCHAR2 (100)");
                SQLCreate.Append("\n , VDCCODE NVARCHAR2 (30))");
                Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery(SQLCreate.ToString());
                Status = true;
                LogTrace.WriteInfoLog(base.GetType().Name, MethodBase.GetCurrentMethod().Name, "VDC table created Successfully.  ");
            }
            if (!GlobalResources.DbStruct.DoesTableExists("Zone"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Zone( ");
                SQLCreate.Append(" \n ZoneID number PRIMARY KEY NOT NULL UNIQUE  ");
                SQLCreate.Append(" \n, PARENTID number ");
                SQLCreate.Append(" \n, ZoneNAME NVARCHAR2 ");
                SQLCreate.Append(" \n, SERIAL number ");
                SQLCreate.Append(" \n, NEPNAME NVARCHAR2 )");
                Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(base.GetType().Name, MethodBase.GetCurrentMethod().Name, "Zone table created Successfully. ");
                Status = true;
                this.DefaultDataINsertInZone();
            }
            else
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" SELECT 1 FROM zone ");
                if (GlobalResources.SelectDBConnection  .ExecuteDataTable(SQLCreate.ToString()).Rows.Count < 14)
                {
                    this.DefaultDataINsertInZone();
                }
            }
            if (!GlobalResources.DbStruct.DoesTableExists("District"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE District(");
                SQLCreate.Append("\n  DistrictID number PRIMARY KEY NOT NULL UNIQUE ");
                SQLCreate.Append("\n , ZoneID number (4)");
                SQLCreate.Append("\n , DistrictNAME NVARCHAR2 (50)");
                SQLCreate.Append("\n , SERIAL number (2)");
                SQLCreate.Append("\n , NEPNAME NVARCHAR2 (100))");
                Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery(SQLCreate.ToString());
                Status = true;
                LogTrace.WriteInfoLog(base.GetType().Name, MethodBase.GetCurrentMethod().Name, "District table created Successfully.  ");
                this.DefaultDataInsertInDistrict();
            }
            else
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" SELECT 1 FROM District ");
                if (GlobalResources.SelectDBConnection .ExecuteDataTable(SQLCreate.ToString()).Rows.Count < 0x4b)
                {
                    this.DefaultDataInsertInDistrict();
                }
            }

            if (!GlobalResources.DbStruct.DoesTableExists("NepalTree"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE NepalTree(");
                SQLCreate.Append("\n  ID number ");
                SQLCreate.Append("\n , PARENTID number (4)");
                SQLCreate.Append("\n , NAME NVARCHAR2 (70)");
                SQLCreate.Append("\n , SERIAL number (2)");
                SQLCreate.Append("\n , NEPNAME NVARCHAR2 (120)");
                SQLCreate.Append("\n , CODE NVARCHAR2 (30))");
                Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery(SQLCreate.ToString());
                Status = true;
                LogTrace.WriteInfoLog(base.GetType().Name, MethodBase.GetCurrentMethod().Name, "NepalTree table created Successfully.  ");
            }
            //if (!GlobalResources.DbStruct.DoesTableExists("VDC"))
            //{
            //    SQLCreate.Remove(0, SQLCreate.Length);
            //    SQLCreate.Append(" CREATE TABLE VDC(");
            //    SQLCreate.Append("\n  VDCID number PRIMARY KEY NOT NULL UNIQUE ");
            //    SQLCreate.Append("\n , DistrictID number (4)");
            //    SQLCreate.Append("\n , VDCNAME NVARCHAR2 (50)");
            //    SQLCreate.Append("\n , ZoneID number (4)");
            //    SQLCreate.Append("\n , SERIAL number (2)");
            //    SQLCreate.Append("\n , NEPNAME NVARCHAR2 (100)");
            //    SQLCreate.Append("\n , VDCCODE NVARCHAR2 (30))");
            //    DbHelpers.createATable(SQLCreate.ToString());

            //}


            //if (!GlobalResources.DbStruct.DoesTableExists("Zone"))
            //{
            //    SQLCreate.Remove(0, SQLCreate.Length);
            //    SQLCreate.Append(" CREATE TABLE Zone( ");
            //    SQLCreate.Append(" \n ZoneID number PRIMARY KEY NOT NULL UNIQUE  ");
            //    SQLCreate.Append(" \n, PARENTID number ");
            //    SQLCreate.Append(" \n, ZoneNAME NVARCHAR2 ");
            //    SQLCreate.Append(" \n, SERIAL number ");
            //    SQLCreate.Append(" \n, NEPNAME NVARCHAR2 )");
            //    DbHelpers.createATable(SQLCreate.ToString());

            //    DefaultDataINsertInZone();
            //}
            //else
            //{
            //    SQLCreate.Remove(0, SQLCreate.Length);
            //    SQLCreate.Append(" SELECT 1 FROM zone ");
            //    DataTable rs = GlobalResources.SelectDBConnection .ExecuteDataTable(SQLCreate.ToString());
            //    if (rs.Rows.Count < 14)
            //    {
            //        DefaultDataINsertInZone();
            //    }
            //}

            //if (!GlobalResources.DbStruct.DoesTableExists("District"))
            //{
            //    SQLCreate.Remove(0, SQLCreate.Length);
            //    SQLCreate.Append(" CREATE TABLE District(");
            //    SQLCreate.Append("\n  DistrictID number PRIMARY KEY NOT NULL UNIQUE ");
            //    SQLCreate.Append("\n , ZoneID number (4)");
            //    SQLCreate.Append("\n , DistrictNAME NVARCHAR2 (50)");
            //    SQLCreate.Append("\n , SERIAL number (2)");
            //    SQLCreate.Append("\n , NEPNAME NVARCHAR2 (100))");
            //    DbHelpers.createATable(SQLCreate.ToString());
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (15,1,'TAPLEJUNG',1,'tfKn]h''ª')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (16,1,'PANCHTHAR',49,'kfFry<')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (17,1,'ILAM',94,'Onfd')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (18,1,'JHAPA',142,'emfkf')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (19,2,'MORANG',193,'df]<ª')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (20,2,'SUNSARI',259,'''g<L')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (21,2,'DHANKUTA',311,'wgs''^f')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (22,2,'TERHATHUM',347,'t]x|y''d')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (23,2,'SANKHUWASABHA',378,'_v''jfef')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (24,2,'BHOJPUR',414,'ef]hk''<')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (25,3,'SOLUKHUMBU',477,'f]n''v''Da''')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (26,3,'OKHALDHUNGA',511,'cf]vn(''Ëf')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (27,3,'KHOTANG',565,'vf]^fª')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (28,3,'UDAYAPUR',641,'pbok''<')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (29,3,'SAPTARI',688,'Kt<L')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (30,3,'SIRAHA',803,'l<fxf')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (31,4,'DHANUSA',915,'wg''iff')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (32,4,'MAHOTARI',1018,'dxf]Q<L')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (33,4,'SARLAHI',1095,'nf{xL')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (34,4,'SINDHULI',1195,'lGw''nL')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (35,4,'RAMECHHAP',1250,'<fd]%fk')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (36,4,'DOLAKHA',1305,'bf]nvf')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (37,5,'SINDHUPALCHOKE',1359,'lGw''kfNrf]s')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (38,5,'KAVRE',1438,'sfe|]')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (39,5,'LALITPUR',1533,'nlntk''<')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (40,5,'BHAKTAPUR',1574,'etmk''<')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (41,5,'KATHMANDU',1596,'sf&df)*f}')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (42,5,'NUWAKOT',1663,'g''jfsf]^')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (43,5,'RASUWA',1724,'<''''jf')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (44,5,'DHADING',1742,'wflbª')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (45,6,'MAKWANPUR',1792,'dsjfgk''<')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (46,6,'RAUTAHAT',1836,'<f}tx^')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (47,6,'BARA',1937,'af<f')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (48,6,'PARSA',2042,'kf{')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (49,6,'CHITAWAN',2125,'lrtjg')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (50,7,'GORKHA',2164,'uf]<vf')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (51,7,'LAMJUNG',2232,'nDfh''ª')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (52,7,'TANAHU',2293,'tgx''')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (53,7,'SYANGJA',2338,':ofª\\hf')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (54,7,'KASKI',2406,'sf:sL')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (55,7,'MANANG',2454,'dgfª')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (56,8,'MUSTANG',2466,'d'':tfª')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (57,8,'MYAGDI',2482,'DofUbL')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (58,8,'PARBAT',2522,'kj{t')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (59,8,'BAGLUNG',2576,'afun''ª')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (60,9,'GULMI',2638,'u''NdL')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (61,9,'PALPA',2717,'kfNkf')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (62,9,'NAWALPARASI',2782,'gjnk<fL')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (63,9,'RUPANDEHI',2859,'?kGb]xL')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (64,9,'KAPILBASTU',2945,'slknj:t''')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (65,9,'ARGHAKHANCHI',3024,'c#f{vfFrL')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (66,10,'PYUTHAN',3065,'Ko''&fg')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (67,10,'ROLPA',3114,'<f]Nkf')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (68,10,'RUKUM',3165,'?s''d')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (69,10,'SALYAN',3208,'Nofg')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (70,10,'DANG',3255,'bfª')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (71,11,'BANKE',3295,'afFs]')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (72,11,'BARDIYA',3342,'alb{of')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (73,11,'SURKHET',3376,'''v]{t')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (74,11,'DAILEKH',3427,'b}n]v')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (75,11,'JAJARKOT',3487,'hfh<sf]^')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (76,12,'DOLPA',3517,'*f]Nkf')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (77,12,'JUMLA',3540,'h''Dnf')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (78,12,'KALIKOT',3570,'sfnLsf]^')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (79,12,'MUGU',3599,'d''u''')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (80,12,'HUMLA',3623,'x''Dnf')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (81,13,'BAJURA',3649,'afh''<f')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (82,13,'BAJHANG',3676,'aemfª')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (83,13,'ACHHAM',3723,'c%fd')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (84,13,'DOTI',3798,'*f]^L')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (85,13,'KAILALI',3851,'s}nfnL')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (86,14,'KANCHANPUR',3895,'s~rgk''<')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (87,14,'DADELDHURA',3915,'**]nw''<f')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (88,14,'BAITADI',3940,'a}t*L')");
            //    //Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery("Insert into DISTRICT (DISTRICTID,ZONEID,DISTRICTNAME,SERIAL,NEPNAME) values (89,14,'DARCHULA',4008,'bfr''{nf')");




            //}
        }
    }
}
