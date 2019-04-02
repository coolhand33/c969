using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleIt
{
    public class Logger
    {
        private static StreamWriter fileWriter;

        public Logger()
        {

        }

        public static void writeToLog(string userName, string action, string status)
        {
            var logMsg = $"{DateTime.Now}\r\nUSER: {userName}\r\nACTION: {action}\r\nSTATUS: {status}\r\n";
            try
            {
                using (StreamWriter fileWriter = new StreamWriter(@"AccessLog.txt", true))
                { 

                    fileWriter.WriteLine(logMsg);
                    fileWriter?.Close();
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
