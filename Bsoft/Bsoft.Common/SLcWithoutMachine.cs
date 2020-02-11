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
    public static class skgenNoMachine
    {
        public static bool isKey(string key,string temp)
        {
            if (key == GetCode( temp ))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

   

        public static string GetCode(string temp)
        {
            HashAlgorithm Hash = default(HashAlgorithm);
            byte[] HashBytes = null;
            //string tem = null;
            UnicodeEncoding UNIEncoding = new UnicodeEncoding();

            string _CustRef = null;

            Hash = new MD5CryptoServiceProvider();
            HashBytes = Hash.ComputeHash(UNIEncoding.GetBytes(temp));

            _CustRef = System.Convert.ToBase64String(HashBytes);
            //if longer than 20 chars, trim it to 20 chars
            if (_CustRef.Trim().Length > 20) _CustRef = _CustRef.Substring(0, 20);

            //convert it to upper case
            _CustRef = _CustRef.ToUpper();
            _CustRef = reverseAndPutDash(_CustRef);
            return _CustRef;
        }

        private static  string reverseAndPutDash(string sin)
        {
            string s = "";
            for (int i = sin.Length  - 1; i >= 0; i--)
            {
                s = s+sin[i].ToString ();
                if (i%5 == 0 && i >1)
                {
                    s=s+"-";
                }
            }
            return s;
        }
    }
}
