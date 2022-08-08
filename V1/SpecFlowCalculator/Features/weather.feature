Feature: weather

A short summary of the feature

@GetWeatherForcast
Scenario: GetWeatherForcast
	Given the input of values
	When execute the api
	Then the result is not null
