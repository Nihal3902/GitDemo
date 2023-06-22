Feature: Booking flight by selecting date

booking flight by selecting date 

@tag1
Scenario: Flight booking
	Given go to url and login
	When select city of diparture
	And select city of arrival
	And select departur date 
	Then go and click search 
@tag2
Scenario: Flight booking new
	Given go to url and login
	When select city of diparture
	And select city of arrival
	And select departur date 
	Then go and click search
