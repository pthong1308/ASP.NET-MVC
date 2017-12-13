Feature: US05 - Create New Book
	As a sale role
	I want to add new book item
	So that the potential customers have more products to choose

Background:
	Given the following books
		| Author                         | Title                                                   | Price |
		| Gojko Adzic                    | Specification By Example                                | 12.20 |
		| Eckhart Tolle                  | The Power of Now                                        | 12.58 |
		| Jeff Sutherland                | Scrum: The Art of Doing Twice the Work in Half the Time | 16.73 |
		| Mitch Lacey                    | The Scrum Field Guide                                   | 15.31 |
		| Martin Fowler                  | Analysis Patterns                                       | 50.20 |
		| Eric Evans                     | Domain Driven Design                                    | 46.34 |
		| Ted Pattison                   | Inside Windows SharePoint Services                      | 31.49 |
		| Lisa Crispin and Janet Gregory | Agile Testing                                           | 20.20 |
		| Esther Derby and Diana Larsen  | Agile Retrospectives                                    | 16.99 |

Scenario: Successfull Creating New Book
	Given I am on Create Book Page
	When I input the following information
	| Author        | Title       | Price |
	| Martin Fowler | Refactoring | 29.55 |
	Then the list of books should update
		| Author                         | Title                                                   | Price |
		| Gojko Adzic                    | Specification By Example                                | 12.20 |
		| Eckhart Tolle                  | The Power of Now                                        | 12.58 |
		| Mitch Lacey                    | The Scrum Field Guide                                   | 15.31 |
		| Jeff Sutherland                | Scrum: The Art of Doing Twice the Work in Half the Time | 16.73 |
		| Esther Derby and Diana Larsen  | Agile Retrospectives                                    | 16.99 |
		| Lisa Crispin and Janet Gregory | Agile Testing                                           | 20.20 |
		| Martin Fowler                  | Refactoring                                             | 29.55 |
		| Ted Pattison                   | Inside Windows SharePoint Services                      | 31.49 |
		| Eric Evans                     | Domain Driven Design                                    | 46.34 |
		| Martin Fowler                  | Analysis Patterns                                       | 50.20 |