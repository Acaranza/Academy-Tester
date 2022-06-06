using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion3Academy.Controls
{ /*
   Modelar clases para representar los tipos de elementos web: Crear clases para
    modelar los elementos web usados en los tests (textfield, datepicker, label, combobox, etc) y luego 
    modificar el test para utilizar el objeto modelado en vez de definirlo 
    en cada test donde se use. Recordar que es una buena práctica tener 
    una clase de elemento base que implemente los métodos de findElement 
    y findElements. Ver proyecto ejemplo en el repo git. 
   */

        public class BaseControl
        {
            protected By locator;


            public BaseControl(By by)
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

            protected IWebElement webElement
            {
                get
                {
                    try
                    {
                        return this.Driver.FindElement(this.locator);
                    }
                    catch (NoSuchElementException)
                    {
                        return null;
                    }
                }
            }
            protected IWebElement webElementWaiter
            {
                get
                {
                    try
                    {
                        return new WebDriverWait(this.Driver, System.TimeSpan.FromSeconds(50)).Until<IWebElement>(d => d.FindElement(this.locator));
                    }
                    catch (NoSuchElementException)
                    {
                        return null;
                    }
                }
            }

            public bool displayed
            {
                get
                {
                    try
                    {
                        return this.webElement.Displayed;
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                }
            }

            public bool isSelected
            {
                get
                {
                    try
                    {
                        return this.webElement.Selected;
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                }
            }

            public void click()
            {
                this.webElement.Click();
            }

            public void click_waiter()
            {
                this.webElementWaiter.Click();
            }

            public bool WaitUntilVisible(int secondsTimeout = 80)
            {
                return this.Driver.WaitUntilVisible(this.locator, secondsTimeout);
            }

        }

    }

