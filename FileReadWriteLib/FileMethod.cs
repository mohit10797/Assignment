using PayRollLib;
using System;
using System.IO;

namespace FileLib
{
    public class FileMethod
    {
        static string writeText = string.Empty;
        static string[] str_Array;
        public static string[] ReadFile(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string text = sr.ReadToEnd();
                string[] lines = text.Replace("\r\n", "\n").Split("\n".ToCharArray());
                return lines;
            }
           
        }
     public static void  WriteFile(string filePath, string outputPath)
        {
            try {
                
                    foreach (var Line in ReadFile(filePath))
                    {
                       
                            str_Array = BusinessRules.ReadLines(Line).Split('\t');
                            if (BusinessRules.CheckDate(str_Array[2]))
                                writeText += BusinessRules.ReadLines(Line) + "\t" + BusinessRules.SalaryIncreament(str_Array[3]) + "\r\n";
                            else
                                writeText += BusinessRules.ReadLines(Line) + "\t" + str_Array[3] + "\r\n";
                        
                    }

                File.AppendAllText(outputPath, writeText.ToString());
    
            }
            catch(Exception ex)
            {
                throw ex;
            }
            }
    }
}