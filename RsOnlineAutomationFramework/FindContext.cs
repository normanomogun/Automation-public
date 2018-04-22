using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RsOnlineAutomationFramework
{
    public class FindContext
    {
        private Finder _finder;
        private SelectElementHandler _elementHandler;

        public void SetRootFinder(IWebDriver driver)
        {
            _finder = new Finder(driver);
        }

        public Finder Find()
        {
            return _finder;
        }

        public void SetRootSelectElement(IWebDriver driver)
        {
           
        }

        

    }
}
