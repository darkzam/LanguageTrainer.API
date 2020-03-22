using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Controllers
{
    [Controller]
    [Route("")]
    [Route("Mistakes")]
    public class MistakesController : Controller
    {
        public MistakesController()
        {
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            return View("Index");
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create()
        {
            return new OkResult();
        }
    }
}
