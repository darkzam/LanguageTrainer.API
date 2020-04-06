using AutoMapper;
using LanguageTrainer.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Profiles
{
    public class SourceTypeProfile : Profile
    {
        public SourceTypeProfile()
        {
            CreateMap<SourceType, SourceTypeDto>();

            CreateMap<SourceTypeDto, SourceType>();
        }
    }
}
