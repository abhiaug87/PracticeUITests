This is a page object model framework created using Selenium, Specflow & C#. The framework is seggregated into various parts for better understandablibity & easier maintainability.

Scenarios Folder:
Conatains specflow file with the BDD user scenarios.

Steps Folder:
This contains the step definitions class file which has the logic for the user scenarios mentioned in the specflow file. This folder also has the base class whose properties are inherited in the step definitions section.

Page objects Folder:
This contains the page objects class file which contains all the element ids that are used in the project.

Data Folder:
This contains a class file which has logic for allowing the framework to read data from a json file rather than hard coding the test data into the framework. It also contains a json file which stores all the test data that will be used by the application under test.

Utilities Folder:

