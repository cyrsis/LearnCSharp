Feature: PlayerCharacter
	In order to play the game
	As a human player
	I want my character attributes to be correctly represented

Scenario: Elf race characters get additional 20 damage resistance using data table
	Given I'm a new player
		And I have the following attributes
		| attribute  | value |
		| Race       | Elf   |
		| Resistance | 10    |
	When I take 40 damage
	Then My health should now be 90
