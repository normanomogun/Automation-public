using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsOnlineAutomationFramework.Elements
{
    public class Text : Element
    {
        public string GetText()
        {
            return WebElement.Text;
        }

        public bool IsDisplayed()
        {
            return WebElement.Displayed;
        }

        public void SendKeys(string text)
        {
            WebElement.SendKeys(text);
        }
    }
}
