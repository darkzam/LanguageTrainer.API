using LanguageTrainer.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Repository.Interfaces
{
    public interface IArticleRepository : IRepository<Article>
    {
        IEnumerable<Article> GetLongestArticle();
        IEnumerable<Article> GetArticlesByGenre(int genreEnum);
    }
}
