using AutoMapper;
using LanguageTrainer.API.Models;
using LanguageTrainer.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Profiles
{
    public class MistakeProfile : Profile
    {
        public MistakeProfile()
        {
            CreateMap<Mistake, MistakeDto>();

            CreateMap<MistakeDto, Mistake>();
        }
    }
}
