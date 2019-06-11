using System;
namespace PayrollProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileLib.FileMethod.WriteFile(@"C: \Users\Mohit\Desktop\test.txt", @"C: \Users\Mohit\Desktop\testresult.txt");
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            }
    }
}
