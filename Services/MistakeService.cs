using LanguageTrainer.API.Models.Mistake;
using LanguageTrainer.API.Repository.Interfaces;
using LanguageTrainer.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Services
{
    public class MistakeService: BaseService<Mistake>, IMistakeService
    {
        public MistakeService(IUnitOfWork unitOfWork): base(unitOfWork)
        {
        }
    }
}
