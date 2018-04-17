# Automation-Challenge

I’ve written my solution in C# (Visual Studio Solution) using Selenium WebDriver.
I’ve split my project into TestSuites where the tests can be run, TestCases and a PageObjects Class for element ids. I’ve also created a Config project where I have a base class for the setup and tear down methods as well as a TestConfig class for browser setup and a constants class.

To run the tests, you can either run from nUnit or they can be run from within the solution.
It was quite challenging for me to set up as I didn’t have Visual Studio on my home PC and had a few issues with browser setup and references etc, so I included a portable version of firefox to run my tests so hopefully this works ok.

Also place the Projects folder on the Desktop and run from there.

Open Nunit from C:\Users\yourUsername\Desktop\Projects\nunit
Open Project from C:\Users\yourUsername \Desktop\Projects\dll_forNunit\Test.dll

Regards
John Scanlon
