using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace RsOnlineAutomationFramework
{
    public class SelectElements : FindContext
    {
        public SelectElement SelectElement { get; private set; }

        public void SetSelectElement(SelectElement selectElement)
        {
            SelectElement = selectElement;
        }
    }

    
}
