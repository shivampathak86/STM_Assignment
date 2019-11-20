using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using FrameworkLibrary;
using FrameworkLibrary.Utility;
using FrameworkLibrary.PageObjectModel;

namespace TestCases
{ 

   [TestClass]
    public class TestBase
    {
        
       
        
        public  TestBase()

            {
                
              Browser.WebDriverInstance();
              Browser.GotoWebsite("https://www.ticketnew.com/OnlineTheatre/Theatre/UserRegisteration.aspx/");

             }

           
         
      

        [TestCleanup]
        public void Cleanup()
        {
            Browser.Close();
        }

    }
}
