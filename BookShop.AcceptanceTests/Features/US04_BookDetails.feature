﻿#add @web tag to run the search tests with Selenium automation

#@web
@automated
Feature: US04 - Book details
	As a potential customer
	I want to see the details of a book
	So that I can better decide to buy it.

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


Scenario: The author, the title and the price of a book can be seen
	When I open the details of 'Analysis Patterns'
	Then the book details should show
		|Author			|Title				|Price	|
		|Martin Fowler	|Analysis Patterns	|50.20	|
