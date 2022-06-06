using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion3Academy
{
    public static class WebDriverExtension

    /*Ejercico 7 Extender Webdriver: Extender Webdriver 
      para que se haga un explicit wait del elemento cada vez que se lo busca. 
     Ver ejemplo de cómo se hace en el proyecto ejemplo de git. */
    {
        // Esperar el elemento hasta que se cargue la pagina ---- > 'Wait until'
        public static bool WaitUntil(this IWebDriver driver, Func<bool> func, int secondsTimeout = 80)
        {
            try
            {
                return new WebDriverWait(driver, TimeSpan.FromSeconds(secondsTimeout)).Until(x => func());
            }
            catch (WebDriverException)
            {
                return false;
            }
        }

        //'Wait until Visible'  --- > Esperar hasta que el elemento se haga visible en la pàgina
        public static bool WaitUntilVisible(this IWebDriver driver, By by, int secondsTimeout = 80)
        {
            return driver.WaitUntil
                (
                    () => driver.FindElement(by).Displayed, secondsTimeout
                );
        }


        // Espera el elemento hasta que este visible --->Find Element Wait (No le coloca restriccion de tiempo)
        public static IWebElement FindElementWait(this IWebDriver driver, By by)
        {
            try
            {
                driver.WaitUntil(() => driver.FindElement(by).Displayed);
                return driver.FindElement(by);
            }
            catch
            {
                return null;
            }
        }

        // Espera hasta que todos los elementos sean visibles ---->'Find elements Wait'  (Tampoco cuentan con restriccion de tiempo)
        public static IEnumerable<IWebElement> FindElementsWait(this IWebDriver driver, By by)
        {
            try
            {
                driver.WaitUntil(() => driver.FindElements(by).Count > 0);
                return driver.FindElements(by);
            }
            catch
            {
                return null;
            }
        }
    }
}

