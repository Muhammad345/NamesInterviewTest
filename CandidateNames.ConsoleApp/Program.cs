using CandidateNames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace CandidateNames.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new CandidateRepo();
            var characterCounter = new CharacterCounter(repo);

            var result = characterCounter.Count();

            var x = 1;
        }
    }
}
