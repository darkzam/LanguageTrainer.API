using AutoMapper;
using LanguageTrainer.API.Models.Article;
using LanguageTrainer.API.Models.Mistake;
using LanguageTrainer.API.Services.Interfaces;
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
        private readonly IMistakeService _mistakeService;
        private readonly IMapper _mapper;
        public MistakesController(IMistakeService mistakeService, IMapper mapper)
        {
            _mistakeService = mistakeService ?? throw new ArgumentNullException(nameof(mistakeService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            var mistakes = (List<Mistake>)_mistakeService.GetAll();
            return View("Index", mistakes);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create(Mistake mistake)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _mistakeService.Create(mistake);
            return RedirectToAction("GetAll", "Mistakes");
        }
    }
}
