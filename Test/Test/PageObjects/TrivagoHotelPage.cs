using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Test.PageObjects
{
    public class TrivagoHotelPage
    {
        #region Elements
        [FindsBy(How = How.Id, Using = "horus-querytext")]
        private readonly IWebElement searchField = null;
        [FindsBy(How = How.XPath, Using = "//div/div/div[2]/button")] 
		private readonly IWebElement btnSearch = null;
        [FindsBy(How = How.XPath, Using = "//div[@id='js_filterlist']/div/div[2]/section[5]/ul/li[3]/button")] 
		private readonly IWebElement wifiFilter = null;
        [FindsBy(How = How.CssSelector, Using = "button.fl-group__btn-wrap.pointer")] 
		private readonly IWebElement spaFilter = null;
        #endregion

	    private readonly IWebDriver driver;


        /// <summary>
        /// jscanlon : 15/04/18
        /// Initial elements on page
        /// </summary>
        /// <param name="driver"></param>
        public TrivagoHotelPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        /// <summary>
        /// jscanlon : 15/04/18
        /// </summary>
        /// <param name="county">county to search for</param>
        public void SearchCounty(string county)
        {
            searchField.SendKeys(county);
            btnSearch.Click();
        }


        /// <summary>
        /// jscanlon : 15/04/18
        /// Filter hotels by free wifi
        /// </summary>
        public void FilterByWifi()
        {
            if (wifiFilter.Displayed)
            {
                wifiFilter.Click();
            }       
        }


        /// <summary>
        /// jscanlon : 15/04/18
        /// Filter hotels by spa facilities
        /// </summary>
        public void FilterBySpaFacilities()
        {
            if (spaFilter.Displayed)
            {
                spaFilter.Click(); 
            }           
        }          
    }
}
