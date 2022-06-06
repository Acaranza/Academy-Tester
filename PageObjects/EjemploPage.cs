using Ejercitacion3Academy.Controls;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion3Academy.PageObjects
{
    public class EjemploPage : BasePage
    {
        public EjemploPage()
            : base(By.ClassName("form-group"))
        {
        }

        public Link link
        {
            get
            {
                try
                {
                    return new Link(By.XPath("//a[@href='https://courses.ultimateqa.com/courses/selenium-with-c']"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }

        public TextBox text2
        {
            get
            {
                try
                {
                    return new TextBox(By.Id("last-name"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }

    }
}
