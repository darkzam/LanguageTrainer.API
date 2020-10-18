using LanguageTrainer.API.DBModels;
using LanguageTrainer.API.Models;
using LanguageTrainer.API.Repository.Interfaces;

namespace LanguageTrainer.API.Repository
{
    public class SourceRepository : Repository<Source>, ISourceRepository
    {
        public SourceRepository(LanguageTrainerContext context) : base(context)
        { }

        public LanguageTrainerContext LanguageTrainerContext
        {
            get { return _dbContext as LanguageTrainerContext; }
        }
    }
}
