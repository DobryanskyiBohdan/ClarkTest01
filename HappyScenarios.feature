Feature: HappyScenarios
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Happy Scenario
	Given Open link "staging.clark.de/de/app/contracts?cv=2"
	And Click on the button "AngeboteElement"
	Then Select "Privathaftpflicht" category
	Then Click "WeiterButton" to navigate to questionaire
	Then Select "MichAlleineAnswer" answer for Wen möchtest du versichern?
	Then Select "KeinerDerFalleTrifftAuchMichZuAnswer" answer for Trifft einer der aufgeführten Fälle auf dich zu?
	Then Select "ImFalleEinesSchadensSollMeineAnswer" for Möchtest du bei einem Schadensfall einen Teil selbst bezahlen?
	Then Input "" to the fild for Hast du noch weitere Informationen oder Anmerkungen für uns?
	And Click Zum Angebote to open offers page
	Then Select "Second" insurance
	Then Login to application using email "Dynamic" and "We-L0ve-Insurance" password
	Then Input value Anrede "HerrRadiobutton" Vorname "Test" Nachname "TestN" Geburtsdatum "01.01.2001" Strase "testStr" Hausnr "h01" PLZ "60306" Ort "testOrt" Telefonnummer "015229320777"
	Then Select "NachsterWerktagRadiobutton" for Gewünschter Versicherungsbeginn and "NeinRadiobutton" for Vorschäden
	Then Input IBAN "DE55500105174529223988" and select checkbox "true"
	Then Verify Deine Angaben block
	And Verify Awesome page appearence
	Then Verify redirect to Manager page 
	