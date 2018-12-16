using Dejan_QA.Helpers;
using Dejan_QA.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;


namespace Dejan_QA.Steps
{
    [Binding]
    public class MyAccountSteps: Base
    {
        [Given(@"User opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.ClickOnElement(hp.signIn);
            
        }
        
        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            Utilities ut = new Utilities(Driver);
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.username, TestConstants.Username);
            ut.EnterTextInElement(ap.password, TestConstants.Password);
        }
        
        [StepDefinition(@"user submits the login form")]
        public void WhenUserSubmitsTheLoginForm()
        {
            Utilities ut = new Utilities(Driver);
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.signInbtn);
        }

        [When(@"User opens my wishlist")]
        public void WhenUserOpensMyWishlist()
        {
            Utilities ut = new Utilities(Driver);
            MyAccountPage ma = new MyAccountPage(Driver);
            ut.ClickOnElement(ma.wishlist);
        }

        [Then(@"User can add new wishlist")]
        public void ThenUserCanAddNewWishlist()
        {
            Utilities ut = new Utilities(Driver);
            MyWishlistPage mv = new MyWishlistPage(Driver);
            Assert.True(ut.ElementDisplayed(mv.newWish), "User is not on wishlist");
        }


        [Then(@"User will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            Utilities ut = new Utilities(Driver);
            MyAccountPage ma = new MyAccountPage(Driver);
            Assert.False(ut.ElementDisplayed(ma.logOut), "User is not logged in");
        }
    }


}
