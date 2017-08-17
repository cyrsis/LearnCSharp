Feature: Reorder Product
	In order to continue selling a product
	As a warehouse manager
	I want to reorder a product from the supplier

@resetDatabase
@smtpStub
Scenario: Reorder Product - by email
	Given that we have no more stock of the product 'fish-heads'
	And the item is going to be reordered 
	And the supplier receives reorder requests by email
	When I discontinue the item in the management portal 
	Then the product is recorded as available
	And the stock count for the product is recorded as 0
	And the product shows as available on the website product list
	And the availability for the product on the website product page shows the message
		| message                                                         |
		| Out of stock! Sorry, this product will be available again soon. |
	And the supplier is sent an order request by email
	And the order request specifies the product to be ordered

@resetDatabase
@wcfStub
Scenario: Reorder Product - by Web service
	Given that we have no more stock of the product 'chocolate-sprinkles'
	And the item is going to be reordered 
	And the supplier receives reorder requests by Web service
	When I discontinue the item in the management portal 
	Then the product is recorded as available
	And the stock count for the product is recorded as 0
	And the product shows as available on the website product list
	And the availability for the product on the website product page shows the message
		| message                                                         |
		| Out of stock! Sorry, this product will be available again soon. |
	And the supplier is sent an order request by Web service
	And the order request specifies the product to be ordered

@resetDatabase
@msmqStub
Scenario: Reorder Product - by message queue
	Given that we have no more stock of the product 'brooks-b17'
	And the item is going to be reordered 
	And the supplier receives reorder requests by message queue
	When I discontinue the item in the management portal 
	Then the product is recorded as available
	And the stock count for the product is recorded as 0
	And the product shows as available on the website product list
	And the availability for the product on the website product page shows the message
		| message                                                         |
		| Out of stock! Sorry, this product will be available again soon. |
	And the supplier is sent an order request by message queue
	And the order request specifies the product to be ordered