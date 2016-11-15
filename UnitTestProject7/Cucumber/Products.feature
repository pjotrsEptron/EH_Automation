@ignore @Products

Feature: Products


Scenario: Add new product 
	Given openProduct Page
	Then i can press Add New product
	And fill all details to product
	Then i can check product is created

	Scenario: Activate Products
	Given  open created product page
	Then i press deactivate button in Products
	When product is deactivated i press activate button

	Scenario: Deactivate Products
	Given  open created product page
	Then i press deactivate button in Products
	When product is deactivated i press activate button

	Scenario: Edit Product

	Scenario: Delete Product No
	Given product page is opened
	Then i press delete button to delete
	And press NO to cancel delete product

	Scenario: Delete Product Yes
	Given product page still opened
	Then i press delete button agaon
	And press YES to delete product
	Then i can check that product is deleted
