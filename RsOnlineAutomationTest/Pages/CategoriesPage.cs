using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;
using RsOnlineAutomationFramework;
using RsOnlineAutomationFramework.Elements;

namespace RsOnlineAutomationTest.Pages
{
    public class CategoriesPage : BasePage
    {
        public List<Link> AlLinks
        {
            get
            {
                var batteries = Find().AllByCssSelector<Link>("a.list-group-item");
                return batteries;
            }
        }


        public Link BatteriesLink(string cat)
        {

            var batteriesLink = Find()
                .ByCssSelector<Link>("a[href='https://uk.rs-online.com/web/c/"+cat+"/?searchTerm=new_uk&searchType=Offers&n=y#products']");
            return batteriesLink;
        }

        public bool IsAt()
        {
           var textOnPage = Find().ByXpath<Text>(".//*[contains(text(),'Applications & Solutions')]");
            if (!textOnPage.IsDisplayed()) { }
            return true;
        }

        public BatteriesPage ClickACategoryFromPanel(string categoryName)
        {
            foreach (var item in AlLinks)
            {
                if (item.Gettext() == categoryName)
                {
                    item.ClickOnLink();
                    break;
                }
            }
            return new BatteriesPage();
        }

        public void SelectCatFromAllProduts(string category)
        {
             var allProductsDropdown = Find().ByCssSelector<DropDownBox>("a.menu.product-menu");
            allProductsDropdown.ClickOnElement();
            var contextMenu = Find()
                .ByCssSelector<ContextMenu>("ul.verticalMenu.showVerticalMenu");
            
        }
    }
}
