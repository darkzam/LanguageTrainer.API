using AutoMapper;
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
    [Route("api/mistakes/{mistakeId}/sources")]
    public class MistakesSourcesController : ControllerBase
    {
        private readonly IMistakesSourcesService _mistakesSourcesService;
        private readonly ISourceService _sourceService;
        private readonly IMapper _mapper;
        public MistakesSourcesController(IMistakesSourcesService mistakesSourcesService,
                                         ISourceService sourceService,
                                         IMapper mapper)
        {
            _mistakesSourcesService = mistakesSourcesService ?? throw new ArgumentNullException(nameof(mistakesSourcesService));
            _sourceService = sourceService;
            _mapper = mapper;
        }

        [HttpGet()]
        public ActionResult<List<Source>> GetAll(int mistakeId)
        {
            var sources = _mistakesSourcesService.GetMistakeSources(mistakeId);

            return Ok(_mapper.Map<List<SourceDto>>(sources));
        }
    }
}
