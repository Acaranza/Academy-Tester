using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion3Academy

    //Esto encapsula el webdriver de Chrome , si el driver està Null crea una nueva instancia
{
    public static class WebDriverInstanceManager
    {
        private static IWebDriver activeDriver;

        public static IWebDriver WebDriver
        {
            get
            {
                if (activeDriver == null)
                {
                    activeDriver = new ChromeDriver();
                    activeDriver.Manage().Window.Maximize();


                }
                return activeDriver;
            }
        }


        // CloseDriver es para que una vez que termine de ejecutar las pruebas cierre el Driver.
        public static void CloseDriver()
        {
            if (activeDriver != null)
            {
                activeDriver.Close();
                activeDriver.Quit();
                activeDriver.Dispose();
                activeDriver = null;
            }
        }
    }
}
