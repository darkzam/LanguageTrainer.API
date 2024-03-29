﻿using System.ComponentModel.DataAnnotations;

namespace LanguageTrainer.API.Models
{
    public class Paragraph
    {
        [Key]
        public int Id { get; set; }
        public virtual Article Article { get; set; }
        public string Content { get; set; }
    }
}
