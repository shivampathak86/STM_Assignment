
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
   public  class AssignmenPhase2Test 
    {

        [TestInitialize]
        public void  Init()
        {
            Browser.WebDriverInstance();
            Browser.GotoWebsite("https://www.ticketnew.com/OnlineTheatre/Theatre/UserRegisteration.aspx/");
        }


        [TestCleanup]

        public void CleanUp()

        {
            Browser.Close();
        }
                        


        [TestMethod]
        [DataSource("System.Data.Odbc", "Dsn=Excel Files;Driver={Microsoft Excel Driver (*.xlsx)};dbq=|DataDirectory|\\TestData.xlsx;defaultdir=.;driverid=790;maxbuffersize=2048;pagetimeout=5;readonly=true", 
            "Email$", DataAccessMethod.Sequential)]
        public void LoginTesT_For_10_DifferentValuesF_for_EmailAddress()


        {
            RegistrationPage registrationPage = new RegistrationPage(Browser.WebDriver);

            registrationPage.EnterEmailId(TestContext.DataRow["Login"].ToString()).EnterPassword("123456789").EnterConfirmPassword("123456789").
                EnterMobile("9036612244").EnterFirstName(TestContext.DataRow["FirstName"].ToString()).EnterLastName(TestContext.DataRow["LastName"].ToString()).Click_On_m_sign();
            if (registrationPage.EmailError)
            {
                Assert.Fail("Please enter valid email");
            }
            
            else
            {
                Assert.IsTrue(true, "Login Success");
            }
           
        }

        [TestMethod]
        [DataSource("System.Data.Odbc", "Dsn=Excel Files;Driver={Microsoft Excel Driver (*.xlsx)};dbq=|DataDirectory|\\TestData.xlsx;defaultdir=.;driverid=790;maxbuffersize=2048;pagetimeout=5;readonly=true", "Pwd$", DataAccessMethod.Sequential)]
        public void LoginTesT_For_10_DifferentValues_for_Password()


        {
            RegistrationPage registrationPage = new RegistrationPage(Browser.WebDriver);
            registrationPage.EnterEmailId("2018HT12044@wilp.bits-pilani.ac.in").EnterPassword(TestContext.DataRow["Pwd"].
                ToString()).EnterConfirmPassword(TestContext.DataRow["ConfirmPwd"].ToString()).EnterMobile("9036612244").EnterFirstName(TestContext.DataRow["FirstName"].
                ToString()).EnterLastName(TestContext.DataRow["LastName"].ToString()).Click_On_m_sign();
            if (registrationPage.EmailError)

                if (registrationPage.PwdError)
            {
                Assert.Fail("Please enter valid Pwd");
            }
            
            else
            {
                Assert.IsTrue(true, "Login Success");
            }



        }


        [TestMethod]
        [DataSource("System.Data.Odbc", "Dsn=Excel Files;Driver={Microsoft Excel Driver (*.xlsx)};dbq=|DataDirectory|\\TestData.xlsx;defaultdir=.;driverid=790;maxbuffersize=2048;pagetimeout=5;readonly=true",
            "ConfirmPwd$", DataAccessMethod.Sequential)]

        public void LoginTesT_For_10_DifferentValuesF_for_ConfirmPassword()
 

        {
            RegistrationPage registrationPage = new RegistrationPage(Browser.WebDriver);
            registrationPage.EnterEmailId("2018HT12044@wilp.bits-pilani.ac.in").EnterPassword(TestContext.DataRow["Pwd"].ToString()).
                EnterConfirmPassword(TestContext.DataRow["ConfirmPwd"].ToString()).EnterMobile("9036612244").EnterFirstName(TestContext.DataRow["FirstName"].ToString()).
                EnterLastName(TestContext.DataRow["LastName"].ToString()).Click_On_m_sign();
            if (registrationPage.EmailError)
                if (registrationPage.ConfirmPwdError)
            {
                Assert.Fail("Please enter valid ConfirmPwd");
            }

            else
            {
                Assert.IsTrue(true, "Login Success");
            }


        }


        [TestMethod]
        [DataSource("System.Data.Odbc", "Dsn=Excel Files;Driver={Microsoft Excel Driver (*.xlsx)};dbq=|DataDirectory|\\TestData.xlsx;defaultdir=.;driverid=790;maxbuffersize=2048;pagetimeout=5;readonly=true", 
            "Mobile$", DataAccessMethod.Sequential)]

        public void LoginTesT_For_10_DifferentValuesF_for_Mobile()


        {
            RegistrationPage registrationPage = new RegistrationPage(Browser.WebDriver);
            registrationPage.EnterEmailId("2018HT12044@wilp.bits-pilani.ac.in").EnterPassword("123456789").EnterConfirmPassword("123456789").
                EnterMobile(TestContext.DataRow["Mobile"].ToString()).EnterFirstName(TestContext.DataRow["FirstName"].ToString()).EnterLastName(TestContext.DataRow["LastName"].ToString()).Click_On_m_sign();
            if (registrationPage.EmailError) ;

            if (registrationPage.MobileError)
            {
                Assert.Fail("Please enter valid Mobile no");
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

