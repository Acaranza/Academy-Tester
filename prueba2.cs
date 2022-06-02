using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace Ejercitacion3Academy
{


    /* Ejercicio 4 - Agregar otra clase test: Agregar otra clase de test para otra sección diferente de la utilizada 
    en el ejercicio anterior e implementar 2 tests en esa clase: 
   1 - Uno que verifique el contenido propio. 
   2- Otro que haga alguna acción permitida en la página y se verifiquen los resultados de esa acción.
     */

    [TestClass]
    public class prueba2 : BaseTest
    {
        [TestMethod]
        public void TestMethod1()
        { 
            IWebElement element = driver.FindElement(By.XPath("//a[@href='https://ultimateqa.com/best-selenium-webdriver-resources/']"));



            //*[@id="main-content"]/section[2]/div/div/article/ul/li[1]/p
            Console.WriteLine(element);
            element.Click();

            IWebElement element2 = driver.FindElement(By.ClassName("entry-title"));

            string nombreElemento = element2.Text;

            Console.WriteLine(nombreElemento);

            //3.4 El assert verifica que el texto diga "Top 57 Resources to Learn Selenium Webdriver [2020]"

            Assert.AreEqual("Top 57 Resources to Learn Selenium Webdriver [2020]", nombreElemento);
        }
    }
}
