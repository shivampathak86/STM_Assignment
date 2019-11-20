using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkLibrary.PageObjectModel
{
   public class RegistrationPage
    {

        #region pirvate fields 
        [FindsBy(How = How.Id, Using = "txtemail")]

        private IWebElement m_EmailID;
        private By m_LocatorForEmailID = By.Id("txtemail");

        [FindsBy(How = How.Id, Using = "txtmobile")]
        private IWebElement m_Mobile;
        private By m_LocatorForMobile = By.Id("txtmobile");

        [FindsBy(How = How.Id, Using = "txtpassword")]

        private IWebElement m_Password;
        private By m_LocatorForPassword = By.Id("txtpassword");

        [FindsBy(How = How.Id, Using = "txtconfirmpassword")]

        private IWebElement m_ConfirmPassword;
        private By m_LocatorFormConfirmPassword = By.Id("txtconfirmpassword");

        [FindsBy(How = How.Id, Using = "btnLogin")]

        private IWebElement m_SignupBtn;
        private By m_LocatorForSignupBtn = By.Id("btnLogin");

        [FindsBy(How = How.Id, Using = "txtfirstname")]

        private IWebElement m_firstName;


        [FindsBy(How = How.Id, Using = "txtlastname")]

        private IWebElement m_lastName;
#endregion




        #region Error handling

        [FindsBy(How = How.XPath, Using = "//label[@for='txtemail' and @class ='error']")]
        private IWebElement m_ErrorForEmail;

        [FindsBy(How = How.XPath, Using = "//label[@for='txtmobile' and @class ='error']")]
        private IWebElement m_ErrorForMobile;

        [FindsBy(How = How.XPath, Using = "//label[@for='txtpassword' and @class ='error']")]
        private IWebElement m_ErrorForPwd;

        [FindsBy(How = How.XPath, Using = "//label[@for='txtconfirmpassword' and @class ='error']")]
        private IWebElement m_ErrorForConfirmPwd;
#endregion


        
        #region Public properties
        public bool EmailError
        {

            get
            {
                try
                {
                    return m_ErrorForEmail.Displayed;
                }
                catch (Exception e)
                {
                    return false;
                }

            }
        }

        public bool PwdError
        {
            get
            {
                try
                {

                    return m_ErrorForPwd.Displayed;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public bool ConfirmPwdError
        {
            get
            {
                try
                {

                    return m_ConfirmPassword.Displayed;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public bool MobileError
        {
            get
            {
                try
                {

                    return m_ErrorForMobile.Displayed;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
        #endregion


        #region public methods
        public RegistrationPage(IWebDriver driver) : base()
        {
            PageFactory.InitElements(driver, this);
        }


        public RegistrationPage EnterEmailId(string emailId)
        {
            m_EmailID?.SendKeys(emailId);


            return this;

        }



        public RegistrationPage EnterPassword(string Password)
        {
            m_Password?.SendKeys(Password);


            return this;

        }

        public RegistrationPage EnterConfirmPassword(string ConfirmPassword)
        {
            m_ConfirmPassword?.SendKeys(ConfirmPassword);


            return this;

        }

        public RegistrationPage EnterMobile(string Mobile)
        {
            m_Mobile?.SendKeys(Mobile);


            return this;

        }

        public RegistrationPage EnterFirstName(string FirstName)
        {
            m_firstName?.SendKeys(FirstName);


            return this;

        }
        public RegistrationPage EnterLastName(string LastName)
        {
            m_lastName?.SendKeys(LastName);


            return this;

        }

        public RegistrationPage Click_On_m_sign()
        {
            m_SignupBtn.Click();
            return this;
        }
        #endregion


    }

}
    