using AutoMapper;
using LanguageTrainer.API.Models;
using LanguageTrainer.API.Services;
using LanguageTrainer.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LanguageTrainer.API.Controllers
{
    [ApiController]
    [Route("api/articles")]
    public class ArticleController : ControllerBase
    {
        private readonly ISourceService _sourceService;
        private readonly ISourceTypeService _sourceTypeService;
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;

        public ArticleController(ISourceService sourceService,
                                 IArticleService articleService,
                                 ISourceTypeService sourceTypeService,
                                 IMapper mapper)
        {
            _sourceService = sourceService ?? throw new ArgumentNullException(nameof(sourceService));
            _sourceTypeService = sourceTypeService ?? throw new ArgumentNullException(nameof(sourceTypeService));
            _articleService = articleService ?? throw new ArgumentNullException(nameof(articleService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet()]
        public ActionResult<List<ArticleDto>> GetAll()
        {
            var articles = _articleService.GetAll();

            return new ObjectResult(_mapper.Map<List<ArticleDto>>(articles));
        }

        [HttpGet("{id}")]
        public ActionResult<ArticleDto> Get(int id)
        {
            var article = _articleService.Get(id);

            if (article == null)
                return NotFound();

            return Ok(_mapper.Map<ArticleDto>(article));
        }

        [HttpPost()]
        public ActionResult<ArticleDto> Create([FromBody]ArticleDto ArticleDto)
        {
            if (ArticleDto == null)
                return new BadRequestResult();

            var sourceType = _sourceTypeService.Find(sourceType => sourceType.Name == "Articles");

            if (sourceType.Count() == 0)
                return NotFound("SourceType: Articles");

            var source = new Source() { SourceType = sourceType.First(), Content = $"Article Source: {ArticleDto.Title}" };

            source = _sourceService.Create(source);

            var article = _mapper.Map<Article>(ArticleDto);

            article.Source = source;

            var newArticle = _articleService.Create(article);

            return Ok(_mapper.Map<ArticleDto>(newArticle));
        }

        [HttpPut()]
        public ActionResult<ArticleDto> Update([FromBody]ArticleDto ArticleDto)
        {
            if (ArticleDto == null)
                return new BadRequestResult();

            var article = _articleService.Get(ArticleDto.Id);

            if (article == null)
                return NotFound();

            _mapper.Map(ArticleDto, article);

            _articleService.Update(article);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Remove(int id)
        {
            var article = _articleService.Get(id);

            if (article == null)
                return NotFound();

            _articleService.Remove(article);

            return Ok();
        }
    }
}
