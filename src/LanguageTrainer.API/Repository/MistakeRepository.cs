using LanguageTrainer.API.DBModels;
using LanguageTrainer.API.Models;
using LanguageTrainer.API.Repository.Interfaces;

namespace LanguageTrainer.API.Repository
{
    public class MistakeRepository : Repository<Mistake>, IMistakeRepository
    {
        public MistakeRepository(LanguageTrainerContext context) : base(context)
        { }

        public LanguageTrainerContext LanguageTrainerContext
        {
            get { return _dbContext as LanguageTrainerContext; }
        }
    }
}
