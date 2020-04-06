using LanguageTrainer.API.Models;
using LanguageTrainer.API.Repository.Interfaces;
using LanguageTrainer.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Services
{
    public class SourceTypeService : BaseService<SourceType>, ISourceTypeService
    {
        public SourceTypeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
