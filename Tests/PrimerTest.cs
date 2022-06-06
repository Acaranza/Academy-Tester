using Ejercitacion3Academy.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion3Academy.Tests
{
    public class PrimerTest : BaseWdTest
    {
        private EjemploPage ejemploPage;

        public PrimerTest()
        {
            ejemploPage = new EjemploPage();
        }


        [TestMethod]
        public void test()
        {
           // var isVisible = ejemploPage.text1.WaitUntilVisible();

            //Assert.IsTrue(isVisible);
            //Assert.IsTrue(ejemploPage.text2.displayed, "El campo text2 no se muestra");

            //ejemploPage.text1.write("testingAcademy");
            //ejemploPage.text2.write("abc123");

            //Assert.IsTrue(ejemploPage.text1.value == "testingAcademy");
            //Assert.IsTrue(ejemploPage.text2.value == "abc123", "text2 no tiene el valor esperado");

        }
    }
}
