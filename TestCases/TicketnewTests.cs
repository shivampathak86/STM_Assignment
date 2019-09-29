using FrameworkLibrary;
using FrameworkLibrary.PageObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases
{
    [TestClass]
   public class TicketnewTests : TestBase
    {

        

        [TestMethod]
        //[DataSource("System)]
        public void LoginTest()


        {
            LoginPage loginPage = new LoginPage(Browser.WebDriver);


            loginPage.EnterEmailId("").EnterPassword("").ClickOnLoginBtn();//TestContext.DataRow["Input1"].ToString()).EnterPassword(TestContext.DataRow["Input2"].ToString()).ClickOnLoginBtn();
            
            if(loginPage.EmailError)
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

