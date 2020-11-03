using System;
using System.IO;
using ITelentCloudsServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TelentCloudsServices;

namespace TalentClouds_UnitTests
{
    [TestClass]
    public class FileServiceTests
    {
        private  IFileService FileService;
        private string FileName;
        private string ExpectedFileContent;
        private string Path;

        [TestInitialize]
        public void Setup()
        {
            var workingDirectory = Directory.GetCurrentDirectory();
            Path = workingDirectory.Substring(0, workingDirectory.IndexOf("bin"));
            FileService = new FileService();
            FileName = "";
            ExpectedFileContent = "Test";
        }

        [TestMethod]
        public void ReadFileContent_SuccessFull()
        {
            //Arrange 
             FileName = "FileData.txt";

            //Act 
            var fileContnet = FileService.ReadFileContent(FileName);

            //Assert
            Assert.IsNotNull(fileContnet);
            Assert.AreEqual(ExpectedFileContent, fileContnet);
        }
    }
}
