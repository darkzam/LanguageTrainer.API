using AutoMapper;
using LanguageTrainer.API.Models;
using LanguageTrainer.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LanguageTrainer.API.Controllers
{
    [ApiController]
    [Route("api/sourceTypes")]
    public class SourceTypesController : ControllerBase
    {
        private readonly ISourceTypeService _sourceTypeService;
        private readonly IMapper _mapper;
        public SourceTypesController(ISourceTypeService sourceTypeService,
                                     IMapper mapper)
        {
            _sourceTypeService = sourceTypeService ?? throw new ArgumentNullException(nameof(sourceTypeService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet()]
        public ActionResult<List<SourceTypeDto>> GetAll()
        {
            var sourceTypes = _sourceTypeService.GetAll();

            return Ok(_mapper.Map<List<SourceTypeDto>>(sourceTypes));
        }

        [HttpGet("{id}")]
        public ActionResult<SourceTypeDto> Get(int id)
        {
            var sourceType = _sourceTypeService.Get(id);

            if (sourceType == null)
                return new BadRequestResult();

            return Ok(_mapper.Map<SourceTypeDto>(sourceType));
        }

        [HttpPost()]
        public ActionResult<SourceTypeDto> Create(SourceTypeDto sourceTypeDto)
        {
            if (sourceTypeDto == null)
                return new BadRequestResult();

            var sourceType = _mapper.Map<SourceType>(sourceTypeDto);

            var newSourceType = _sourceTypeService.Create(sourceType);

            return Ok(_mapper.Map<SourceTypeDto>(newSourceType));
        }

        [HttpDelete("{id}")]
        public ActionResult Remove(int id)
        {
            var sourceType = _sourceTypeService.Get(id);

            if (sourceType == null)
                return NotFound();

            _sourceTypeService.Remove(sourceType);

            return Ok();
        }

        [HttpPut()]
        public ActionResult Update([FromBody]SourceTypeDto sourceTypeDto)
        {
            if (sourceTypeDto == null)
                return new BadRequestResult();

            var source = _sourceTypeService.Get(sourceTypeDto.Id);

            if (source == null)
                return NotFound();

            _mapper.Map(sourceTypeDto, source);

            _sourceTypeService.Update(source);

            return NoContent();
        }
    }
}
