Feature: Promotional
	

@ignore @promotional
Scenario: Add new promotional
	Given Promotional page is opened
	When I press add new promotional
	Then new window is opened

    @promotionalCancelButton
	Scenario: I press cancel button 
	Given page with promotional is opened
	When i click cancel button , page is closed
	And i redirected to promotional page

	 @promotionaldetails
	Scenario: Fill all neccessary details
	Given page with details is opened
	When i fill all details
	Then i can press save promotional

	@activatePromotion
	Scenario: i activate created promotional
	Given im on promotional page
	When i click activate button
	Then promotional i activated

	@deactivatePromotion
	Scenario: i deactivate created promotional
	Given im on promotional page
	When i click deactivate button
	Then promotional i deacactivated, go back

	@deletePromotionNo
	Scenario: i cancel delete existing promotion
	Given im on promotional page
	Then i click view promotional button
	When page with promotional is opene
	And i can click delete button
	Then i cancel deletepromotional

	@deletePromotionYes
	Scenario: i delete existing promotion
	Given im no promotional page
	Then i click any promotional
	And i can click Deletepromotional button
	Then i can confirm with YES and check on promotional page


