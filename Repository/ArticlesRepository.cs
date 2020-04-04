using LanguageTrainer.API.DBModels;
using LanguageTrainer.API.Models;
using LanguageTrainer.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Repository
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        public ArticleRepository(LanguageTrainerContext context) : base(context)
        {
        }

        public IEnumerable<Article> GetArticlesByGenre(int genreEnum)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetLongestArticle()
        {
            throw new NotImplementedException();
        }

        public LanguageTrainerContext LanguageTrainerContext
        {
            get { return _dbContext as LanguageTrainerContext; }
        }

    }
}
