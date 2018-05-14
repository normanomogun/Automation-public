using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RsOnlineAutomationFramework
{
    public class Finder
    {
        private IWebDriver _driver;

        public Finder(IWebDriver driver)
        {
            _driver = driver;
        }

        private T Find<T>(By locator) where T : Element, new()
        {
            var element = new T();
            element.SetElement(_driver.FindElement(locator));
            return element;
        }

        

        public T ById<T>(string selector) where T : Element, new()
        {
            return Find<T>(By.Id(selector));
        }

        public T ByName<T>(string selector) where T : Element, new()
        {
            return Find<T>(By.Name(selector));

        }

        public T ByLinkText<T>(string selector) where T : Element, new()    
        {
            return Find<T>(By.LinkText(selector));
            
        }

        public T ByXpath<T>(string selector) where T : Element, new()
        {
            return Find<T>(By.XPath(selector));
        }

        public T ByCssSelector<T>(string selector) where T : Element, new()
        {
            return Find<T>(By.CssSelector(selector));
        }

        private List<T> FindAll<T>(By locator) where T : Element, new()
        {
            var elements = _driver.FindElements(locator);
            List<T> list = new List<T>();

            foreach (var element in elements)   
            {
                var elem = new T();
                elem.SetElement(element);
                list.Add(elem);
            }
            return list;
        }

        public List<T> AllByCssSelector<T>(string selector) where T : Element, new()
        {
            return FindAll<T>(By.CssSelector(selector));
        }
    }
}
