[![Coffee](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://buymeacoffee.com/keva161)

# POM Framework

POM framework is a framework for Selenium web driver which uses the page object model and allows test cases to be written in a language that reads just like English. This enables higher levels of collaboration between members of your team and allows for non-technical stakeholders the ability to easily read your tests and understand their intention. 

## Driver setup

![](https://kevintuck.co.uk/images/pom_driver.png)()

Open up `BaseTest.cs` in Test > Base and change the arguments passed to the `CreateBrowser` function to `Network.Local` if you want to run a Selenium test on your local machine. Or `Network.Global` if you want to run a test on SauceLabs (You will need to ensure your credidentials are stored as environment variables for this to work. You can read instructions for doing this [here](https://wiki.saucelabs.com/display/DOCS/Best+Practice%3A+Use+Environment+Variables+for+Authentication+Credentials)). SauceLabs tests also currently only run via the latest version of Chrome. But this can be changed in the `CreateSauceDriver` within `WebDriverFactory.cs`.

## Writing Test Cases

![](https://kevintuck.co.uk/images/pom_testcase.png)()

Tests are writing using the `Pages.<name>.<Action>`notation. Create a new page buy creating a new class within PageObjects/<PageName>. Making sure to create the associated mapping file (with lists the elements that are available to be interacted with on the page). Also be sure to populate the classes using the excisting pages as a reference. You will also need to edit `Pages.cs` with reference to the new page so that it gets instantiated.

## Locating elements to add to the mapping file

Locating elements on the page is done in the same way as standard Selenium (using ID, Classes etc as selectors). But instead of writing `driver.FindElement(By.Id("foo"));` you simply rely on the included Helper class and type `Helper.LocateElement(Locators.ID, "foo");`.

There are also additional Helper classes included for retrieving the current pages url, Navigating to a specific url and highlighting page elements.
