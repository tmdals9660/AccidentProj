using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accident.Data
{
    class DbContextFactory
    {
        private const string FilePath = @"d:\EF.log";

        private static readonly string[] PrefixList = { "SELECT", "INSERT", "UPDATE", "DELETE" };

        private static void Write(string log)
        {
            for (int i = 0; i < PrefixList.Length; i++)
            {
                if (log.StartsWith(PrefixList[i]))
                {
                    //
                }
            }

            string contents;
            if (File.Exists(FilePath))
                contents = File.ReadAllText(FilePath);
            else
                contents = "";

            string time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            string formattedLog = $"[{time}]\r\n{log}\r\n------------------------------\r\n\r\n";

            contents = formattedLog + contents; 

            File.WriteAllText(FilePath, contents);
        }

        public const string RawConnectionString = "Data Source=210.119.12.52;Initial Catalog=Accident;Persist Security Info=True;User ID=sa;Password=1";

        private static string ConnectionString
        {
            get
            {
                return "metadata=res://*/Accident.csdl|res://*/Accident.ssdl|res://*/Accident.msl;provider=System.Data.SqlClient;provider connection string=\"" + RawConnectionString + ";App=EntityFramework\"";
            }
        }

        public static AccidentEntities Create()
        {
            AccidentEntities context = new AccidentEntities(ConnectionString);

            context.Database.Log = Write;

            return context;
        }

      
    }
}
