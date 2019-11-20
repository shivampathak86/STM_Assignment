
using FrameworkLibrary.PageObjectModel;
using FrameworkLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases
{
    [TestClass]
   public class AssignmenPhase1Test : TestBase
    {
        

        [TestMethod]
     
      [DataSource("System.Data.Odbc", "Dsn=Excel Files;Driver={Microsoft Excel Driver (*.xlsx)};dbq=|DataDirectory|\\STM_Assignment_TestData.xls;defaultdir=.;driverid=790;maxbuffersize=2048;pagetimeout=5;readonly=true", "Sheet1$", DataAccessMethod.Sequential)]
        public void LoginTesT_For_Assignment_Phase1()


        {
            LoginPage loginPage = new LoginPage(Browser.WebDriver);


            loginPage.EnterEmailId(TestContext.DataRow["Login"].ToString()).EnterPassword(TestContext.DataRow["Pwd"].ToString()).ClickOnLoginBtn();
            if (loginPage.EmailError)
            {
                Assert.Fail("Please enter valid email");
            }
            else if(loginPage.PwdError)
            {
                Assert.Fail("Please Enter Atleast 6 characters");
            }

            else
            {
                Assert.IsTrue(true, "Login Success");
            }
           
        }

      



        public Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContextInstance;
    }
}

