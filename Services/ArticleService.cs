using LanguageTrainer.API.Models;
using LanguageTrainer.API.Repository.Interfaces;
using LanguageTrainer.API.Services.Interfaces;

namespace LanguageTrainer.API.Services
{
    public class ArticleService : BaseService<Article>, IArticleService
    {
        public ArticleService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
