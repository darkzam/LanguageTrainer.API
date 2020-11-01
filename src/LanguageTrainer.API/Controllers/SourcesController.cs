using AutoMapper;
using LanguageTrainer.API.Models;
using LanguageTrainer.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LanguageTrainer.API.Controllers
{
    [ApiController]
    [Route("api/sources")]
    public class SourcesController : ControllerBase
    {
        private readonly ISourceService _sourceService;
        private readonly ISourceTypeService _sourceTypeService;
        private readonly IMapper _mapper;
        public SourcesController(ISourceService sourceService,
                                ISourceTypeService sourceTypeService,
                                IMapper mapper)
        {
            _sourceService = sourceService ?? throw new ArgumentNullException(nameof(sourceService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _sourceTypeService = sourceTypeService ?? throw new ArgumentNullException(nameof(sourceTypeService));
        }

        [HttpGet()]
        public ActionResult<List<SourceDto>> GetAll()
        {
            var sources = _sourceService.GetAll();

            return new ObjectResult(_mapper.Map<List<SourceDto>>(sources));
        }

        [HttpGet("{id}")]
        public ActionResult<SourceDto> Get(int id)
        {
            var source = _sourceService.Get(id);

            if (source == null)
                return NotFound();

            return Ok(_mapper.Map<SourceDto>(source));
        }

        [HttpPost()]
        public ActionResult<SourceDto> Create([FromBody]SourceDto sourceDto)
        {
            if (sourceDto == null)
                new BadRequestResult();

            var sourceType = _sourceTypeService.Get(sourceDto.SourceTypeId);

            if (sourceType == null)
                return NotFound();

            var source = _mapper.Map<Source>(sourceDto);

            source.SourceType = sourceType;

            var newSource = _sourceService.Create(source);

            return Ok(_mapper.Map<SourceDto>(newSource));
        }

        [HttpPut()]
        public ActionResult<SourceDto> Update([FromBody]SourceDto sourceDto)
        {
            if (sourceDto == null)
                return new BadRequestResult();

            var source = _sourceService.Get(sourceDto.Id);

            if (source == null)
                return NotFound();

            var sourceType = _sourceTypeService.Get(sourceDto.SourceTypeId);

            if (sourceType == null)
                return NotFound();

            _mapper.Map(sourceDto, source);

            source.SourceType = sourceType;

            _sourceService.Update(source);

            return NoContent();
        }
    }
}
