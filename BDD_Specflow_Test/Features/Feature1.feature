Feature: Blood Pressure Categorization

  Scenario: Categorize low blood pressure
    Given the systolic is 70 and diastolic is 40
    When the blood pressure is calculated
    Then the category should be Low

  Scenario: Categorize ideal blood pressure
    Given the systolic is 90 and diastolic is 60
    When the blood pressure is calculated
    Then the category should be Ideal

  Scenario: Categorize pre-high blood pressure
    Given the systolic is 120 and diastolic is 80
    When the blood pressure is calculated
    Then the category should be PreHigh

  Scenario: Categorize high blood pressure
    Given the systolic is 140 and diastolic is 90
    When the blood pressure is calculated
    Then the category should be High

  Scenario: Categorize invalid blood pressure
    Given the systolic is 195 and diastolic is 39
    When the blood pressure is calculated
    Then the category should be Invalid
