using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion3Academy.Controls
{
    public class TextBox : BaseControl
        // 4.2  TextBox hereda de BaseControl, representa los input.
    {
        public TextBox(By by)
            : base(by)
        {
        }

        public void write(string texto)
        {

            this.webElement.SendKeys(texto);
        }

        public void Clear()
        {
            this.webElement.Clear();
        }

        public string value
        {
            get
            {
                try
                {
                    return this.webElement.GetAttribute("value");
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }

    }

}

   
