using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Controllers
{
    [Controller]
    public class SourcesController : Controller
    {
        public SourcesController()
        {
        }

        public IActionResult Get()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
