using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Xunit;

namespace eCom.Tests
{
    public class LoginTest
    {
        [Fact]
        public void StartApplication()
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                //driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("http://localhost:53973/");

                Assert.Equal("Home Page - My ASP.NET Application", driver.Title);
            }
        }

        [Fact]
        public void SubmitApplication()
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                //driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("http://localhost:53973/Account/Login");

                IWebElement firstNameInput = driver.FindElement(By.Id("Email"));
                firstNameInput.SendKeys("Fredrik@Olsson.com");

                driver.FindElement(By.Id("Password")).SendKeys("Blabla");

                driver.FindElement(By.XPath("//*[@type='submit'][@value='Log in']")).Click();
                //driver.FindElement(input[@name='action') and @value=' Search ']).Click();


                //Assert.Equal("Home Page - My ASP.NET Application", driver.Title);
            }
        }
    }
}
