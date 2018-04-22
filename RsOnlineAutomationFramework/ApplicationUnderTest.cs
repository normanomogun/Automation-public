using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace RsOnlineAutomationFramework
{
    public class ApplicationUnderTest
    {
        private IWebDriver _driver;

        public void Start(string browserName, string url)
        {
            _driver = GetBrowser(browserName);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(url);
        }

        private IWebDriver GetBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                        return new ChromeDriver();
                    
                case "Edge":
                    return new EdgeDriver();
                    
                default:
                    throw new InvalidOperationException();
                   

                    
                    
            }
        
            //if (browserName == "Chrome")
            //{
            //    return new ChromeDriver();
            //}
            //throw new InvalidOperationException("This is not a valid driver");
        }

        protected void StopDriver()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        public T Create<T>() where T : BasePage, new()
        {
            var page = new T();
            page.SetDriver(_driver);
            return page;
        }

    }
}
