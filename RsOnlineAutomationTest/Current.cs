using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RsOnlineAutomationFramework;

namespace RsOnlineAutomationTest
{
    public class Current : ApplicationUnderTest
    {
        private static Current _current;

        public static Current Driver
        {
            get
            {
                if (_current == null)
                {
                    return _current = new Current();
                }
                return _current;
            }
        }

        public void LaunchBrowser(string browserName)
        {
            //var siteUrl = ApplicationResource.BaseUrl;
            Driver.Start(browserName, "http://www.uk.rs-online.com/web/generalDisplay.html?id=new");
        }

        public void BrowserStop()
        {
            Driver.StopDriver();
        }


    }
}
