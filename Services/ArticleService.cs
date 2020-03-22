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
            _unitOfWork = unitOfWork ??
                throw new ArgumentNullException(nameof(unitOfWork));
        }

        public Article Create(Article article)
        {
            _unitOfWork.Articles.Add(article);
            _unitOfWork.Complete();

            return article;
        }

        public List<Article> GetAll()
        {
            return (List<Article>)_unitOfWork.Articles.GetAll();
        }

        public Article Get(int id)
        {
            return _unitOfWork.Articles.Get(id);
        }

        public Article Update(Article article)
        {
            _unitOfWork.Articles.Update(article);
            _unitOfWork.Complete();

            return _unitOfWork.Articles.Get(article.Id);
        }

        public int Remove(Article article)
        {
            _unitOfWork.Articles.Remove(article);
            return _unitOfWork.Complete();
        }
    }
}
