using DAL;
using ITelentCloudsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelentCloudsServices
{
    public class SearchForenameService : ISearchForenameService
    {
        private readonly ICandidateRepo CandidateRepo;
        private readonly IFileService   FileService;
        private readonly ICounterService CounterService;
        private readonly IValidationService ValidationService;
        private Dictionary<string, int> CandidateNames;
        
        public SearchForenameService(ICandidateRepo candidateRepo, IFileService fileService, ICounterService counterService, IValidationService validationServic)
        {
            CandidateRepo = candidateRepo;
            FileService = fileService;
            CounterService = counterService;
            CandidateNames = new Dictionary<string, int>();
            ValidationService = validationServic;
        }
        public  int FornameFirstCharacterCount(char forenameFirstCharacter)
        {
            int totalOccurance = 0;
            List<string> InvalidNames = new List<string>();

            ///TODO Move in AsynTask future work for better performance etc
            
            AddToCandidateDictionary(CandidateRepo.RegisteredCandidatesSource1());
            AddToCandidateDictionary(CandidateRepo.RegisteredCandidatesSource2());
            AddToCandidateDictionary(FileService.ReadFileContent("Source3.txt"));

            foreach (var item in CandidateNames)
            {
                var fullname = item.Key;

               if( ValidationService.IsValid(fullname))
                {
                    totalOccurance += CounterService.CountOccurance(forenameFirstCharacter, fullname);
                }
                else
                {
                    InvalidNames.Add(fullname);
                }
            }

            if(InvalidNames.Count > 0 )
            {
                FileService.WriteFile($"WrongName{DateTime.UtcNow.ToFileTime()}.txt", InvalidNames.ToArray());
            }

            return totalOccurance;
        }


        private void AddToCandidateDictionary(string[] names)
        {
            foreach (var item in names)
            {
                var key = item.Trim();
                if (!CandidateNames.ContainsKey(key))
                {
                    CandidateNames.Add(item.Trim(), 1);
                }
            }

        }
    }
}

