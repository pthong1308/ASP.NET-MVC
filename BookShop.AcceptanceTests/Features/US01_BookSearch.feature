#add @web tag to run the search tests with Selenium automation

#@automated
@web
Feature: US01 - Book Search
	As a potential customer
	I want to search for books by a simple phrase
	So that I can easily allocate books by something I remember from them.

Background:
	Given the following books
	| Author          | Title                                                   |
	| Gojko Adzic     | Specification By Example                                |
	| Eckhart Tolle   | The Power of Now                                        |
	| Jeff Sutherland | Scrum: The Art of Doing Twice the Work in Half the Time |
	| Gojko Adzic     | Bridging the Communication Gap                          |
	| Mitch Lacey     | The Scrum Field Guide                                   |
	| Ted Pattison    | Inside Windows SharePoint Services                      |


Scenario: Title should be matched
	When I search for books by the phrase 'Power'
	Then the list of found books should contain only: 'The Power of Now'
	
Scenario: Author should be matched
	When I search for books by the phrase 'Gojko'
	Then the list of found books should contain only: 'Specification By Example', 'Bridging the Communication Gap'

Scenario: Space should be treated as multiple OR search
	When I search for books by the phrase 'Windows Communication'
	Then the list of found books should contain only: 'Bridging the Communication Gap', 'Inside Windows SharePoint Services'

Scenario: Search result should be ordered by book title
	When I search for books by the phrase 'id'
	Then the list of found books should be:
		| Title                              |
		| Bridging the Communication Gap     |
		| Inside Windows SharePoint Services |
		| The Scrum Field Guide              |

@alternative_syntax
Scenario Outline: Simple search (scenario outline syntax)
	When I search for books by the phrase '<search phrase>'
	Then the list of found books should contain only: <books>

	Examples:
		|search phrase			|books																	|
		|Power					|'The Power of Now'													|
		|Windows Communication	|'Bridging the Communication Gap', 'Inside Windows SharePoint Services'	|

