@Sanity
Feature: TestLoginWithParams

Test login with test data parameters

Background: 
	Given User is on login page

@Sanity
Scenario: Verify login functionality
	When User enters the username and password
	And User clicks on login button
	Then User is naviagted to home page 

@Regression
Scenario Outline: Verify login with test parameters
	When User enters the "<username>" and "<password>"
	And User clicks on login button
	Then User is naviagted to home page 
	Then User selected city and country information
	| city   | country |
	| Delhi  | India   |
	| Boston | USA     |

Examples: 

| username | password |
| tom      | Harry    |
| jerry    | Mathew   |
