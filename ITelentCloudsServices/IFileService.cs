using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITelentCloudsServices
{
    public interface IFileService
    {
        string[] ReadFileContent(string fileName);
        string WriteFile(string fileName, string[] lines);
        string WriteFile(string fileName, string json);
    }
}
