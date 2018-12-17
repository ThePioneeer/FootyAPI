using System;
using FootyAPI.Models;

namespace FootyAPI.Logic.Builders
{
    public class MatchBuilder : IMatchBuilder
    {
        private readonly IDbManager _dbManager;

        public MatchBuilder(IDbManager dbManager)
        {
            _dbManager = dbManager ?? throw new ArgumentNullException(nameof(dbManager));
        }

        public void BuildMatch(Match match)
        {

        }
    }
}
