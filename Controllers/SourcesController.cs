using AutoMapper;
using LanguageTrainer.API.Controllers.SimpleCrud;
using LanguageTrainer.API.Models;
using LanguageTrainer.API.Services.Interfaces;

namespace LanguageTrainer.API.Controllers
{
    public class SourcesController : SimpleCrudController<Source, SourceDto>
    {
        public SourcesController(ISourceService sourceService,
                                IMapper mapper) : base(sourceService, mapper)
        {
        }
    }
}
