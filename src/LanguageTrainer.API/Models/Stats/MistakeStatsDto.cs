using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Models
{
    public class MistakeStatsDto
    {
        public Guid Id { get; set; }
        public string Data { get; set; }
        public int Total { get; set; }
    }
}
