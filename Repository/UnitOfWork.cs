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
        public IArticleRepository Articles { get; private set; }

        public UnitOfWork(LanguageTrainerContext context)
        {
            _context = context;
         //   _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            Articles = new ArticleRepository(context);
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
