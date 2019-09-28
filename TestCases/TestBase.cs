using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FrameworkLibrary
{ 

    [TestClass]
    public class TestBase
    {
        [TestInitialize]

        public virtual void Init()

        {

            Browser.WebDriverInstance();
            Browser.GotoWebsite("https://www.ticketnew.com/OnlineTheatre/Theatre/UserLogin.aspx/");
            
        }

    }
}
