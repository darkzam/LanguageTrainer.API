using System;
using System.ComponentModel.DataAnnotations;

namespace LanguageTrainer.API.Models
{
    public class Audio
    {
        [Key]
        public int Id { get; set; }
        public Source Source { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Author { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
