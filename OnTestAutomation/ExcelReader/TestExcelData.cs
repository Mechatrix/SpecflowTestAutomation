using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OnTestAutomation.ExcelReader
{
    [TestClass]
    public class TestExcelData
    {
        [TestMethod]
        public void TestReadExcel()
        {

            string xlPath = @"C:\Users\My\Downloads\SeleniumWebDriverWithCSharp-master\SeleniumWebDriverWithCSharp-master\SeleniumWebdriver\Resources\ExcelData.xlsx";
            Console.WriteLine(ExcelReaderHelper.GetCellData(xlPath, "Bugzilla", 0, 0));
            Console.WriteLine(ExcelReaderHelper.GetCellData(xlPath, "Bugzilla", 0, 1));
            Console.WriteLine(ExcelReaderHelper.GetCellData(xlPath, "Bugzilla", 0, 2));


        }
    }
}
