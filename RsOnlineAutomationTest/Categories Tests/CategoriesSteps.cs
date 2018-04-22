using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RsOnlineAutomationTest.Pages;
using TechTalk.SpecFlow;

namespace RsOnlineAutomationTest.Categories_Tests
{
    [Binding]
    public class CategoriesSteps
    {
        private CategoriesPage _categoriesPage;
        private BatteriesPage _batteriesPage;
        [Given(@"I am on the category page")]
        public void GivenIAmOnTheCategoryPage()
        {
            _categoriesPage = Current.Driver.Create<CategoriesPage>();
            _categoriesPage.IsAt();
        }

        [When(@"I select a (.*) from category panel")]
        public void WhenISelectAFromCategoryPanel(string category)
        {
            _categoriesPage.ClickACategoryFromPanel(category);
        }

        [Then(@"I should be taken to the (.*) screen")]
        public void ThenIShouldBeTakenToTheScreen(string pageLink)
        {
            _batteriesPage = Current.Driver.Create<BatteriesPage>();
            //_batteriesPage.SearchBoxText();
           Assert.IsTrue(_batteriesPage.IsAt(pageLink));
        }

        [When(@"I select a '(.*)' from All products dropdown")]
        public void WhenISelectAFromAllProductsDropdown(string category)
        {
            _categoriesPage.SelectCatFromAllProduts(category);
        }


    }
}
