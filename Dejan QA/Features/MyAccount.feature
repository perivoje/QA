Feature: MyAccount
	In order to to use all functionalities
	As a user
	I want to be able to manage my account

@MyAccount
Scenario: User can log in
	Given User opens sign in page
	And enters correct credentials
	When user submits the login form
	Then User will be logged in

Scenario: User can open wishlist page
	Given User opens sign in page
	And enters correct credentials
	Given user submits the login form
	When User opens my wishlist
	Then User can add new wishlist
