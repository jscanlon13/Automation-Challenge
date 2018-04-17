using System;
using NUnit.Framework;
using OpenQA.Selenium;


namespace Config.ConfigFiles
{
    public abstract class BaseNunitClass
    {
        public static IWebDriver Driver;

        [SetUp]
        public void SetupTest()
        {
            Driver = TestConfig.Settings.GetBrowser();
        }


        [TearDown]
        public void TeardownTest()
        {
            try
            {
                Driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
    }
}
