using LanguageTrainer.API.Models;
using LanguageTrainer.API.Repository.Interfaces;
using LanguageTrainer.API.Services.Interfaces;

namespace LanguageTrainer.API.Services
{
    public class SourceTypeService : BaseService<SourceType>, ISourceTypeService
    {
        public SourceTypeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
