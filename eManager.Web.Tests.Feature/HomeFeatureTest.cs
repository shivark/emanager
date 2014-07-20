using eManager.Web.Tests.Feature;
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

//        IWebDriver driver;

        [TestFixtureSetUp]
        public void TestSetUp()
        {
//            // the same way we can setup webDriver to use other browsers
//            driver = new FirefoxDriver();
//
//            // set the timeout after page load to 30sec<span class="searchterm3">on</span>ds
//            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));

        }

        [Test]
        [Ignore]
        public void TestMethod1()
        {

//            driver.Navigate().GoToUrl("http://www.wedoqa.com");
//            Assert.AreEqual("WeDoQA", driver.Title);
        }
        [Test]
        public void ShouldDisplayLogo()
        {
            var homePage = ConsumerPages.Home;

            homePage.Visit();

            Assert.IsNotNull(homePage.Logo);
        }

        [TestFixtureTearDown]
        public void FixtureTearDown()
        {
            // closes every window associated with this driver
            //driver.Quit();
        }
    }

    public static class ConsumerPages
    {
        static readonly IWebDriver driver;
        static ConsumerPages()
        {
            driver = new FirefoxDriver(); 
        }

        public static Page Home
        {
            get
            {
                return new Home(driver);
            }
        }
    }

    public class Page
    {
        private readonly IWebDriver _driver;

        public Page(IWebDriver driver)
         {
             _driver = driver;
         }
    
        public string Url
        {
            get { return "http://localhost"; }
        }

        public IWebElement Logo
        {
            get { return _driver.FindElement(By.Id("logo")); }
        }

        public void Visit()
        {
            _driver.Navigate().GoToUrl(Url);
        }
    }

    public class Home : Page
    {
        public Home(IWebDriver driver) : base(driver)
        {
        }
    }

    
}
