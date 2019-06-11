using System;
using FileLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayRollLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckFileTest()
        {
            Assert.AreEqual(true, BusinessRules.CheckFile(‪"C:\\Users\\Mohit\\Desktop\\test.txt"));
        }

        [TestMethod]
        public void ReadFileTest()
        {

            String[] Result = FileMethod.ReadFile(@"‪C:\Users\Mohit\Desktop\test.txt");
            Assert.AreEqual(2, Result.Length);
        }

        [TestMethod]
        public void CheckDateTest()
        {
            Assert.AreEqual(true, BusinessRules.CheckDate("10-12-2017"));
        }

        [TestMethod]
        public void SalaryIncreamentTest()
        {
            Assert.AreEqual(4400, BusinessRules.SalaryIncreament("4000"));
        }
    }
}
