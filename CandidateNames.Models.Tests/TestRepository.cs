using System;
using System.Collections.Generic;

namespace CandidateNames.Models.Tests
{
    public class TestRepository :IStoreNames
    {
        private readonly List<string> _listOneNames;
        private readonly List<string> _listTwoNames;

        public TestRepository(List<string> listOneNames, List<string> listTwoNames)
        {
            _listOneNames = listOneNames;
            _listTwoNames = _listTwoNames;
        }
        public string[] RegisteredCandidatesSource1()
        {
            return _listOneNames.ToArray();
        }

        public string[] RegisteredCandidatesSource2()
        {
            return _listTwoNames.ToArray();
        }
    }
}