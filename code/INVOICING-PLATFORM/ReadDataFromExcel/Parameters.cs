using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace ReadDataFromExcel
{
    public static class Parameters
    {
        public static string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
        public static string exeDir = Path.GetDirectoryName(exeFile);
        public static string serialPath = Path.GetFullPath(Path.Combine(exeDir, "serialCounter.txt"));
        public static string excelFilePath = "";
        public static string city = "";
        public static DateTime now = DateTime.Now;
        public static string year = now.Year.ToString();
        public static int serialNum = 00000006; // Default value, will be overwritten by static constructor

        // Static constructor
        static Parameters()
        {
            try
            {
                // Read the first line from the file
                if (File.Exists(serialPath))
                {
                    string firstLine = File.ReadLines(serialPath).FirstOrDefault();
                    if (int.TryParse(firstLine, out int serial))
                    {
                        serialNum = serial; // Set serialNum to the value from the file
                    }
                    else
                    {
                        Console.WriteLine("The file does not contain a valid integer on the first line.");
                    }
                }
                else
                {
                    Console.WriteLine($"The file {serialPath} does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }
        }
    }
}
