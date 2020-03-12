using AutoMapper;
using LanguageTrainer.API.Models.Article;
using LanguageTrainer.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Controllers
{
    [ApiController]
    [Route("api/articles")]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;
        public ArticlesController(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService ??
                throw new ArgumentNullException(nameof(articleService));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet()]
        public ActionResult<List<Article>> GetArticles()
        {
            var articles = _articleService.GetAll();

            return Ok(_mapper.Map<List<ArticleDto>>(articles));
        }

        [HttpGet("{id}")]
        public ActionResult<Article> GetArticle(int id)
        {
            var article = _articleService.Get(id);

            if (article == null)
                return new NotFoundResult();

            return Ok(_mapper.Map<ArticleDto>(article));
        }

        [HttpPost()]
        public ActionResult<Article> CreateArticle([FromBody]ArticleDto articleDto)
        {
            if (articleDto == null)
                return new BadRequestResult();

            var result = _articleService.Create(_mapper.Map<Article>(articleDto));

            return new CreatedResult("api/articles", result);
        }
    }
}
