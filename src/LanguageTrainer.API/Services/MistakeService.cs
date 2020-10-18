using LanguageTrainer.API.Models;
using LanguageTrainer.API.Models.Stats;
using LanguageTrainer.API.Repository.Interfaces;
using LanguageTrainer.API.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace LanguageTrainer.API.Services
{
    /// <summary>
    /// Mistake Service to handle all mistakes processing
    /// </summary>
    public class MistakeService : BaseService<Mistake>, IMistakeService
    {
        public MistakeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        /// <summary>
        /// Returns Mistake Stats
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public MistakeStatsDto GetStats(int userId)
        {
            //Optional - create a store proc and handle this query from DB side.

            //linq way:
            var count = _repository.GetAll().Count();

            var mistakes = _repository.Find(mistake => mistake.UserId == userId);

            var query = mistakes.GroupBy(mistake => mistake.Answer)
                                .Select(group => new { MissedWord = group.Key, Count = group.Count(), Porcentage = Math.Round((group.Count() / (float)count) * 100, 2) })
                                .OrderByDescending(group => group.Count)
                                .Take(20);

            return new MistakeStatsDto() { Id = Guid.NewGuid(), Data = JsonConvert.SerializeObject(query), Total = count };
        }
    }
}
