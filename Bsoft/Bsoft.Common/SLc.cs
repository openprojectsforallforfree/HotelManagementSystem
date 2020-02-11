using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.Security.Cryptography;
 
using System.Windows.Forms;


namespace Bsoft.Common
{
    //frm register => set key ,check key
    //orgdegail => check key if not set org name = > test company
    //Other => check key + count 
    public class skgen
    {
        public static string buildDetail = "";
        //all private
        #region Hrwr
        /// <summary>
        /// For each machine a different key is generated
        /// 
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="companyName"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        private static string getKeyMachine()
        {

            System.Collections.ArrayList divices = new System.Collections.ArrayList();
            string temp = null;
            divices = getinfo("Win32_DiskDrive");
            string val = null;
            val = "IDE";
            for (int i = 0; i <= divices.Count - 1; i++)
            {
                System.Collections.Generic.Dictionary<string, string> values = new System.Collections.Generic.Dictionary<string, string>();
                values = (System.Collections.Generic.Dictionary<string, string>)divices[i];
                if (val == values["InterfaceType"].ToUpper())
                {
                    string _DiskSerial = buildstring(values);
                    temp = _DiskSerial + "justkey";
                    temp = GenerateCodes(temp);
                    return temp;

                }
            }
            //KNOUDL4Fr4GuV5gul7Crhg==
            //np8qDI7cWv4hCql3bQGTjw==
            //nhC2O7NiTbPXowJqFMFRZw==
            return "NOTAVAILABLE";
        }

        private static string buildstring(System.Collections.Generic.Dictionary<string, string> values)
        {
            string a = "";
            try
            {
                a += values["Caption"];
                a += values["BytesPerSector"];
                a += values["Manufacturer"];
                a += values["PNPDeviceID"];
                a += values["Model"];
                a += values["Size"];
                a += values["SectorsPerTrack"];
                a += values["TotalCylinders"];
                a += values["TotalHeads"];
                a += values["TotalSectors"];
                a += values["TotalTracks"];

                a += values["TracksPerCylinder"];
            }
            catch
            {

                return "Not registrable";
            }

            //drivekonam
            //BytesPerSector
            //Capabilities
            //CapabilityDescriptions
            //Caption
            //ConfigManagerErrorCode
            //ConfigManagerUserConfig
            //CreationClassName
            //Description
            //DeviceID
            //FirmwareRevision
            //Index
            //InterfaceType
            //Manufacturer
            //MediaLoaded
            //MediaType
            //Model
            //Name
            //Partitions
            //PNPDeviceID
            //SCSIBus
            //SCSILogicalUnit
            //SCSIPort
            //SCSITargetId
            //SectorsPerTrack
            //SerialNumber
            //Signature
            //Size
            //Status
            //SystemCreationClassName
            //SystemName
            //TotalCylinders
            //TotalHeads
            //TotalSectors
            //TotalTracks
            //TracksPerCylinder


            return a;
        }

        private static System.Collections.ArrayList getinfo(string Key)
        {
            System.Collections.ArrayList devices = new System.Collections.ArrayList();

            string name = "";
            string lst = "";
            //'Win32_DiskDrive
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + Key);
            try
            {
                foreach (ManagementObject share in searcher.Get())
                {

                    System.Collections.Generic.Dictionary<string, string> values = new System.Collections.Generic.Dictionary<string, string>();

                    // ListViewGroup grp;
                    //Region "drive name"
                    try
                    {
                        lst = share["Name"].ToString();
                        values.Add("drivekonam", lst);
                    }
                    catch
                    {
                        lst = share.ToString();
                        values.Add("drivekonam", lst);
                    }

                    if (share.Properties.Count <= 0)
                    {
                        // MessageBox.Show("No Information Available", "No Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return null;
                    }
                    //End Region

                    foreach (PropertyData PC in share.Properties)
                    {
                        name = PC.Name;
                        //Region "if"


                        if (PC.Value != null && !string.IsNullOrEmpty(PC.Value.ToString()))
                        {
                            switch (PC.Value.GetType().ToString())
                            {
                                case "System.String[]":
                                    string[] str = (string[])PC.Value;

                                    string str2 = "";
                                    foreach (string st in str)
                                    {
                                        str2 += st + " ";
                                    }


                                    lst = str2;

                                    break;  


                                case "System.UInt16[]":
                                    ushort[] shortData = (ushort[])PC.Value;


                                    string tstr2 = "";
                                    foreach (ushort st in shortData)
                                    {
                                        tstr2 += st.ToString() + " ";
                                    }


                                    lst = tstr2;

                                    break;  


                                default:

                                    lst = PC.Value.ToString();
                                    break;  


                            }
                            values.Add(name, lst);
                        }
                        //End Region
                    }
                    devices.Add(values);
                }
            }
            catch
            {

            }

            // MessageBox.Show("can't get data because of the followeing error \n" + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return devices;
        }
        /// <summary>
        /// Generate a unique no for each usb drive and put ke in code itself then compile exe then distribute.
        /// Change later
        /// </summary>
        private static bool isKeyUSB(string keya, string regKey)
        {

            System.Collections.ArrayList divices = new System.Collections.ArrayList();
            string temp = null;
            divices = getinfo("Win32_DiskDrive");
            string val = null;

            val = "USB";

            for (int i = 0; i <= divices.Count - 1; i++)
            {
                System.Collections.Generic.Dictionary<string, string> values = new System.Collections.Generic.Dictionary<string, string>();
                values = (System.Collections.Generic.Dictionary<string, string>)divices[i];


                if (val == values["InterfaceType"].ToUpper())
                {
                    string _DiskSerial = buildstring(values);
                    buildDetail = _DiskSerial;
                    temp = regKey + _DiskSerial;
                    temp = temp.Replace(" ", "");
                    temp = GenerateCodes(temp);
                    if (temp == keya)
                    {
                        return true;
                    }
                    else
                    {
                    }
                }
            }
            //KNOUDL4Fr4GuV5gul7Crhg==
            //np8qDI7cWv4hCql3bQGTjw==
            //nhC2O7NiTbPXowJqFMFRZw==

            MessageBox.Show("Not Registered");
            Application.Exit();

            return false;
        }
        #endregion

        //enctr
        public static string GenerateCodes(string temp)
        {
            temp = temp.Replace(" ", "");//than a
            //generate Reference based on 
            //appname,password,and harddisk serial
            //generate serial key based on Reference
            HashAlgorithm Hash = default(HashAlgorithm);
            byte[] HashBytes = null;
            //string tem = null;
            UnicodeEncoding UNIEncoding = new UnicodeEncoding();

            string _CustRef = null;
            //Select Case _HashAlgorithm
            //    Case HashAlgorithms.MD5
            //        Hash = New MD5CryptoServiceProvider
            //    Case HashAlgorithms.SHA1
            //        Hash = New SHA1CryptoServiceProvider
            //    Case HashAlgorithms.SHA256
            //        Hash = New SHA256Managed
            //    Case HashAlgorithms.SHA384
            //        Hash = New SHA384Managed
            //    Case HashAlgorithms.SHA512
            //        Hash = New SHA512Managed
            //    Case Else 'default hash algorithm
            //        Hash = New MD5CryptoServiceProvider
            //End Select
            Hash = new MD5CryptoServiceProvider();
            HashBytes = Hash.ComputeHash(UNIEncoding.GetBytes(temp));

            _CustRef = System.Convert.ToBase64String(HashBytes);
            //if longer than 20 chars, trim it to 20 chars
            if (_CustRef.Trim().Length > 20) _CustRef = _CustRef.Substring(0, 20);

            //convert it to upper case
            _CustRef = _CustRef.ToUpper();

            return _CustRef;
        }

        #region Helper
        //Idea is to store the build dettail (hwl code etc for the machine if registered successfully
        public static string GetGegLockMachine(string inkey)
        {
            string reglc = inkey + " " + getKeyMachine();
            return reglc;
        }

        #endregion
    }

    //List<CheckerObject> chks = new List<CheckerObject>(){ 
    //            new CheckerObject() {count  =0,AdvLimiit =0},
    //            new CheckerObject() {count  =0,AdvLimiit =0}};
    public static class keys
    {
        //Idea is to store the build dettail (hwl code etc for the machine if registered successfully
        /// <summary>
        /// use this always 
        /// </summary>
        /// <param name="companyName"></param>
        /// <param name="companyLocation"></param>
        /// <param name="ProductName"></param>
        /// <param name="ProductVersion"></param>
        /// <returns></returns>
        public static string GetGegLockMachine(string companyName, string companyLocation, string ProductName, string ProductVersion)
        {
            return skgen.GetGegLockMachine(companyName + " " + companyLocation + " " + ProductName + " " + ProductVersion);
        }

        public static RegType getRegType(string inputString, string key)
        {
            if (key.Length < 20)
            {
                return RegType.Unreg;
            }
            if (key == getKey(RegType.Adv, inputString))
            {
                return RegType.Adv;
            }
            else if (key == getKey(RegType.Full, inputString))
            {
                return RegType.Full;
            }
            else
            {
                return RegType.Unreg;
            }

        }
        //keygen
        public static string getKey(RegType regtype, string inputstring)
        {

            if (regtype == RegType.Adv)
            {
                return skgen.GenerateCodes(inputstring + "");

            }

            else if (regtype == RegType.Full)
            {
                return skgen.GenerateCodes(inputstring + "seedFull");

            }
            else { return ""; }
        }

        public static bool stopApplication(List<CheckerObject> checkers, string instring, string key,ref string message)
        {
            RegType keytype = getRegType(instring, key);
            if (keytype == RegType.Full)
            {
                return false;
            }
             
            bool stopApp = false;
            foreach (CheckerObject chk in checkers)
            {
                switch (keytype)
                {
                    case RegType.Unreg:
                        if (chk.count > chk.unRegLimitMessageStart && chk.count < chk.AdvLimiitMessageStart)
                        {
                            message = chk.unRegLimitMessage;
                        }
                        if (chk .count > chk.unRegLimit )
                        {
                            message = chk.LimitCrossMessage;
                            stopApp = true;
                        }
                        break;
                    case RegType.Adv:
                        if (chk.count > chk.AdvLimiitMessageStart && chk.count < chk.advLimit )
                        {
                           message =chk.AdvLimiitMessage;
                        }
                        if (chk.count > chk.advLimit)
                        {
                           message =chk.LimitCrossMessage;
                            stopApp = true;
                        }
                        break;
                }
            }
            //if (message .Length >0)
            //{
            //    MessageBoxMy.Show(message );
            //}
            return stopApp;
        }
    }

    public class CheckerObject
    {
        public string tableName = "test";
        public int unRegLimit = 100;
        public int advLimit = 400;
        public int count = 0;
        public int unRegLimitMessageStart = 0;
        public int AdvLimiitMessageStart = 300;
        public string unRegLimitMessage = "Please register soon to continue using this application.";
        public string AdvLimiitMessage = "Please contact admin soon to continue using this application.";
        public string LimitCrossMessage = "Please contact admin to continue using this application.";
    }

    public enum RegType
    {
        Unreg = 0,
        Adv = 1,
        Full = 2
    }


}
