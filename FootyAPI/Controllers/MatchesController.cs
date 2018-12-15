using System.Collections.Generic;
using FootyAPI.Entities.Contexts;
using FootyAPI.Logic.Builders;
using FootyAPI.Logic.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        public MatchesController(IMatchBuilder matchBuilder)
        {

        }

        [HttpGet]
        public ActionResult<List<Match>> Get()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult<HttpResponse> AddMatch([FromBody] Match match)
        {
            var context = new FootyDBContext();

            //context.Players.Add();
            context.SaveChangesAsync();

            return Ok();
        }
    }
}