﻿using System.ComponentModel.DataAnnotations;

namespace LanguageTrainer.API.Models
{
    public class SourceType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
