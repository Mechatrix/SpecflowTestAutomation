using OpenQA.Selenium;

using OpenQA.Selenium.Support.PageObjects;

using OpenQA.Selenium.Support.UI;



namespace OnTestAutomation.PageObject

{

    class LoginPage

    {

        private IWebDriver driver;



        [FindsBy(How = How.Id, Using = "loginEmail")]

        private IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = "password")]

        private IWebElement Password { get; set; }

        [FindsBy(How = How.Name, Using = "role")]

        private IWebElement Role { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".login-button")]

        private IWebElement SignInButton { get; set; }



        //To enter user name filed

        public void EnterUsername(string userName)

        {

            UserName.Clear();

            UserName.SendKeys(userName);

        }



        //To enter password field

        public void EnterPassword(string password)

        {

            Password.SendKeys(password);

        }



        //To select role in drop down

        public void SelectRole(string role)

        {

            SelectElement roleSele = new SelectElement(Role);

            roleSele.SelectByText(role);

        }



        //To Click on signin button

        public void ClickSiginIn()

        {

            SignInButton.Click();

        }



    }

}