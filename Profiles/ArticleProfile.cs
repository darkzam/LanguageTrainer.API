using AutoMapper;
using LanguageTrainer.API.Models;
using System;

namespace LanguageTrainer.API.Profiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<Article, ArticleDto>()
                .ForMember(
                dest => dest.Year,
                opt => opt.MapFrom(src =>
                     src.Year.Year
                ));

            CreateMap<ArticleDto, Article>()
               .ForMember(
               dest => dest.Year,
               opt => opt.MapFrom(src =>
                    new DateTime(src.Year, 01, 01)
               ));
        }
    }
}
