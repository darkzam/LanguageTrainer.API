using LanguageTrainer.API.Models.Article;
using LanguageTrainer.API.Repository;
using LanguageTrainer.API.Repository.Interfaces;
using LanguageTrainer.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArticleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Article CreateArticle(Article article)
        {
            _unitOfWork.Articles.Add(article);
            _unitOfWork.Complete();

            return article;
        }

        public List<Article> GetArticles()
        {
            return (List<Article>)_unitOfWork.Articles.GetAll();
        }

        public Article GetArticle(int id)
        {
            return _unitOfWork.Articles.Get(id);
        }

        public Article Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
