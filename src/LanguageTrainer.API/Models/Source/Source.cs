using System.ComponentModel.DataAnnotations;

namespace LanguageTrainer.API.Models
{
    public class Source
    {
        [Key]
        public int Id { get; set; }
        public virtual SourceType SourceType { get; set; }
        public string Content { get; set; }
    }
}
