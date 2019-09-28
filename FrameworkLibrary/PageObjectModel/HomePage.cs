using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkLibrary.PageObjectModel
{
   public class HomePage
    {

        [FindsBy(How = How.XPath, Using = "//p[text()='Popular City']/..//a[text()='Bangalore']")]

        private IWebElement m_SearchCityContainer;

        private By m_LocatorForSearchCityContainer = By.XPath("//p[text()='Popular City']/..//a[text()='Bangalore']");

      

        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }





        public HomePage SelectBangaloreCity()
        {
            m_SearchCityContainer.Click();
            return this;
        }

        public FeedBackPage  GotoFeeBackPage(IWebDriver driver)
        {

            Browser.WebDriver.Url = "https://www.ticketnew.com/onlinetheatre/theatre/feedback.aspx";
            return new FeedBackPage(driver);
        }

    }
}
