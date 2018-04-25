using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public static class WebElementExtensions
    {
        public static void Type(this IWebElement element, String value)
        {
            element.Clear();
            element.SendKeys(value);
        }
    }
}
