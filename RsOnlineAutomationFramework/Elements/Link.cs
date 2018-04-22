using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RsOnlineAutomationFramework.Elements
{
    public class Link : Element
    {
        public void ClickOnLink()
        {
            WebElement.Click();
        }

        public string Gettext()
        {
            var text = WebElement.Text;
            return text;
        }

        public bool IsDisplayed()
        {
            return WebElement.Displayed;
        }
    }
}
