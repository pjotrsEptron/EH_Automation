@ignore @brands
Feature: Add, Edit, Remove, etc Brands


Scenario: Open Brand Section
	Given I click Brands link on the left menu
	And then brands page is opened

	Scenario: Add New Brands
	Given brands page is opened
	Then i click add new brand
	And i fill all detaills
	Then i click Save Changes
	When brands is created i go back to find this brand in search

	Scenario: Activate Brand
	Given brand is found in search
	Then i open it
	And i click Activate button
	Then i check that brand is activated in page
	And i go back to check that brand is activated there

	Scenario: Deactivated Brand
	Given i open brand page
	And i click deactivated button
	Then i check that brad is deactivated in page
	And i go back to check that brand is deactivated in list

	Scenario: Edit Brand
	Given i click open button to open brand
	Then i update name
	And go back to check name is edited

	Scenario: Delete BrAND No
	Given i open this brand
	And then i click Delete button
	Then i click No
	
	Scenario: Delete Brand Yes
	Given i can click delete brand
	Then i click Yes and check brand in search
  
	Scenario: Check brands companies
	Given i open brand info
	Then i click brand companies tab
	And i check that brand companies list is visible