using AutoMapper;
using LanguageTrainer.API.Models;
using LanguageTrainer.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LanguageTrainer.API.Controllers
{
    [ApiController]
    [Route("api/mistakes/{mistakeId}/sources")]
    public class MistakesSourcesController : ControllerBase
    {
        private readonly IMistakesSourcesService _mistakesSourcesService;
        private readonly IMistakeService _mistakeService;
        private readonly ISourceService _sourceService;
        private readonly IMapper _mapper;
        public MistakesSourcesController(IMistakesSourcesService mistakesSourcesService,
                                         IMistakeService mistakeService,
                                         ISourceService sourceService,
                                         IMapper mapper)
        {
            _mistakesSourcesService = mistakesSourcesService ?? throw new ArgumentNullException(nameof(mistakesSourcesService));
            _mistakeService = mistakeService ?? throw new ArgumentNullException(nameof(mistakeService));
            _sourceService = sourceService ?? throw new ArgumentNullException(nameof(sourceService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet()]
        public ActionResult<List<Source>> GetAll(int mistakeId)
        {
            var mistake = _mistakeService.Get(mistakeId);

            if (mistake == null)
                return NotFound();

            var sources = _mistakesSourcesService.GetMistakeSources(mistake);

            return Ok(_mapper.Map<List<SourceDto>>(sources));
        }

        [HttpPost()]
        public ActionResult Create(int mistakeId, [FromBody]MistakesSources mistakesSources)
        {
            if (mistakesSources == null)
                return new BadRequestResult();

            //checks for mistake
            var mistake = _mistakeService.Get(mistakeId);

            if (mistake == null)
                return NotFound($"Mistake Id: {mistakeId} not found.");

            //checks for source
            var source = _sourceService.Get(mistakesSources.SourceId);

            if (source == null)
                return NotFound($"Source Id : {mistakesSources.SourceId} not found.");

            mistakesSources.MistakeId = mistakeId;

            var newEntity = _mistakesSourcesService.Create(mistakesSources);

            return new CreatedAtRouteResult($"api/mistakes/{mistakeId}/sources", newEntity);
        }
    }
}
