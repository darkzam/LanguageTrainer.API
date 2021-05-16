using System.ComponentModel.DataAnnotations;

namespace LanguageTrainer.API.Models
{
    public class Media
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }
    }
}