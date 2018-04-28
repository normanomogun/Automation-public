using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RsOnlineAutomationFramework;
using RsOnlineAutomationFramework.Elements;

namespace RsOnlineAutomationTest.Pages
{
    public class BatteriesPage : BasePage
    {
        

        public bool IsAt(string page)
        {
            var batLink = Find()
                .ByCssSelector<Link>("ul a[href='https://uk.rs-online.com/web/c/" + page + "/']")
                .IsDisplayed();

            return batLink;

        }


        public void SearchBoxText()
        {
            var searchBox = Find().ByCssSelector<Text>(@"#searchForm\3a searchTerm");
            searchBox.SendKeys("test");
        }
    }
}
