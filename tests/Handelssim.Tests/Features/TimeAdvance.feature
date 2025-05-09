Feature: Simulation time advancement
  As a simulation engine
  I want to advance time by days
  So that the world progresses correctly from day to day, week to week, month to month, and year to year

  Scenario: Advancing one day
    Given the simulation starts at day 1/W1/M1/Y1
    When the simulation ticks forward
    Then the simulation should be at day 2/W1/M1/Y1

  Scenario: Advancing to next week
    Given the simulation starts at day 7/W1/M1/Y1
    When the simulation ticks forward
    Then the simulation should be at day 1/W2/M1/Y1

  Scenario: Advancing to next month
    Given the simulation starts at day 7/W4/M1/Y1
    When the simulation ticks forward
    Then the simulation should be at day 1/W1/M2/Y1

  Scenario: Advancing to next year
    Given the simulation starts at day 7/W4/M12/Y1
    When the simulation ticks forward
    Then the simulation should be at day 1/W1/M1/Y2