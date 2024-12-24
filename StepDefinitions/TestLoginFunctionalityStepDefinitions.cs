using System;
using TechTalk.SpecFlow;

namespace EGIndiaSpecFlowProject.StepDefinitions
{
    [Binding]
    public class TestLoginFunctionalityStepDefinitions
    {
        [Given(@"User is on login page")]
        public void GivenUserIsOnLoginPage()
        {

            Console.WriteLine("Test user is on the login page");
            
        }

        [When(@"User enters the username and password")]
        public void WhenUserEntersTheUsernameAndPassword()
        {

            Console.WriteLine("Test user enters the username and password");

        }

        [When(@"User clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {

            Console.WriteLine("Test user clicks on the login button");

        }

        [Then(@"User is naviagted to home page")]
        public void ThenUserIsNaviagtedToHomePage()
        {
            Console.WriteLine("Test user is navigated to home page");

        }
    }
}
