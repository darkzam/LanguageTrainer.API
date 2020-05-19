using AutoMapper;
using LanguageTrainer.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Profiles
{
    public class MistakesSourcesProfile : Profile
    {
        public MistakesSourcesProfile()
        {
            CreateMap<MistakesSources, MistakesSourcesDto>();

            CreateMap<MistakesSourcesDto, MistakesSources>();
        }
    }
}
