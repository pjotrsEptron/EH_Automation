@ignore @addnewusers
Feature: Register new Users


Scenario: Register new Users
	Given register user page
	And i can register users
	When users are registered i can found then

	Scenario: Edit new added Usrs
	Given new user profile
	When i update new user profile fields
	And upload new image
	Then i can press save button
	And check that user info is updated

	Scenario: Activate new Users
	Given new user profile is opened
	Then i can click deactivete user
	And press activate button back

	Scenario: Deactivate new User

	Scenario: Delete new User No
	Given i can click Delete button to delete this user
	And i can cancel delete action by pressing NO

	Scenario: Delete new User Yes
	Given i can press delete buton
	And click YES button to delete user
	Then i can check that user is deleted




