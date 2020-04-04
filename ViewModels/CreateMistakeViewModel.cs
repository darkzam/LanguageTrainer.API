using LanguageTrainer.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.ViewModels
{
    public class CreateMistakeViewModel
    {
        public MistakeDto MistakeDto { get; set; }
        public List<SourceType> SourceTypes { get; set; }
        public List<Source> Sources { get; set; }
    }
}
