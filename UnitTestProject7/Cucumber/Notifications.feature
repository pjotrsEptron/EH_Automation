@ignore @notifications
Feature: Send Messages to Client
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario: Send Message to client
	Given i open notification message
	And I can compose message
	And i will check that message is sent

	Scenario: Cancel Sending message
	Given i create a new message again
	Then i click cancel button

	Scenario: Draft message
	Given create a new message
	Then i click draft button
	And message moved to draft
	Then i can check it

