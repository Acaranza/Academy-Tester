using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Ejercitacion3Academy
{
    [TestClass]
    public class BaseTest
    {

        public IWebDriver driver; //nos va permitir abrir el chrome y controlarlo desde el codigo
        //5 - Implementar métodos Initialize y Cleanup
        //6 - Implementar clase base test:
        

        // métodos Initialize 
        [TestInitialize]
        public void Initialize() {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ultimateqa.com/automation/");
        
        }
     

        // Cleanup
        [TestCleanup]
        public void Cleanup() {

            driver.Quit();
        }
    }
}
