using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Ejercitacion3Academy
{
    [TestClass]
    public class UnitTest1
    {

        public IWebDriver driver;


        // métodos Initialize 
        [TestInitialize]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ultimateqa.com/automation/");

        }


        [TestMethod]
        public void TestMethod1()
        {
          
            IWebElement element = driver.FindElement(By.XPath("//a[@href='https://courses.ultimateqa.com/courses/selenium-with-c']"));

            //*[@id="main-content"]/section[2]/div/div/article/ul/li[1]/p
            Console.WriteLine(element);
            element.Click();
            
            IWebElement element2 = driver.FindElement(By.XPath("/html/body/main/section[2]/div/div/article/ul/li[1]/p"));
       
            string nombreElemento = element2.Text;
            
            Console.WriteLine(nombreElemento);

            //3.4 El assert verifica que el texto diga "Master automation testing from A to Z"

            Assert.AreEqual("Master automation testing from A to Z", nombreElemento);
            //Correr el test y lograr que pase  - Aca se va a ejecutar los pasos correspondientes al test
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Clonar el test y cambiar alguna assertion para lograr que falle el segundo test 
            //(SE agrega un 1 al final del link para que no lo encuentre y falle)

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(" https://www.ultimateqa.com/automation/");
            IWebElement element = driver.FindElement(By.XPath("//a[@href='https://courses.ultimateqa.com/courses/selenium-with-c1']"));

            Console.WriteLine(element);
            element.Click();
        }

        // Cleanup
        [TestCleanup]
        public void Cleanup()
        {

            driver.Quit();
        }
    }
}
