using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpTutorial.Baseclass;

namespace SeleniumCSharpTutorial
    
{
    [TestFixture]
    public class Tests:BaseTest
    {
       

        [Test,Category("Smoke Testing")]
        public void Test1()
        {
           // IWebDriver driver = new ChromeDriver();
            //driver.Url = "https://login.salesforce.com";
            IWebElement username = driver.FindElement(By.XPath("//input[@id='username']"));
            username.SendKeys("amohanty@cunning-unicorn-ft3w5u.com");
            //driver.Quit();
            IWebElement monthDropdownList = driver.FindElement(By.XPath("//*input[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(1);
            element.SelectByText("Mar");
            element.SelectByValue("6");


        }
        [Test, Category("Regression Testing")]
        public void Test2()
        {           
            IWebElement username = driver.FindElement(By.XPath("//input[@id='username']"));
            username.SendKeys("amohanty@cunning-unicorn-ft3w5u.com");            
        }
        [Test, Category("Smoke Testing")]
        public void Test3()
        {
            IWebElement username = driver.FindElement(By.XPath("//input[@id='username']"));
            username.SendKeys("amohanty@cunning-unicorn-ft3w5u.com");
        }
        [Test]
        public void Test4()
        {
            IWebElement username = driver.FindElement(By.XPath("//input[@id='username']"));
            username.SendKeys("amohanty@cunning-unicorn-ft3w5u.com");
            Thread.Sleep(5000);
        }
    }
}