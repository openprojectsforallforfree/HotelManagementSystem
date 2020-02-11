using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsoft.AppCom;
using Bsoft.Common;

namespace RestoSys
{
    public static class ApplicationSetting
    {

        private static int vatPercent = -1;
        private static int serviceChargePercent = -1;
        private static bool printBill;
        private static string  backupFolder;

        static ApplicationSetting()
        {
            printBill = ConstantValuesUtility.GetData("PrintBilll").ToLower() == "true" ? true : false;
            vatPercent = ConstantValuesUtility.GetData("VATPercent").ToInt();
            serviceChargePercent = ConstantValuesUtility.GetData("ServiceChargePercent").ToInt();
            backupFolder = ConstantValuesUtility.GetData("BackupFolder").ToString ();
        }

        public static int VatPercent
        {
            get
            {
                return vatPercent;
            }
            set
            {
                vatPercent = value;
                ConstantValuesUtility.SetData("VATPercent", vatPercent.ToString());
            }
        }

        public static int ServiceChargePercent
        {
            get
            {
                return serviceChargePercent;
            }
            set
            {
                serviceChargePercent = value;
                ConstantValuesUtility.SetData("ServiceChargePercent", serviceChargePercent.ToString());
            }
        }

        public static bool PrintBilll
        {
            get
            {
                return printBill;
            }
            set
            {
                printBill = value;
                ConstantValuesUtility.SetData("PrintBilll", value.ToString());
            }
        }
        public static string  BackUpFolder
        {
            get
            {
                return backupFolder;
            }
            set
            {
                backupFolder = value;
                ConstantValuesUtility.SetData("BackupFolder", value.ToString());
            }
        }

    }
}
