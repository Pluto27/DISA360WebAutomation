Feature: NonChromeBrowser
	Testing Non chrome browsers

@ToDoApp
Scenario: Add items to the ToDoApp - Chrome
	Given Navigate to App
	And I select the first item
	And I select the second item
	And I enter the new value in textbox
	When I click the submit button
	Then I verify whether the item is addded to the list