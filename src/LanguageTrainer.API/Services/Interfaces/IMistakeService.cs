using LanguageTrainer.API.Models;
using LanguageTrainer.API.Models.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Services.Interfaces
{
    public interface IMistakeService : IBaseService<Mistake>
    {
        MistakeStatsDto GetStats(int userId);
    }
}
