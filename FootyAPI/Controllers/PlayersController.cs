using System.Collections.Generic;
using System.Linq;
using FootyAPI.Entities.Contexts;
using FootyAPI.Logic.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
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
            var context = new FootyDBContext();
            var playerEntity = new Entities.Player {PlayerName = player.Name, Number = player.Number};

            context.Players.Add(playerEntity);
            context.SaveChangesAsync();

            return Ok();
        }
    }
}