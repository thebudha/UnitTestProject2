using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.ultimateqa.com");
            string pageTitle = driver.Title;

            Assert.AreEqual("Homepage - Ultimate QA", pageTitle);

            Thread.Sleep(5000);
            driver.Close();

        }
    }
}
