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
        private readonly IArticleService _article;
        public ArticlesController(IArticleService article)
        {
            _article = article;
        }

        [HttpGet()]
        public ActionResult<List<Article>> GetArticles()
        {
            var articles = _article.GetArticles();

            return Ok(articles);
        }

        [HttpGet("{id}")]
        public ActionResult<Article> GetArticle(int id)
        {
            var article = _article.GetArticle(id);

            if (article == null)
                return new NotFoundResult();

            return Ok(article);
        }

        [HttpPost()]
        public ActionResult<Article> CreateArticle([FromBody]Article article)
        {
            if (article == null)
                return new BadRequestResult();

            var result = _article.CreateArticle(article);

            return new CreatedResult("api/articles", result);
        }
    }
}
