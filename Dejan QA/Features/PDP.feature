Feature: PDP
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@PDP
Scenario: User can Add product to cart
	Given User opens dresses section
	And opens first product from the list
	And increases quantity to 2
	When User click on add to cart button
	Then product is added to the cart