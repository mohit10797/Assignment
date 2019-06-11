using System;
using System.IO;

namespace PayRollLib
{
    public class BusinessRules
    {
        public static bool CheckDate(string Date)
        {
            return (Convert.ToDateTime(Date).Year < 2018);
        }
        public static double SalaryIncreament(string salary)
        {
            return (Convert.ToDouble(salary) * 1.1);
        }
        public static bool CheckFile(string filePath)
        {
            return File.Exists(filePath);
        }
        public static string[] ReadFile(string filePath)
        {
            return File.ReadAllLines(filePath);
        }
        public static string ReadLines(string line)
        {
            line = line.Replace("\r\n", "");
            return line;
        }
    }
}
