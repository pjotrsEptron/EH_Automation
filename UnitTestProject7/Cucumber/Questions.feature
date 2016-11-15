@ignore @question
Feature: Questions
	

Scenario: Open Question page
Given open questions page

Scenario: Add New Question
Given question page is opened
Then i click add button to add a question
And i fill all question details
Then i press save button to save question

Scenario: Edit Added Question
Given open question after it was found
Then i can edit question details
And press save edited deatils
Then i can check edited question

Scenario: Delete Question No
Given questions list is opened
Then i open question
And i press delete question
Then i press NO delete question
And i check that question is not deleted

Scenario: Delete Question Yes
Given question list is opened
Then i press delete question button
And i confirm delete question
Then i can check that question is deleted

Scenario: Deactivate Question
Given question is added
Then i press deactivate question
And check that question is deactivated

Scenario: Activate Question
Given question is deactivated
Then i press activate question
And check that question is activated