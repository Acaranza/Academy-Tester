using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion3Academy.Controls
{
    public class Link : BaseControl
    {
        public Link(By by)
         : base(by)
        {
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

