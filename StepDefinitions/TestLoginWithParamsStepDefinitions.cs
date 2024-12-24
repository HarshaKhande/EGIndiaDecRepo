using NUnit.Framework;
using System;
using TechTalk.SpecFlow;


namespace EGIndiaSpecFlowProject.StepDefinitions
{
    [Binding]
    public class TestLoginWithParamsStepDefinitions
    {
        [When(@"User enters the ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersTheAnd(string username, string password)
        {
            Console.WriteLine("The username is" + username + ".............." + "The password is " + password);
        }

        [Then(@"User selected city and country information")]
        public void ThenUserSelectedCityAndCountryInformation(Table table)
        {
            foreach (var row in table.Rows)
            {

                string city = row["city"];
                string country = row["country"];
                Console.WriteLine(city + ", " + country);


            }

        }

    }
}
