using System;
using System.IO;
using System.Text;

namespace p2p_Chat
{
    public static class HistoryLogger
    {
        private static readonly string LogFile = "chat_history.txt";
        private static readonly object lockObj = new object();

        public static void Log(string message)
        {
            var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string logLine = $"[{timestamp}] {message}";

            lock (lockObj)
            {
                try
                {
                    using (var stream = new FileStream(LogFile, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
                    using (var writer = new StreamWriter(stream, Encoding.UTF8))
                    {
                        writer.WriteLine(logLine);
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Ошибка при записи в лог: {ex.Message}");
                }
            }

            Console.WriteLine(logLine);
        }
    }
}
