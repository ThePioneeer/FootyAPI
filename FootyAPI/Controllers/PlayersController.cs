using System;
using System.Collections.Generic;
using System.Linq;
using FootyAPI.Entities.Contexts;
using FootyAPI.Logic;
using FootyAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IDbManager _dbManager;

        public PlayersController(IDbManager dbManager)
        {
            _dbManager = dbManager ?? throw new ArgumentNullException(nameof(dbManager));
        }

        [HttpGet]
        public ActionResult<List<Entities.Player>> Get()
        {
            using (var context = new FootyDBContext())
            {
                var players = context.Players.ToList();

                return players;
            }
        }
         
        [HttpPost]
        public ActionResult<HttpResponse> AddPlayer([FromBody] Player player)
        {
            _dbManager.AddPlayer(player);

            return Ok();
        }
    }
}