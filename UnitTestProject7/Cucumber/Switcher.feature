@ignore @sw 
Feature: switcher
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario: switcher
	Given im logged in cms
	And menu is visible on the left
	When switch to compay
	Then the company info is visible
