@ignore @contacts
Feature: Contact Page



Scenario: Open Contact Page
	Given contact page is opened

	Scenario: I choose filtering for Contacts
	Given contact page is opened
	Then i did filtering


	Scenario: I delete contact NO
	Given i have contact list opened
	Then i click details and contact window is opened
	And i can press delete button in contact
	Then i press NO button in Contact
	And check that contact is NOT deleted

	Scenario: I delete contact YES
	Given Open Contact by pressing deatils
	Then i press deletebutton in contact
	And i confirm delete action for contact
	Then i check that contact is deleted

