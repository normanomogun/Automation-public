using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace RsOnlineAutomationFramework.Elements
{
    public class DropDownBox : Element
    {
        private SelectElementHandler _selectElement;
        public void selectBytext(string text)
        {
            
        }

        public void ClickOnElement()
        {
            WebElement.Click();
        }
        
    }
}
