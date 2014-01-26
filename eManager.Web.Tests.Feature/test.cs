using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;


namespace eManager.Web.Tests.Feature
{
    [TestFixture]
    public class UnitTest1
    {

        IWebDriver driver;

        [TestFixtureSetUp]
        public void TestSetUp()
        {
            // the same way we can setup webDriver to use other browsers
            driver = new FirefoxDriver();

            // set the timeout after page load to 30sec<span class="searchterm3">on</span>ds
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));

        }

        [Test]
        public void TestMethod1()
        {

            driver.Navigate().GoToUrl("http://www.wedoqa.com");

            Assert.AreEqual("WeDoQA", driver.Title);
        }

        [TestFixtureTearDown]
        public void FixtureTearDown()
        {
            // closes every window associated with this driver
            driver.Quit();
        }
    }
}
