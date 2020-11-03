using System;
using System.IO;
using ITelentCloudsServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TelentCloudsServices;

namespace TalentClouds_UnitTests
{
    [TestClass]
    public class CounterServiceTests
    {
        private ICounterService CounterService;
        private string FullName = "";
        private char Letter = 'a';

        [TestInitialize]
        public void Setup()
        {
            CounterService = new CounterService();
            FullName = "Irfan Akhtar";
        }

        [TestMethod]
        public void CountOccurance_Success()
        {
            //Arrange 
            Letter = 'a';
            var expectedResult = 3;

            //Act 
            var actualOccurance = CounterService.CountOccurance(Letter, FullName);

            //Assert
            Assert.AreEqual(expectedResult, actualOccurance);
            
        }
    }
}
