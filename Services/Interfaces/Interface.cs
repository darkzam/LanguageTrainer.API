using LanguageTrainer.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Services.Interfaces
{
    public interface IMistakesSourcesService: IBaseService<MistakesSources>
    {
        IEnumerable<Source> GetMistakeSources(Mistake mistake);
    }
}
