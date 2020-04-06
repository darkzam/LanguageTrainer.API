using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Models
{
    public class MistakesSourcesDto
    {
        public int Id { get; set; }
        public int MistakeId { get; set; }
        public int SourceId { get; set; }
    }
}
