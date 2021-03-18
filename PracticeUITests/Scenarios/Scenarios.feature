Feature: Scenarios to perform actions on the countdown application

@Chrome
Scenario: Login to Countdown & purchase groceries
	Given I have logged into the portal
    And I choose to order items from the website
	When I place an order