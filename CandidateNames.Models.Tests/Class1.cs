using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CandidateNames.Models.Tests
{
    [TestFixture]
    public class Given_A_List_Of_One
    {

        [Test]
        public void When_the_name_only_has_one_word_Then_an_exception_will_be_stored()
        {
            var testData = new List<string> { Guid.NewGuid().ToString() };

            var repo = new TestRepository(testData, null);

            var sut = new CharacterCounter(repo);

            var result = sut.Count();

            Assert.That(result.Exceptions.Count, Is.EqualTo(1));
        }
    }

    [TestFixture]
    public class Given_A_List_Of_Two
    {

        [Test]
        public void When_the_name_only_has_one_word_Then_an_exception_will_be_stored()
        {
            var testData = new List<string>
            {
                Guid.NewGuid().ToString(),
                Guid.NewGuid().ToString()
                
            };

            var repo = new TestRepository(testData, null);

            var sut = new CharacterCounter(repo);

            var result = sut.Count();

            Assert.That(result.Exceptions.Count, Is.EqualTo(2));
        }
    }
}
