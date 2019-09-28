using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkLibrary.PageObjectModel
{
      public   class FeedBackPage
    {

        public FeedBackPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

        }



        [FindsBy(How = How.Id, Using = "txtemail")]
        private IWebElement m_FeedbackPageEmail;


        [FindsBy(How = How.Id, Using = "txtmobile")]

        private IWebElement m_FeedbackPageMobile;

        [FindsBy(How = How.XPath, Using = "//label[@for='txtemail' and @class='error']")]

        private IWebElement m_ErrorForEmail;


        [FindsBy(How = How.XPath, Using = "//label[@for='txtmobile' and @class='error']")]

        private IWebElement m_ErrorForMobile;

        [FindsBy(How = How.XPath, Using = "//input[@type='radio' and @value='bug']/../span[@class='tn-radio-button']")]

        private IWebElement m_FeedbackTypeRadioButton;

        [FindsBy(How = How.Name, Using = "ctl07")]

        private IWebElement m_FeedbackSubmitBtn;

        [FindsBy(How = How.Name, Using = "feedbck_textarea")]

        private IWebElement m_FeedbackComment;





        public FeedBackPage EnterEmail(string email)
        {
            m_FeedbackPageEmail.SendKeys(email);

            return this;
        }

        public FeedBackPage EnterPhoneNumber(string email)
        {
            m_FeedbackPageEmail.SendKeys(email);

            return this;
        }

        public FeedBackPage SelectFeedBackAsBug()
        {

            m_FeedbackTypeRadioButton.Click();
            return this;
        }

        public FeedBackPage EnterFeedbackComment(string comment)
        {
            m_FeedbackComment.SendKeys(comment);
            return this;
        }

        public void SubmitFeeback()
        {
            m_FeedbackSubmitBtn.Click();
        }




        public bool GetEmailErrorText()
        {

           return m_ErrorForEmail.Displayed;
        }

        public bool GetMobileErrorText()
        {

            return m_ErrorForMobile.Displayed;
        }


    }
}
