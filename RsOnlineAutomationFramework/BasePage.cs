using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RsOnlineAutomationFramework
{
    public class BasePage : FindContext
    {
        private IWebDriver _driver;

        public void SetDriver(IWebDriver driver)
        {
            _driver = driver;
            SetRootFinder(driver);
            SetRootSelectElement(_driver);
        }

    }
}
