Feature: Search
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Search
Scenario: User can search for a term
	Given user enters a 'dress' search term
	When user submits the search
	Then results for a 'dress' search term are displayed
