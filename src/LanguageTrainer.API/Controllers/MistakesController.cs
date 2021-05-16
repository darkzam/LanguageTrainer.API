using AutoMapper;
using LanguageTrainer.API.Models;
using LanguageTrainer.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LanguageTrainer.API.Controllers
{
    [ApiController]
    [Route("api/mistakes")]
    public class MistakesController : ControllerBase
    {
        private readonly IMistakeService _mistakeService;
        private readonly IMapper _mapper;
        public MistakesController(IMistakeService mistakeService,
                                  IMapper mapper)
        {
            _mistakeService = mistakeService ?? throw new ArgumentNullException(nameof(mistakeService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet()]
        public ActionResult<List<MistakeDto>> GetAll()
        {
            var mistakes = _mistakeService.GetAll();

            return new OkObjectResult(_mapper.Map<List<MistakeDto>>(mistakes));
        }

        [HttpGet("{id}")]
        public ActionResult<MistakeDto> Get(int id)
        {
            var mistake = _mistakeService.Get(id);

            return new OkObjectResult(_mapper.Map<MistakeDto>(mistake));
        }

        [HttpPost()]
        public ActionResult<MistakeDto> Create([FromBody]MistakeDto mistakeDto)
        {
            if (mistakeDto == null)
                return new BadRequestResult();

            var mistake = _mapper.Map<Mistake>(mistakeDto);

            var newMistake = _mistakeService.Create(mistake);

            return new CreatedAtRouteResult("api/mistakes", newMistake);
        }

        [HttpPost("collection")]
        public ActionResult<MistakeDto> Create([FromBody]List<MistakeDto> mistakeDtos)
        {
            if (mistakeDtos == null)
                return new BadRequestResult();

            var mistakes = _mapper.Map<List<Mistake>>(mistakeDtos);

            var newMistakes = _mistakeService.Create(mistakes);

            return new CreatedAtRouteResult("api/mistakes", newMistakes);
        }

        [HttpDelete("{id}")]
        public ActionResult Remove(int id)
        {
            var mistake = _mistakeService.Get(id);

            if (mistake == null)
                return NotFound();

            _mistakeService.Remove(mistake);

            return Ok();
        }

        [HttpPut()]
        public ActionResult<MistakeDto> Update([FromBody]MistakeDto mistakeDto)
        {
            var mistake = _mistakeService.Get(mistakeDto.Id);

            if (mistake == null)
                return NotFound();

            _mapper.Map(mistakeDto, mistake);

            _mistakeService.Update(mistake);

            return NoContent();
        }
    }
}
