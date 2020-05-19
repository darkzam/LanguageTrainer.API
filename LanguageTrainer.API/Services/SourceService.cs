using LanguageTrainer.API.Models;
using LanguageTrainer.API.Repository.Interfaces;
using LanguageTrainer.API.Services.Interfaces;

namespace LanguageTrainer.API.Services
{
    public class SourceService : BaseService<Source>, ISourceService
    {
        public SourceService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
