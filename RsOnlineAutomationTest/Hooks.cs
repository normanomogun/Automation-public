using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace RsOnlineAutomationTest
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            Current.Driver.LaunchBrowser("Chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(2000);
            Current.Driver.BrowserStop();
        }
    }
}
