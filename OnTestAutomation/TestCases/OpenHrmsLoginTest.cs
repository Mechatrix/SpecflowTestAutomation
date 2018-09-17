using NUnit.Framework;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Support.PageObjects;

using OnTestAutomation.PageObject;



namespace OnTestAutomation.TestCases

{

    class OpenHRMSLoginTest

    {

        [Test]

        public void LoginTest()

        {

            //Initializes webdriver

            IWebDriver driver = new ChromeDriver();

            driver.Url = "http://www.openhrms.com/";



            //Creates object for Login page

            var loginPage = new LoginPage();



            //Initializes Login page objects with Page Factory concept

            PageFactory.InitElements(driver, loginPage);



            //Calls Login page methods

            loginPage.EnterUsername("Admin");

            loginPage.EnterPassword("admin");

            loginPage.SelectRole("Admin");

            loginPage.ClickSiginIn();

        }

    }

}