using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Bsoft.Data;

namespace Bsoft.AppCom
{
    public static class CommandsClass
    {
        public static bool updateDb = false;
        public static bool refreshMenu = false;
        public static bool deletViews = false;

        public static List<string> Commands = new List<string>();

        public static void RenameCommand()
        {
            if (File.Exists("commands.fdb"))
            {
                System.IO.File.Copy("commands.fdb", "_commands.fdb", true);
                System.IO.File.Delete("commands.fdb");
            }
        }

        static CommandsClass()
        {
            try
            {
                string[] coms = File.ReadAllLines(Path.GetDirectoryName(Application.ExecutablePath) + "\\commands.fdb");
                foreach (string com in coms)
                {
                    if (!com.StartsWith("--"))
                    {
                        Commands.Add (com.ToLower ());
                    }
                }
            }
            catch
            {

            }
        }

        public static void ExcuteFileOnceAndRename(string filename)
        {
            if (File.Exists(filename))
            {
                string sql = System.IO.File.ReadAllText(filename);
                GlobalResources.SelectDBConnection.ExecuteNonQuery(sql);
                System.IO.File.Copy(filename, "_" + filename, true);
                System.IO.File.Delete(filename);
            }

        }

        public static void DeleteFile(string filename)
        {
            if (File.Exists(filename))
            {
                System.IO.File.Delete(filename);
            }

        }
    }
}
