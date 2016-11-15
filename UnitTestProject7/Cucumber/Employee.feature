@addnewEmployee
Feature: Add New Employee


Scenario: Add New Employee
When I go to Add new Employee page
And I submit the a form
And I go to employees a list
Then I should see the new employee added

		Scenario: Edit employee
	When any user page is opened
	Then i can update fields
	And press save button
	Then i will see an updated profile

	Scenario: Delete Employee- Cancel Action
	When Open Any Employee from a List
	Then i can click Delete button 
	And i can cancel delete Action of Empoloyee

   Scenario: Delete Employee - Confirm Action
	When i go to EmployeeList again
	And Open previous Employee
	Then i can delete user from a list


#Scenario: Add Album with cover image and no photos insdie
#Given New Employee
#Then i click album tab i can create album
#When album is created i can upload images and update
#Then i can save
#
#Scenario: Add Album cover image and 1 photo inside
#Given previous album
#When i click Add content to Album i can upload 1 photo insdie
#Then i can preview image
#And click save changes
#
#Scenario: Add Album cover image and more then 1 inside
#Given previous page
#Then i add images to album
#And click save

#	Scenario: Delete Album NO
#Given albums list
#When i press delete button
#And i click NO
#Then album not deleted
#
#	Scenario: Delete Album YES
#Given albums list of albums
#When i press delete button from list
#And i click YES
#Then album is deleted








