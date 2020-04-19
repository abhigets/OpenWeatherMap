Feature: Weather App
       In order to head to office
       As a curious mind
       And I am also keen to know weather details of a specific city
       Then I can carry right gear w.r.t weather conditions

Background: 
        Given I have a api key for weather app

@scenario2
Scenario: Find max and minimum temperature for a specific city
       Given I have the weather deatils for "Paris"
       Then I print the minimum tempeature to console
       And I print the maximum temperature to console
