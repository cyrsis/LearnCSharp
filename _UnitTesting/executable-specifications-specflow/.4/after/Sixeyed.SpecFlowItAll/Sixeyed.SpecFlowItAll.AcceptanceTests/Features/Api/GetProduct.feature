Feature: Get Product
	In order to see product details and stock levels
	As an API consumer
	I want to get a product by its code

@resetDatabase
Scenario: Get Product - green path
	Given a request for the product with code 'fish-heads'
	And the request contains the header values
		| Name      | Value            |
		| Accept    | application/json |
		| x-api-key | 4B24419C989F     |
	When the client makes a get request
	Then the API returns with response code '200'
	And the response contains the header values
		| Name          | Value      |
		| x-api-version | 1.0        |
		| Cache-Control | max-age=60 |
	And the response contains product details
	And the product has the values
		| Name        | Value      |
		| code        | fish-heads |
		| stockCount  | 3          |
		| isAvailable | True       |

@resetDatabase
Scenario: Get Product - not found
	Given a request for the product with code 'horse-biscuits'
	And the request contains the header values
		| Name      | Value            |
		| Accept    | application/json |
		| x-api-key | 4B24419C989F     |
	When the client makes a get request
	Then the API returns with response code '404'
	And the response does not contain product details

@performance
Scenario: Get Product SLA
	Given a request for the product with code 'fish-heads'
	And the request contains the header values
		| Name      | Value            |
		| Accept    | application/json |
		| x-api-key | 4B24419C989F     |
	And the API is under heavy load at 500 requests per second
	When the client makes repeated get requests for 30 seconds
	Then the API returns a positive response within 2000 milliseconds for each request