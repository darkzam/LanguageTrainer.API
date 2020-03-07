using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Models.Mistake
{
    public class Mistake
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ArticleId { get; set; }

        public string Error { get; set; }

        public string Correct { get; set; }
    }
}
