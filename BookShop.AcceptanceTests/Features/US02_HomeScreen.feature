Feature: US02 - Home Screen
	As a potential customer
	I want to see the books with the best price
	So that I can save money on buying discounted books.

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

Scenario: Cheapest 3 books should be listed on home screen
	When I go to shop
	Then the home screen should show the book 'Specification By Example'
	   * the home screen should show the book 'The Power of Now'
	   * the home screen should show the book 'The Scrum Field Guide'

@alternative_syntax
Scenario: Cheapest 3 books should be listed on the home screen (list syntax)
	When I go to shop
	Then the home screen should show the books 'Specification By Example', 'The Power of Now', 'The Scrum Field Guide'

@alternative_syntax
Scenario: Cheapest 3 books should be listed on the home screen (table syntax)
	When I go to shop
	Then the home screen should show the following books
		| Title                    |
		| Specification By Example |
		| The Power of Now         |
		| The Scrum Field Guide    |
