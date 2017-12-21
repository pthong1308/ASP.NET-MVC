   @automated
Feature: US03 - Shopping cart
	As a potential customer
	I want to collect books in a shopping cart
	So that I can order several books at once.

Background:
	Given the following books
		| Author                         | Title                                                   | Price |
		| Gojko Adzic                    | Specification By Example                                | 12.20 |
		| Eckhart Tolle                  | The Power of Now                                        | 12.58 |
		| Jeff Sutherland                | Scrum: The Art of Doing Twice the Work in Half the Time | 16.73 |
		| Gojko Adzic                    | Bridging the Communication Gap                          | 24.75 |
		| Mitch Lacey                    | The Scrum Field Guide                                   | 15.31 |
		| Martin Fowler                  | Analysis Patterns                                       | 50.20 |
		| Eric Evans                     | Domain Driven Design                                    | 46.34 |
		| Ted Pattison                   | Inside Windows SharePoint Services                      | 31.49 |
		| Lisa Crispin and Janet Gregory | Agile Testing                                           | 20.20 |
		| Esther Derby and Diana Larsen  | Agile Retrospectives                                    | 16.99 |


Scenario: Books can be placed into shopping cart
	Given I have a shopping cart with: 'Analysis Patterns'
	When I place 'Domain Driven Design' into the shopping cart
	Then my shopping cart should contain 2 types of items
	And my shopping cart should contain 1 copy of 'Analysis Patterns'
	And my shopping cart should contain 1 copy of 'Domain Driven Design'


Scenario: Shopping cart should show total number of items and total price
	Given I have a shopping cart with: 'Analysis Patterns', 'Domain Driven Design'
	When I place 'Analysis Patterns' into the shopping cart
	Then my shopping cart should contain 2 types of items
	And my shopping cart should contain 3 items in total
	And my shopping cart should show a total price of 146.74


Scenario: The shopping cart should be initially empty
	When I go to shop
	Then my shopping cart should be empty


Scenario: A type of book can be entirely removed from the shopping cart
	Given I have a shopping cart with: 'Analysis Patterns'
	When I delete 'Analysis Patterns' from the shopping cart
	Then my shopping cart should be empty


Scenario: Adding the same book to shopping cart again should increase quantity
	Given I have a shopping cart with: 'Analysis Patterns'
	When I place 'Analysis Patterns' into the shopping cart
	Then my shopping cart should contain 1 type of item
	And my shopping cart should contain 2 copies of 'Analysis Patterns'


Scenario: Quantity of a book can be changed
	Given I have a shopping cart with: 'Analysis Patterns'
	When I change the quantity of 'Analysis Patterns' to 3
	Then my shopping cart should contain 1 type of item
	And my shopping cart should contain 3 copies of 'Analysis Patterns'


Scenario: Changing quantity of book to 0 should remove book from shopping cart
	Given I have a shopping cart with: 'Analysis Patterns'
	When I change the quantity of 'Analysis Patterns' to 0
	Then my shopping cart should be empty
