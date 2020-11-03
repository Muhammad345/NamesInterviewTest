using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CandidateNames.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GroupFirstDataSource()
        {

            string testFirstChar = "B";
            int expectedResult = 4;

            var repo = new DAL.CandidateRepo();

            var result1 = repo.RegisteredCandidatesSource1().GroupBy(x => x.Contains(", ,,") ).AsEnumerable().Select( new { FirstName = "", LastName = "" } );
            var result2 = repo.RegisteredCandidatesSource2().Where(x => x.ToString().Contains(testFirstChar)).GroupBy(x => x.Contains(", ,,"));

            var finalresult = (from x in result1
                join y in result2.Contains(x.) == false 
            
            
                select x)
            ;

            Assert.AreEqual(expectedResult, finalresult.Count());
        }

       


    }
}
