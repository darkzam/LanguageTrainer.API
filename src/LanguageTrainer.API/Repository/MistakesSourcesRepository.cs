using LanguageTrainer.API.DBModels;
using LanguageTrainer.API.Models;
using LanguageTrainer.API.Repository.Interfaces;

namespace LanguageTrainer.API.Repository
{
    public class MistakesSourcesRepository : Repository<MistakesSources>, IMistakesSourcesRepository
    {
        public MistakesSourcesRepository(LanguageTrainerContext context) : base(context)
        {
        }

        public LanguageTrainerContext LanguageTrainerContext
        {
            get
            {
                return _dbContext as LanguageTrainerContext;
            }
        }
    }
}
