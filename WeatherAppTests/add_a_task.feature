Feature: Adding a task
  I want to be able to quickly add a task

@addTask
  Scenario: Verify Home screen
    Given I am on the Home screen
    Then I verify home screen
   	Then I verify weather screen
   	When I enter zipcode "IG2 7NZ"
    And I choose to Get Weather
