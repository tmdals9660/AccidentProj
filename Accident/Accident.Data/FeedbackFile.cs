using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accident.Data
{
    public class FeedbackFile
    {
        private const string FilePath = @"d:\Propose.log";

        public void WritePropose(string propose1, string propose2, string propose3)
        {
            string contents;
            if (File.Exists(FilePath))
                contents = File.ReadAllText(FilePath);
            else
                contents = "";

            string time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            string formattedLog = $"[{time}]\r\n{propose1}\r\n{propose2}\r\n{propose3}\r\n------------------------------\r\n\r\n";

            contents = formattedLog + contents;

            File.WriteAllText(FilePath, contents);
        }
    }
}
