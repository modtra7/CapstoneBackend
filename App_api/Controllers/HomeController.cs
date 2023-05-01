using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World!");
        }

        [HttpPost]
        public IActionResult ProcessGuess([FromBody] string guess)
        {
            string response = "Guess reveived: " + guess;
            return Ok(response);
        }
    }
}

