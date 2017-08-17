Feature: Put Product
	In order to see product details and stock levels
	As an API consumer
	I want to get a product by its code

@resetDatabase
Scenario: Discontinue Product - green path
	Given a request for the product with code 'fish-heads'
	And the request contains the header values
		| Name         | Value            |
		| Content-Type | application/json |
		| x-api-key    | BBDE1E2C         |
	And the request contains the values
		| Name        | Value | As             |
		| stockCount  | 0     | System.Int32   |
		| isAvailable | false | System.Boolean |
	When the client makes a put request
	Then the product is recorded as not available
	And the stock count for the product is recorded as 0
	And the API returns with response code '200'
	And the response contains the header values
		| Name          | Value      |
		| x-api-version | 1.0        |
	And the response does not contain product details

@resetDatabase
Scenario: Discontinue Product - unauthorized
	Given a request for the product with code 'fish-heads'
	And the request contains the header values
		| Name         | Value            |
		| Content-Type | application/json |
		| x-api-key    | NOTAVALIDKEY     |
	And the request contains the values
		| Name        | Value | As             |
		| stockCount  | 0     | System.Int32   |
		| isAvailable | false | System.Boolean |
	When the client makes a put request
	Then the API returns with response code '401'
	And the response contains the header values
		| Name          | Value      |
		| x-api-version | 1.0        |
	And the stock count for the product is recorded as 3
	And the response does not contain product details

@resetDatabase
@wcfStub
Scenario: Reorder Product - green path
	Given a request for the product with code 'chocolate-sprinkles'
	And the request contains the header values
		| Name         | Value            |
		| Content-Type | application/json |
		| x-api-key    | BBDE1E2C         |
	And the request contains the values
		| Name        | Value | As             |
		| stockCount  | 0     | System.Int32   |
		| isAvailable | true | System.Boolean |
	When the client makes a put request
	Then the supplier is sent an order request by Web service within 600 milliseconds
	And the order request specifies the product to be ordered
	And the product is recorded as available
	And the stock count for the product is recorded as 0
	And the API returns with response code '202'
	And the response contains the header values
		| Name          | Value      |
		| x-api-version | 1.0     |
	And the response does not contain product details

