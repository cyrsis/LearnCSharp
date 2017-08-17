Feature: Discontinue Product
	In order to stop selling a product
	As a warehouse manager
	I want to record that the product is discontinued

@resetDatabase
Scenario: Discontinue Product - Green Path
	Given that we have no more stock of the product 'fish-heads'
	And the item is not to be re-ordered 
	When I discontinue the item in the management portal 
	Then the product is recorded as not available
	And the stock count for the product is recorded as 0
	And the product shows as not available on the website product list
	And the product shows as discontinued on the website product page
