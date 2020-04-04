using System;
using System.ComponentModel.DataAnnotations;

namespace LanguageTrainer.API.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public SourceType SourceType { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime Year { get; set; }
    }
}
