using System;
using System.IO;

namespace klggr
{
    class Program
    {
        static void Main()
        {

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    char key = keyInfo.KeyChar;

                    LogWrite(key);

                }
            }
        }
        static void LogWrite(char message)
        {
            string dyol = AppDomain.CurrentDomain.BaseDirectory + "/Logs";
            if (!Directory.Exists(dyol))
            {
                Directory.CreateDirectory(dyol);
            }
            string txtyol = AppDomain.CurrentDomain.BaseDirectory + "/Logs/KLG.txt";
            if (!File.Exists(txtyol))
            {
                using (StreamWriter sv = File.CreateText(txtyol))
                {
                    sv.Write(message);
                }
            }
            else
            {
                using (StreamWriter sv = File.AppendText(txtyol))
                {
                    sv.Write(message);
                }
            }
        }
    }
}
