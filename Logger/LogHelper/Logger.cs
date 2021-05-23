using System;
using System.IO;
using System.Configuration;

namespace LogHelper
{
    public class Logger : ILogger
    {
        public string logPath { get; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigurationManager.AppSettings["logPath"]);
        public void log(string errorMessage)
        {
            DateTime now = DateTime.Now;
            File.AppendAllText(logPath, string.Concat(now.ToString()," ",errorMessage, Environment.NewLine));
        }
    }
}
