using System;
using Config.ConfigFiles;
using NUnit.Framework;


namespace Test.TestSuites.Tests
{
    [TestFixture]
    public class TrivagoHotelsTests : BaseNunitClass
    {
        [Test]
        public void FreeWifi()
        {
            try
            {
                TestCases.FreeWifiFacilities.FilterHotels(Driver);
            }
            catch (Exception exception)
            {
                Console.WriteLine(DateTime.Now.ToString("U") + " " + exception.Message);
                throw;
            }
        }


        [Test]
        public void FreeSpa()
        {
            try
            {
                TestCases.SpaFacilities.FilterHotels(Driver);
            }
            catch (Exception exception)
            {
                Console.WriteLine(DateTime.Now.ToString("U") + " " + exception.Message);
                throw;
            }
        }
    }
}