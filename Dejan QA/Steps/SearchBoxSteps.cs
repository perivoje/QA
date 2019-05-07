using Dejan_QA.Helpers;
using Dejan_QA.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Dejan_QA.Steps
{
    [Binding]
    public class SearchBoxSteps : Base
    {

        [Given(@"user enters a '(.*)' search term")]
        public void GivenUserEntersASearchTerm(string dress)
        {
            Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.EnterTextInElement(hp.searchFld, dress);
        }

        [When(@"user submits the search")]
        public void WhenUserSubmitsTheSearch()
        {
            Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.ClickOnElement(hp.searchBtn);
        }

        [Then(@"results for a '(.*)' search term are displayed")]
        public void ThenResultsForASearchTermAreDisplayed(string term)
        {
            Utilities ut = new Utilities(Driver);
            SearchBoxPage srp = new SearchBoxPage(Driver);
            Assert.That(ut.ReturnTextFromElement(srp.search), Does.Contain(term), "Nesto nije kako treba");
        }

    }
}
