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

        [Route("")]
        public IActionResult GetAll()
        {
            return View("Index");
        }

        [Route("{id}")]
        public IActionResult Get(string id)
        {
            return View();
        }

        [Route("Create")]
        public IActionResult Create()
        {
            return new OkResult();
        }
    }
}
