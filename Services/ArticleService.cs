using LanguageTrainer.API.Models.Article;
using LanguageTrainer.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Services
{
    public class ArticleService : IArticleService
    {
        private List<Article> _articles = new List<Article>();

        public Article CreateArticle(Article article)
        {
            _articles.Add(article);

            return article;
        }

        public List<Article> GetArticles()
        {
            return _articles;
        }

        public Article GetArticle(int id)
        {
            return _articles.Where(item => item.Id == id).ToList().FirstOrDefault();
        }

        public Article Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
