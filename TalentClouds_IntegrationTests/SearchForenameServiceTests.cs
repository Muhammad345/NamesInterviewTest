using System;
using System.IO;
using DAL;
using ITelentCloudsServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TelentCloudsServices;

namespace TalentClouds_IntegrationTests
{
    [TestClass]
    public class SearchForenameServiceTests
    {
        private ICandidateRepo CandidateRepo;
        private IFileService FileService;
        private ICounterService CounterService;
        private IValidationService ValidationService;
        private ISearchForenameService SearchForenameService;
        private char SearchCharacter;

        [TestInitialize]
        public void Setup()
        {
            CandidateRepo = new CandidateRepo();
            FileService = new FileService();
            CounterService = new CounterService();
            ValidationService = new NamePatternValidationService();
            SearchForenameService = new SearchForenameService(CandidateRepo, FileService, CounterService, ValidationService);
            SearchCharacter = 'a';
        }

        [TestMethod]
        public void FornameCharacterCount_Success()
        {
            //Arrange 
            SearchCharacter = 'a';
            int expectedResult = 82;

            //Act 
            var actualResult = SearchForenameService.FornameFirstCharacterCount(SearchCharacter);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
