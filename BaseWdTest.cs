using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion3Academy
{
    public class BaseWdTest
    {
        public BaseWdTest()
        {
            WebDriverInstanceManager
                .WebDriver
                .Navigate()
                .GoToUrl("https://formy-project.herokuapp.com/form");
        }

        [TestInitialize]
        public void initialize()
        {

        }

        [TestCleanup]
        public void clenaup()
        {
            WebDriverInstanceManager.CloseDriver();
        }
    }
}
