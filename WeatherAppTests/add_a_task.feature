Feature: Adding a task
  I want to be able to quickly add a task

  Scenario Outline: Search weather using postcode and city names
    Given I am on the Home screen
    Then I verify home screen
   	Then I verify weather screen
   	When I enter zipcode <zipcode>
    And I choose to Get Weather
    Then I must see Location as <location>
    Examples:
    |zipcode	|location	|
    |"IG2 7NZ"	|"Redbridge"|
    |"London"	|"London"	|


  Scenario: Verify weather details 
    Given I am on the Home screen
    Then I verify home screen
   	Then I verify weather screen
   	When I enter zipcode "London"
    And I choose to Get Weather
  	Then I must see Location as "London"
  	And Temperature is shown in Fahrenhite
  	And Windspeed is shown in mph
  	And Humidity is shown as percentage
  	And Visibility is displayed
  	And Time of Sunrise is displayed
  	And Time of Sunset is displayed
 
 Scenario Outline: Verify wrong post codes
    Given I am on the Home screen
    Then I verify home screen
   	Then I verify weather screen
   	When I enter zipcode <zipcode>
    And I choose to Get Weather
    Then I must see Incorrect Location Error alert
    Examples:
    |zipcode	|
    |"Trrrrr"	|
    |"00000"	|

  Scenario: Verify Get weather text changes to Search again
    Given I am on the Home screen
    Then I verify home screen
   	Then I verify weather screen
   	When I enter zipcode "London"
    And I choose to Get Weather
    Then I must see Get weather button text changed to search again

  Scenario: Search weather using city Name
    Given I am on the Home screen
    Then I verify home screen
   	Then I verify weather screen
   	When I enter zipcode "London"
    And I choose to Get Weather
    Then I must see Location as "London"
    When I enter zipcode "London,GB"
    And I choose search again
    Then I must see Location as "London"


Scenario Outline: Verify Empty Alert messages
    Given I am on the Home screen
    Then I verify home screen
   	Then I verify weather screen
   	When I enter zipcode <zipcode>
    And I choose to Get Weather
    Then I must see empty zip code Error alert
    Examples:
    |zipcode|
    |""		|



