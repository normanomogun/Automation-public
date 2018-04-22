using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace RsOnlineAutomationFramework.Elements
{
    public class ContextMenu : Element
    {
        private SelectElementHandler _selectElement;
        public void selectBytext(string text)
        {
           // _selectElement.SetSelectElement().DeselectByText(text);
        }

        public void ClickOnElement()
        {
            WebElement.Click();
        }

        //public SelectElement SetSelectElement(IWebElement element)
        //{
        //    if (element == null)
        //    {
        //        return new SelectElement(element);
        //    }
        //    return new SelectElement(element);
        //}

    }
}
