﻿using LanguageTrainer.API.Models;
using LanguageTrainer.API.Repository.Interfaces;
using LanguageTrainer.API.Services.Interfaces;

namespace LanguageTrainer.API.Services
{
    public class MistakeService: BaseService<Mistake>, IMistakeService
    {
        public MistakeService(IUnitOfWork unitOfWork): base(unitOfWork)
        {
        }
    }
}
