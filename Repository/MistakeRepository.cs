using LanguageTrainer.API.DBModels;
using LanguageTrainer.API.Models.Mistake;
using LanguageTrainer.API.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Repository
{
    public class MistakeRepository : Repository<Mistake>, IMistakeRepository
    {
        public MistakeRepository(LanguageTrainerContext context) : base(context)
        {
        }

        public LanguageTrainerContext LanguageTrainerContext
        {
            get { return _dbContext as LanguageTrainerContext; }
        }
    }
}
