using LanguageTrainer.API.Models.Article;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.DBModels
{
    public class LanguageTrainerContext : DbContext
    {
        public LanguageTrainerContext(DbContextOptions<LanguageTrainerContext> options) 
                                    : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
    }
}
