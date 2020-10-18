using LanguageTrainer.API.DBModels;
using LanguageTrainer.API.Models;
using LanguageTrainer.API.Repository.Interfaces;

namespace LanguageTrainer.API.Repository
{
    public class SourceTypeRepository : Repository<SourceType>, ISourceTypeRepository
    {
        public SourceTypeRepository(LanguageTrainerContext context) : base(context)
        {
        }

        public LanguageTrainerContext LanguageTrainerContext
        {
            get { return _dbContext as LanguageTrainerContext; }
        }
    }
}
