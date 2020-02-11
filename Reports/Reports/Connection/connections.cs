using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Friuts;
using System.Windows.Forms;
using Bsoft.Data;

namespace Reports
{
    public static class connections
    {
        public  static void EstablishDBConnection(string connectionString)
        {
            GlobalResourcesFx.SelectDBConnection = new DBConnect(connectionString);
            if (!Friuts.GlobalResourcesFx.SelectDBConnection.Open())
            {

                MessageBox.Show("Unable to establish DB \nPlease check the Database Server statur or Contact the administrator.");
                Application.Exit();
            }

           // LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "DB connection opened successfully.");
        }

       
    }
}
