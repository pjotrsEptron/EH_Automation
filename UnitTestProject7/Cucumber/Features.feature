@ignore @features
Feature: Features


Scenario: Add features
	When i open product features link 
	Then i create new feature
	And go back to check this feature in list

	Scenario: Edit Feature
	Given found feature in a list
	And i click to view feature
	Then i can edit it
	And check that feature is edited

	Scenario: Cancel Delete feature
	Then i can cancel delete action

		Scenario: Delete feature
	Then i can delete feature
    And check deleted feature


