Feature: World Creation

  Scenario: Create a new world with 5 cities
    Given I create a new world
    Then the world should contain 5 cities