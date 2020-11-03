using ITelentCloudsServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelentCloudsServices
{
    public class FileService : IFileService
    {
        private readonly string Path;

        public FileService()
        {
            Path = ConfigurationManager.AppSettings["path"];
        }

        public string[] ReadFileContent(string fileName)
        {
            var filePath = GetFullFilePath(fileName);

            if (File.Exists(filePath))
            {

                return  File.ReadAllLines(filePath);
            }

            return null;
        }

        public string WriteFile(string fileName,string[] lines)
        {
            var filePath = GetFullFilePath(fileName); 

            if (File.Exists(filePath))
            {

                File.WriteAllLines(filePath, lines);
            }

            return string.Empty;
        }

        private string GetFullFilePath(string fileName)
        {
            if(string.IsNullOrWhiteSpace(Path))
            {
                throw new ArgumentException("Invalid Patht to read or write file");
            }

            return Path + fileName;
        }
    }
}
