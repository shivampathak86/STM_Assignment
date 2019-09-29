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
        #region pirvate fields 
        [FindsBy(How = How.Id, Using = "txtEmail")]

        private IWebElement m_EmailID;
        private By m_LocatorForEmailID = By.Id("txtEmail");


        [FindsBy(How = How.Id, Using = "txtpwd")]

        private IWebElement m_Password;
        private By m_LocatorForPassword = By.Id("txtpwd");

        [FindsBy(How = How.Id, Using = "btnLogin")]

        private IWebElement m_Loginbtn;
        private By m_LocatorForLoginbtn = By.Id("btnLogin");

        [FindsBy(How = How.XPath, Using = "//label[@for='txtEmail' and @class ='error']")]
        private IWebElement m_ErrorForEmail;

        [FindsBy(How = How.XPath, Using = "//label[@for='txtpwd' and @class ='error']")]
        private IWebElement m_ErrorForPwd;
        #endregion

        #region Public properties
        public bool EmailError => m_ErrorForEmail.Displayed ? true : false;

        public bool PwdError => m_ErrorForPwd.Displayed ? true : false;
        #endregion


#region public methods
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
#endregion


    }

}
