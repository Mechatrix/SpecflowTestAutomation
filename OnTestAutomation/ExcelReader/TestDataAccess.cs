using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OnTestAutomation.PageObject;
using System;
using excel = Microsoft.Office.Interop.Excel;

namespace OnTestAutomation.ExcelReader
{
    class TestDataAccess
    {
        [Test]
        public void LoginTest()
        {
            //Creates excel application
            excel.Application x1Appl = new excel.Application();
            //Creates excel workbook object for specified file
            excel.Workbook x1WorkBook = x1Appl.Workbooks.Open(@"C:\Users\vbadugu\source\repos\SpecflowTestAutomation\OnTestAutomation\ExcelReader\TestDataAccess.xlsx");
            //Creates excel work sheet object for sheet 1
            excel._Worksheet x1WorkSheet = x1WorkBook.Sheets[1];
            //Gets used range of excel file(here range is 3)
            excel.Range x1Range = x1WorkSheet.UsedRange;
            int xlRowCnt = 0;
            String Username;
            String Password;
            String URL;
            for (xlRowCnt = 2; xlRowCnt <= x1Range.Rows.Count; xlRowCnt++)
            {
                URL = (string)(x1Range.Cells[xlRowCnt, 1] as excel.Range).Value2;
                Username = (string)(x1Range.Cells[xlRowCnt, 2] as excel.Range).Value2;
                Password = (string)(x1Range.Cells[xlRowCnt, 3] as excel.Range).Value2;
                //Initializes webdriver
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = URL;
                //Creates object for Login page
                var loginPage = new LoginPage();
                //Initializes Login page objects with Page Factory concept
                PageFactory.InitElements(driver, loginPage);
                //Calls Login page methods
                loginPage.EnterUsername(Username);
                loginPage.EnterPassword(Password);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                loginPage.ClickSiginIn();
                driver.Quit();
            }
            x1WorkBook.Close();
            x1Appl.Quit();
        }
    }
}