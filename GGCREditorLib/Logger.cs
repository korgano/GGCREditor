using System;
using System.Configuration;
using System.IO;

namespace GGCREditorLib
{
    public enum LogLevel { Off, Debug, Edits }

    public static class Logger
    {
        private static string logFilePath;
        private static LogLevel currentLevel = LogLevel.Off;

        public static LogLevel CurrentLevel
        {
            get { return currentLevel; }
            set { currentLevel = value; }
        }

        private static string LogFilePath
        {
            get
            {
                if (logFilePath == null)
                {
                    string exeDir = AppDomain.CurrentDomain.BaseDirectory;
                    logFilePath = Path.Combine(exeDir, "ggcr_editor.log");
                }
                return logFilePath;
            }
        }

        public static void Initialize()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (config.AppSettings.Settings["logLevel"] != null)
                {
                    string value = config.AppSettings.Settings["logLevel"].Value;
                    currentLevel = (LogLevel)Enum.Parse(typeof(LogLevel), value, true);
                }
            }
            catch { }
        }

        public static void SaveToConfig()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (config.AppSettings.Settings["logLevel"] == null)
                {
                    config.AppSettings.Settings.Add("logLevel", currentLevel.ToString());
                }
                else
                {
                    config.AppSettings.Settings["logLevel"].Value = currentLevel.ToString();
                }
                config.Save();
            }
            catch { }
        }

        public static void Log(string message)
        {
            if (currentLevel == LogLevel.Off) return;
            WriteLog("LOG", message);
        }

        public static void LogDebug(string message)
        {
            if (currentLevel != LogLevel.Debug) return;
            WriteLog("DEBUG", message);
        }

        public static void LogEdit(string message)
        {
            if (currentLevel == LogLevel.Off) return;
            if (currentLevel != LogLevel.Edits && currentLevel != LogLevel.Debug) return;
            WriteLog("EDIT", message);
        }

        public static void LogEdit(string message, bool isEditOperation)
        {
            if (currentLevel == LogLevel.Off) return;
            string level = (currentLevel == LogLevel.Debug || isEditOperation) ? "EDIT" : "DEBUG";
            WriteLog(level, message);
        }

        private static void WriteLog(string level, string message)
        {
            try
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string logEntry = string.Format("[{0}] [{1}] {2}", timestamp, level, message);
                File.AppendAllText(LogFilePath, logEntry + Environment.NewLine);
            }
            catch { }
        }

        public static void LogFormat(string format, params object[] args)
        {
            string message = string.Format(format, args);
            Log(message);
        }

        public static void LogDebugFormat(string format, params object[] args)
        {
            string message = string.Format(format, args);
            LogDebug(message);
        }

        public static void LogEditFormat(string format, params object[] args)
        {
            string message = string.Format(format, args);
            LogEdit(message);
        }
    }
}