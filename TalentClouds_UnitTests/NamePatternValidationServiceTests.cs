using System;
using System.IO;
using ITelentCloudsServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TelentCloudsServices;

namespace TalentClouds_UnitTests
{
    [TestClass]
    public class NamePatternValidationServiceTests
    {
        private IValidationService ValidationService;
        private  char NameSeparator;
        private string FullName;

        [TestInitialize]
        public void Setup()
        {
            ValidationService = new NamePatternValidationService();
            FullName = string.Empty;
        }

        [TestMethod]
        public void IsValid_Success()
        {
            //Arrange 
            FullName = "Akhtar,Irfan";
            var expectedResult = true;

            //Act 
            var actualResponse = ValidationService.IsValid(FullName);

            //Assert
            Assert.AreEqual(expectedResult, actualResponse);
        }

        [TestMethod]
        public void IsValid_InValid()
        {
            //Arrange 
            FullName = "Akhtar,";
            var expectedResult = false;

            //Act 
            var actualResponse = ValidationService.IsValid(FullName);

            //Assert
            Assert.AreEqual(expectedResult, actualResponse);
        }
    }
}
