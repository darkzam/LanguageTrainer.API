﻿using LanguageTrainer.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LanguageTrainer.API.DBModels
{
    public class LanguageTrainerContext : DbContext
    {
        public LanguageTrainerContext(DbContextOptions<LanguageTrainerContext> options)
                                    : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Mistake> Mistakes { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<SourceType> SourceTypes { get; set; }
    }
}
