using LanguageTrainer.API.DBModels;
using LanguageTrainer.API.Repository.Interfaces;
using System.Collections.Generic;

namespace LanguageTrainer.API.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LanguageTrainerContext _context;

        private readonly Dictionary<string, IBaseRepo> repositories = new Dictionary<string, IBaseRepo>();
        public UnitOfWork(LanguageTrainerContext context)
        {
            _context = context;

            repositories.Add("Mistake", new MistakeRepository(context));
            repositories.Add("Source", new SourceRepository(context));
            repositories.Add("SourceType", new SourceTypeRepository(context));
            repositories.Add("MistakesSources", new MistakesSourcesRepository(context));
        }

        public IBaseRepo GetRepo(string entityName)
        {
            return repositories[entityName];
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
