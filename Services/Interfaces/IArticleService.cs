using LanguageTrainer.API.Models.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Services.Interfaces
{
    public interface IArticleService
    {
        public List<Article> GetArticles();
        public Article GetArticle(int id);
        public Article CreateArticle(Article article);
        public Article Update(int id);

    }
}
