using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace FrameworkLibrary
{
    public class Browser

    {

        #region Private fields /Methods
        private static IWebDriver m_webdriver;
        

        private static void Start(BrowserType Type, out IWebDriver Webdriver)

        {
            switch (Type)

            {
                case BrowserType.Chrome:
                    Webdriver = ChromeDriver();

                    break;
                default:
                    Webdriver = ErroGuardBrowser.NoImplementation();
                    break;



            }
        }

        private static IWebDriver ChromeDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AcceptInsecureCertificates = true;
            chromeOptions.UnhandledPromptBehavior = UnhandledPromptBehavior.Accept;
            chromeOptions.AddArgument("start-maximized");

            IWebDriver chromeDriver = new ChromeDriver(Constant.ChromeDriverPath,chromeOptions);
             


            return chromeDriver;
        }
        #endregion


        #region Public Methods/Properties

        public static  IWebDriver WebDriver
        {
            set
            {
                value = m_webdriver;
            }

            get
            {
                return m_webdriver;
            }
        }
        public static void WebDriverInstance()
        {
            Start(BrowserType.Chrome, out m_webdriver);
            
        }

        public static void GotoWebsite(string url)

        {
          m_webdriver?.Navigate().GoToUrl(url);
        }

        public static void Close()
        {

            m_webdriver?.Quit();
            
        }


        #endregion

        #region Nested Class

        internal static class ErroGuardBrowser

        {
            public static IWebDriver NoImplementation()
            {

                return new ChromeDriver();
            }
        }
        #endregion

        #region Enums

        public enum BrowserType
        {
            Chrome = 001,


            #endregion
        }

    }

}

