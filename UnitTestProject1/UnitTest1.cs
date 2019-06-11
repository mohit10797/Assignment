using System;
using FileReadWriteLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayRollLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckFileTestMethod()
        {
            Assert.AreEqual(true, BusinessRules.CheckFile(‪@"C:\Users\Mohit\Desktop\test.txt"));
        }

        [TestMethod]
        public void ReadFileTestMethod()
        {
            String[] Result = new String();
            Result = FileOperation.ReadFile(@"‪C:\Users\Mohit\Desktop\test.txt");
            Assert.AreEqual(4, Result.Length);
        }

        [TestMethod]
        public void CheckDateTestMethod()
        {
            Assert.AreEqual(true, BusinessRules.CheckDate("10-12-2017"));
        }

        [TestMethod]
        public void SalaryIncreamentTestMethod()
        {
            string salary= "4000";
            double Result;
            Assert.AreEqual(4400, CalculatePaySlip.SalaryIncreament(salary));
        }

        //[TestMethod]
        //public void WriteFileTestMethod()
        //{
        //    string filepath = @"E:\testfile.txt";
        //    string Result,ExpResult;
        //    ExpResult = "101\tsahil\t10-12-2017\t30000\t33000\r\n102\tankur\t11-07-2016\t40000\t44000\r\n102\tankur\t21-07-2018\t40000\t40000\r\n";
        //    Result = FileOperation.WriteFile(filepath);
        //    Assert.AreEqual(ExpResult, Result);
        //}
    }
}
