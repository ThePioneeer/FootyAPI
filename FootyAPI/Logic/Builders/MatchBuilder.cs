using System;
using FootyAPI.Models;

namespace FootyAPI.Logic.Builders
{
    public class MatchBuilder : IMatchBuilder
    {
        private readonly IDBManager _dbManager;

        public MatchBuilder(IDBManager dbManager)
        {
            _dbManager = dbManager ?? throw new ArgumentNullException(nameof(dbManager));
        }

        public void BuildMatch(Match match)
        {

        }
    }
}
