@Calculator
Feature: Calculator
#![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
#Simple calculator for adding **two** numbers

#Link to a feature: [Calculator](CalculatorSelenium.Specs/Features/Calculator.feature)
#***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

#Scenario: Add two numbers
#	Given the first number is 50
#	  And the second number is 71
#	 When the two numbers are added
#	 Then the result should be 121
#
#
Scenario Outline: Add two numbers permutations
	Given the first number is <First number>
	  And the second number is <Second number>
	 When the two numbers are added
	 Then the result should be <Expected result>

Examples:
	| First number | Second number | Expected result |
	| 0            | 0             | 0               |
	| -1           | 10            | 9               |
	| 6            | 9             | 15              |


Scenario: Add two numbers - Table demo
	Given the table with numbers
		#| first number | second number |
		#| 50           | 71            |
		#| 1            | 2             |
		#| 3            | 4             |

		| Field         | Value |
		| first number  | 50    |
		| second number | 71    |
	 When the two numbers from the table are added
	 Then the result should be 121
