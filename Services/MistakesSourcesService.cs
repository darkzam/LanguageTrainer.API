using LanguageTrainer.API.Models;
using LanguageTrainer.API.Repository.Interfaces;
using LanguageTrainer.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Services
{
    public class MistakesSourcesService : BaseService<MistakesSources>, IMistakesSourcesService
    {
        private readonly ISourceRepository _sourceRepository;
        public MistakesSourcesService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _sourceRepository = (ISourceRepository)unitOfWork.GetRepo("Source");
        }

        public IEnumerable<Source> GetMistakeSources(Mistake mistake)
        {
            var mistakesSources = _repository.Find(r => r.MistakeId == mistake.Id);

            List<int> sourceIds = mistakesSources.Select(x => x.SourceId).ToList();

            var sources = _sourceRepository.Find(x => sourceIds.Contains(x.Id));

            return sources.ToList();
        }
    }
}
