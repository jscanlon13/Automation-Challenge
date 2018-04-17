using System;
using System.Threading;
using Config.ConfigFiles;
using NUnit.Framework;
using OpenQA.Selenium;
using Test.PageObjects;


namespace Test.TestCases
{
    public class FreeWifiFacilities
    {
        public static void FilterHotels(IWebDriver driver)
        {
            // Search for Cork on the homepage of Trivago
            var trivagoHotelPage = new TrivagoHotelPage(driver);
            trivagoHotelPage.SearchCounty(Constant.CountyCork);

            var threeMonths = DateTime.Today.Month + Constant.NumberOfMonths;
            var currentDay = DateTime.Today.Day;
            var threeDays = DateTime.Today.Day + Constant.NumberOfMonths;

            // I've used the url to edit dates for the future as I had issues with datetimepicker 
            // and ran out of time to futher investigate
            var searchUrl =
                string.Format("https://www.trivago.ie/?aDateRange%5Barr%5D=2018-" + "{0}" + "-" + "{1}" + "&aDateRange%5Bdep%5D=2018-" + "{0}" + "-" + "{2}" + "&aPriceRange%5Bfrom%5D=0&aPriceRange%5Bto%5D=0&iPathId=42559&aGeoCode%5Blat%5D=51.896893&aGeoCode%5Blng%5D=-8.486316&iGeoDistanceItem=0&aCategoryRange=0%2C1%2C2%2C3%2C4%2C5&aOverallLiking=1%2C2%2C3%2C4%2C5&sOrderBy=relevance%20desc&bTopDealsOnly=false&iRoomType=7&cpt=4255903&iIncludeAll=0&iViewType=0&bIsSeoPage=false&bIsSitemap=false&", threeMonths, currentDay, threeDays);
            driver.Navigate().GoToUrl(searchUrl);           
            Thread.Sleep(2000);

            // Filter by Wifi
            trivagoHotelPage.FilterByWifi();

            Common.CheckExpectedResults(driver, Constant.FreeWifi);

            // Assert if Cork International Hotel is shown on the results and Jurys Inn Hotel is not
            Assert.IsTrue(Common.CorkInternationalHotel, "Cork Internation Hotel was not on the page for Wifi Facilites");
            Assert.IsFalse(Common.JurysInn, "Jurys Inn Hotel was on the page for Wifi Facilites");
        }
    }
}