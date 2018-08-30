using Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLogger
{
    public class Log : ILog
    {
        public void LogException(string message)
        {
            string fileName = string.Format("{0}.txt", "Exception");
            string logFilePath = string.Format(@"{0}", @"D:\Exception");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            if (!Directory.Exists(logFilePath))
                Directory.CreateDirectory(logFilePath);
             using (StreamWriter writer = new StreamWriter( logFilePath,true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }

    }
}
