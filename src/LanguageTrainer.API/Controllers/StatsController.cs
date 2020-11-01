using LanguageTrainer.API.Models;
using LanguageTrainer.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Controllers
{
    [ApiController]
    [Route("api/v1/stats")]
    public class StatsController : ControllerBase
    {
        private readonly IMistakeService _mistakeService;
        public StatsController(IMistakeService mistakeService)
        {
            _mistakeService = mistakeService;
        }

        [HttpGet("mistakes")]
        public ActionResult<MistakeStatsDto> GetMistakeStats()
        {
            //todo- check for existing user
                //-check for valid token

            var stats = _mistakeService.GetStats(0);

            return Ok(stats);
        }
    }
}
