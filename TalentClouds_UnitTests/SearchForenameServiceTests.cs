using System;
using System.IO;
using DAL;
using ITelentCloudsServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TelentCloudsServices;

namespace TalentClouds_UnitTests
{
    [TestClass]
    public class SearchForenameServiceTests
    {
        private  ISearchForenameService SearchForenameService;
        private Mock<ICandidateRepo> mockCandidateRepo;
        private Mock<IFileService> mockFileService;
        private Mock<ICounterService> mockCounterService;
        private Mock<IValidationService> mockValidationService;
        private char SearchCharacter;
        private string[] Source1_Names;
        private string[] Source2_Names;
        private string[] Source3_Names;
        private int  expecrtedCount = 10;
        private bool validationResult = true;


        [TestInitialize]
        public void Setup()
        {
            Source1_Names = new string[] { "AnyName,LastName","FirstName,LastName"};
            Source2_Names = new string[] { "AnyName,LastName" };
            Source3_Names = new string[] { "FirstName,LastName" };

            mockCandidateRepo = new Mock<ICandidateRepo>();
            mockCandidateRepo.Setup(mock => mock.RegisteredCandidatesSource1()).Returns(Source1_Names);
            mockCandidateRepo.Setup(mock => mock.RegisteredCandidatesSource2()).Returns(Source2_Names);

            mockFileService = new Mock<IFileService>();
            mockFileService.Setup(fmock => fmock.ReadFileContent(It.IsAny<string>())).Returns(Source3_Names);

            mockCounterService = new Mock<ICounterService>();
            mockCounterService.Setup(cmock => cmock.CountOccurance(It.IsAny<char>(), It.IsAny<string>())).Returns(expecrtedCount);

            mockValidationService = new Mock<IValidationService>();
            mockValidationService.Setup(vmock => vmock.IsValid(It.IsAny<string>())).Returns(validationResult);

            SearchForenameService = new SearchForenameService(mockCandidateRepo.Object, mockFileService.Object, mockCounterService.Object, mockValidationService.Object);
            SearchCharacter = 'a';
        }

        [TestMethod]
        public void FornameCharacterCount_Success()
        {
            //Arrange 
            SearchCharacter = 'a';
            int expectedResult = 20;

            //Act 
            var actualResult = SearchForenameService.FornameFirstCharacterCount(SearchCharacter);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
            mockCandidateRepo.Verify(x => x.RegisteredCandidatesSource1(), Times.Once);
            mockCandidateRepo.Verify(x => x.RegisteredCandidatesSource2(), Times.Once);
            mockFileService.Verify(x => x.ReadFileContent(It.IsAny<string>()), Times.Once);
            mockValidationService.Verify(x => x.IsValid(It.IsAny<string>()), Times.Exactly(2));
        }
    }
}
