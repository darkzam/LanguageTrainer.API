using AutoMapper;
using LanguageTrainer.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Profiles
{
    public class SourceProfile : Profile
    {
        public SourceProfile()
        {
            CreateMap<Source, SourceDto>().ForMember(dest => dest.SourceTypeId,
                                                     opt => opt.MapFrom(src => src.SourceType.Id));

            CreateMap<SourceDto, Source>();
        }
    }
}
