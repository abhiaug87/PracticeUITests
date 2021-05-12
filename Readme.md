A. Framework Description:

This is a page object model framework created using Selenium, Specflow & C#. The framework is seggregated into various parts for better understandablibity & easier maintainability. This framework has the capability of running tests on real browsers & in headless mode. 

Scenarios Folder:
Contains specflow file with the BDD user scenarios.

Steps Folder:
This contains the step definitions class file which has the logic for the user scenarios mentioned in the specflow file. This folder also has the base class whose properties are inherited in the step definitions section.

Page objects Folder:
This contains the page objects class file which contains all the element ids that are used in the project.

Data Folder:
This contains a class file which has logic for allowing the framework to read data from a json file rather than hard coding the test data into the step definition. It also contains a json file which stores all the test data that will be used by the application under test.

Utilities Folder:
This contains the following class files.
1. Common Constants - This contains code for location of the browser drivers, names of the tags that are used in the SpecFlow file & base url address 
2. Hooks - This contains BeforeScenario & AfterScenrio functions that direct the test to perform actions before it starts & after it ends. 
Before starting the test checks whether it has to run the test has to run on a real browser or in headless mode depending on the tag mentioned on top of the scenario in the 
SpecFlow file. 
After the test is over, the framework captures images of any failed tests & then disposes the browser.
3. DriverFactory - This contains the logic for running tests in real browser or headless mode. It also contains logic for driver timeout & maximize while running tests in real browser mode.

B. Running Tests:

1. Install Microsoft visual studio (community edition will do)
2. Install SpecFlow for visual studio
3. Create a folder called "chromedriver" under "C:\Users\yourusername\AppData\Local\Temp" & add the chrome driver version supported by your browser in this folder for the web browser to initiate. Make sure you name it as "chromedriver.exe"
4. Run the tests from Test Explorer
