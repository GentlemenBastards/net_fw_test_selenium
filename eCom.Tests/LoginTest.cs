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
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("http://localhost:53973/");

                //                IWebElement applicationButton = driver.FindElement(By.Id("startApplication"));

                //                applicationButton.Click();

                Assert.Equal("Home Page - My ASP.NET Application", driver.Title);
            }
        }

        [Fact]
        public void SubmitApplication()
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("http://localhost:53973/Home/StartLoanApplication");

                IWebElement firstNameInput = driver.FindElement(By.Id("FirstName"));
                firstNameInput.SendKeys("Sarah");

                driver.FindElement(By.Id("LastName")).SendKeys("Smith");


                driver.FindElement(By.Id("Loan")).Click();


                driver.FindElement(By.Name("TermsAcceptance")).Click();
            }
        }

    }
}
