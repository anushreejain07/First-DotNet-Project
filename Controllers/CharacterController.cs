using System.Collections.Generic;
using AspNetCoreWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CharacterController : ControllerBase
    {
        private static List<Character> characters=new List<Character>{

            new Character(),
            new Character {Name="Sam",Class=RpgClass.Cleric}
        };

        [HttpGet("GetAll")]
        //[Route("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        [HttpGet]
        public ActionResult<Character> GetSingle()
        {
            return Ok(characters[0]);
        }

    }
}