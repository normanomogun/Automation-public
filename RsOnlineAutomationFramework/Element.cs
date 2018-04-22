using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RsOnlineAutomationFramework
{
    public class Element : FindContext
    {
        public IWebElement WebElement { get; private set; }
        public void SetElement(IWebElement element)
        {
            WebElement = element;
        }

    }
}
