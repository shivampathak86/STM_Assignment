using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FrameworkLibrary.PageObjectModel
{
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "txtEmail")]

        private IWebElement m_EmailID;
        private By m_LocatorForEmailID = By.Id("txtEmail");


        [FindsBy(How = How.Id, Using = "txtpwd")]

        private IWebElement m_Password;
        private By m_LocatorForPassword = By.Id("txtpwd");

        [FindsBy(How = How.Id, Using = "btnLogin")]

        private IWebElement m_Loginbtn;
        private By m_LocatorForLoginbtn = By.Id("btnLogin");


        public LoginPage(IWebDriver driver) : base()
        {
            PageFactory.InitElements(driver, this);
        }

      
        public LoginPage EnterEmailId(string emailId)
        {
            m_EmailID?.SendKeys(emailId);


            return this;

        }



        public LoginPage EnterPassword(string Password)
        {
            m_Password?.SendKeys(Password);


            return this;

        }

        public LoginPage ClickOnLoginBtn()
        {
            m_Loginbtn.Click();
            return this;
        }
    }

}
