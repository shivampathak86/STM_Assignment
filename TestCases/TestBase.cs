using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using FrameworkLibrary;
using FrameworkLibrary.Utility;

namespace TestCases
{ 

    [TestClass]
    public class TestBase
    {
        internal ExcelReader excelReader;
        [TestInitialize]

        public virtual void Init()

        {

            Browser.WebDriverInstance();
            Browser.GotoWebsite("https://www.ticketnew.com/OnlineTheatre/Theatre/UserLogin.aspx/");
             excelReader = new ExcelReader();


        }

        [TestCleanup]
        public void Cleanup()
        {
            Browser.Close();
        }

    }
}
