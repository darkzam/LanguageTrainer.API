using LanguageTrainer.API.Models;

namespace LanguageTrainer.API.Services.Interfaces
{
    public interface IMistakeService : IBaseService<Mistake>
    {
        MistakeStatsDto GetStats(int userId);
    }
}
