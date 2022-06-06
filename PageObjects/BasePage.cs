using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion3Academy.PageObjects
{

    /* Ejercico 4.1 -  Aplicar patrón de diseño Page Object: Modificar los tests
    creados aplicando page-object para separar la localización y el
    manejo de los objetos de la página respecto de los test de cada página. */ 
   
        public class BasePage
        {

            protected By locator;

            public BasePage(By by)

            //BasePage es una abstracciòn del Driver y de los elementos
            {
                this.locator = by;

            }

            protected IWebDriver Driver
            {
                get
                {
                    return WebDriverInstanceManager.WebDriver;
                }
            }
        //Web element es para encontrar un elemento por su locación
            protected IWebElement webElement
            {
                get
                {
                    return this.Driver.FindElement(this.locator);
                }
            }
        // Wait Until Visible es para esperar un elemento hasta que sea visible (10'')
            public void WaitUntilVisible(int secondsTimeout = 10)
            {
                this.Driver.WaitUntilVisible(this.locator, secondsTimeout);
            }

        }

    }




