using System;
using System.Collections.Generic;
using FootyAPI.Entities.Contexts;
using FootyAPI.Logic;
using FootyAPI.Logic.Builders;
using FootyAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        private readonly IDbManager _dbManager;

        public MatchesController(IDbManager dbManager)
        {
            _dbManager = dbManager ?? throw new ArgumentNullException(nameof(dbManager));
        }

        [HttpGet]
        public ActionResult<List<Match>> Get()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult<HttpResponse> AddMatch([FromBody] Match match)
        {
            _dbManager.AddMatch(match);

            return Ok();
        }
    }
}