using LanguageTrainer.API.DBModels;
using LanguageTrainer.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LanguageTrainerContext _context;

        private readonly Dictionary<string, IBaseRepo> repositories;
        public UnitOfWork(LanguageTrainerContext context)
        {
            _context = context;

            repositories.Add("Article", new ArticleRepository(context));
            repositories.Add("Mistake", new MistakeRepository(context));
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
