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

        public void Login()


        {
            LoginPage loginPage = new LoginPage(Browser.WebDriver);
            loginPage.EnterEmailId("stmphase1group33@gmail.com").EnterPassword("12345678").ClickOnLoginBtn();
        }

        [TestMethod]

        public void TC001_ValidDomainTestforEmail()
        {

            HomePage homePage = new HomePage(Browser.WebDriver);
            homePage.GotoFeeBackPage(Browser.WebDriver).EnterEmail(TestContext.DataRow["ValidFeedBackEmailInput"].ToString()).
                EnterPhoneNumber(TestContext.DataRow["ValidDomainforMObile"].ToString()).SelectFeedBackAsBug().EnterFeedbackComment("test").
                SubmitFeeback();
            FeedBackPage feedbackPage = new FeedBackPage(Browser.WebDriver);
            Assert.IsFalse(feedbackPage.GetEmailErrorText());


        }

        [TestMethod, DataSource("\\Datafile.Xls")]

        public void TC002_InValidDomainTestforEmail()
        {

            HomePage homePage = new HomePage(Browser.WebDriver);
            homePage.GotoFeeBackPage(Browser.WebDriver).EnterEmail(TestContext.DataRow["InValidFeedBackEmailInput"].ToString()).
                EnterPhoneNumber(TestContext.DataRow["ValidDomainforMObile"].ToString()).SelectFeedBackAsBug().EnterFeedbackComment("test").
                SubmitFeeback();
            FeedBackPage feedbackPage = new FeedBackPage(Browser.WebDriver);
            Assert.IsTrue(feedbackPage.GetEmailErrorText());


        }


        [TestMethod]

        public void TC003_ValidDomainTestforMobile()
        {

            HomePage homePage = new HomePage(Browser.WebDriver);
            homePage.GotoFeeBackPage(Browser.WebDriver).EnterEmail(TestContext.DataRow["ValidFeedBackEmailInput"].ToString()).
                EnterPhoneNumber(TestContext.DataRow["ValidDomainforMObile"].ToString()).SelectFeedBackAsBug().EnterFeedbackComment("test").
                SubmitFeeback();
            FeedBackPage feedbackPage = new FeedBackPage(Browser.WebDriver);
            Assert.IsFalse(feedbackPage.GetMobileErrorText());


        }

        public void TC004_InValidDomainTestforMobile()
        {

            HomePage homePage = new HomePage(Browser.WebDriver);
            homePage.GotoFeeBackPage(Browser.WebDriver).EnterEmail(TestContext.DataRow["ValidFeedBackEmailInput"].ToString()).
                EnterPhoneNumber(TestContext.DataRow["InValidDomainforMObile"].ToString()).SelectFeedBackAsBug().EnterFeedbackComment("test").
                SubmitFeeback();
            FeedBackPage feedbackPage = new FeedBackPage(Browser.WebDriver);
            Assert.IsTrue(feedbackPage.GetMobileErrorText());


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

