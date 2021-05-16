using AutoMapper;
using LanguageTrainer.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Profiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<Article, ArticleDto>().ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.PublicationDate.Year));

            CreateMap<ArticleDto, Article>().ForMember(dest => dest.CreateDate, opt => opt.MapFrom(src => DateTime.UtcNow))
                                            .ForMember(dest => dest.LastModifiedDate, opt => opt.MapFrom(src => DateTime.UtcNow))
                                            .ForMember(dest => dest.PublicationDate, opt => opt.MapFrom(src => new DateTime(src.Year, 01, 01)));
        }
    }
}
