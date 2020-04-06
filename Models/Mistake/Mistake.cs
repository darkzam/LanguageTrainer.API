using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LanguageTrainer.API.Models
{
    public class Mistake
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Error { get; set; }
        public string Answer { get; set; }
    }
}
