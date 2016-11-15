@ignore @saloon
Feature: Add new salon
	


Scenario: Add new salon
	Given Salon list
	And i click add new saloon bytton
	When new page of saloon is opened
	Then i fill all details
	And press save button to save
	When saloon is saved i go back to list and check it

	Scenario: Edit new salon
	Given list of salon
	When i update existing salon
	Then i can save it
	And see result

	Scenario: Deactivate Salon
	Given lists of salons
When i open salon detaiils
Then i can deactivate it
And activate it

Scenario: Activate Salon
	
	Scenario: Delete Salon NO
	When i open any salon from a list
	Then i can press delete button in salon
	And i  cancel delete action
	Then i can delete salon from db
	And check if its deleted

		Scenario: Delete Salon YES

