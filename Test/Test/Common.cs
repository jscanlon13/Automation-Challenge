using System;
using Config.ConfigFiles;
using OpenQA.Selenium;


namespace Test
{
    public class Common
    {
        public static bool TheRiverLee;
        public static bool JurysInn;
        public static bool CorkInternationalHotel;


        public static void CheckExpectedResults(IWebDriver driver, string filter)
        {
            try
            {
                // 25 is the maximum search on the page
                for (var counter = 1; counter < 25; counter++)
                {
                    var hotel = driver.FindElement(By.XPath("//li[" + counter + "]/article/div/div[3]/div")).Text;

                    switch (filter)
                    {
                        case Constant.FreeWifi:
                            if (hotel.Contains(Constant.CorkInternationalHotel)){ CorkInternationalHotel = true; }
                            if (hotel.Contains(Constant.JurysInnCork)){ JurysInn = true; }
                            break;
                        case Constant.SpaFacilities:
                            if (hotel.Contains(Constant.TheRiverLee)){TheRiverLee = true;}
                            if (hotel.Contains(Constant.JurysInnCork)){ JurysInn = true; }
                            break;
                    }
                }
            }
            catch (Exception)
            {
                // swallow exception
            }
        }
    }
}
