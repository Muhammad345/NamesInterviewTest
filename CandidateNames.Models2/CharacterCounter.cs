﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CandidateNames.Models.Interfaces;

namespace CandidateNames.Models
{
    public class CharacterCounter
    {
        private readonly IStoreNames _repo;

        public CharacterCounter(IStoreNames repo)
        {
            _repo = repo;
        }

        public CountResult Count()
        {
            var result = new CountResult();

            var completeList = _repo.RegisteredCandidatesSource1().Concat(_repo.RegisteredCandidatesSource2());

            foreach (var name in completeList)
            {
                var nameArray = name.Split(',');

                if (nameArray.Length != 2)
                {
                    result.Exceptions.Add(name);
                }

            }

            return result;
        }
    }
}
