using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootyAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FootyAPI.Controllers
{
    [Route("api/player")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Player> Get()
        {
            var proPlayer = new Player {Name = "Uko Melis", Number = 9, Goals = 50};

            return proPlayer;
        }
    }
}