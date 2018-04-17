using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace Config.ConfigFiles
{
    public class TestConfig
    {
        public class Settings
        {
            public static IWebDriver GetBrowser()
            {
                var profile = new FirefoxProfile(@"C:\Users\" + Environment.MachineName + "\\Desktop\\Projects\\Misc\\ffportable\\Data\\profile");
                var portableLocation = @"C:\Users\" + Environment.MachineName + "\\Desktop\\Projects\\Misc\\ffportable\\FirefoxPortable.exe";
           
                IWebDriver webDriver = new FirefoxDriver(new FirefoxBinary(portableLocation), profile, TimeSpan.FromMinutes(3));
                webDriver.Navigate().GoToUrl(Constant.HotelWebsite);
                webDriver.Manage().Window.Maximize();

                return webDriver;
            }
        }
    }
}
