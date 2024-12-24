Feature: Test Login functionality

Feature to test the login functionality


@Regression,@Sanity
Scenario: Verify login functionality
	Given User is on login page
	When User enters the username and password
	And User clicks on login button
	Then User is naviagted to home page 
	