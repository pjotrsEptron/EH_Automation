@ignore @partner
Feature: Partners Add


Scenario: Add new Partner
	Given i have opened pArtners page
	And i can add new partner
	Then i can check if partner is created


	Scenario: Activate Partners
	Given open Partners Details 
	Then i press activate button in partners
	And i press deactivate button in partners

	Scenario: Deactivate Partners
	Given open Partners Details 
	Then i press activate button in partners
	And i press deactivate button in partners

	Scenario: Edit Partners
	Given partners list when click back
	Then i found added partner 
	And click view to open view
	Then i update partner Details
	And i can see updated partner Details
	Then i can check if partner is edited

	Scenario: Delete Partner NO
	Given partner has been found by search
	Then i click delette button to delete Partner
	And i press NO to cancel delete partner

	Scenario: Delete PArtner YES
	Given i see previous partner
	Then i press delete button again
	And i press YES to delete partner
	Then i can check if deleted
