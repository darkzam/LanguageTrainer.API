using AutoMapper;
using LanguageTrainer.API.Controllers.SimpleCrud;
using LanguageTrainer.API.Models;
using LanguageTrainer.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Controllers
{
    public class SourceTypesController : SimpleCrudController<SourceType, SourceTypeDto>
    {
        public SourceTypesController(ISourceTypeService sourceTypeService,
                                     IMapper mapper)
                                    : base(sourceTypeService, mapper)
        {
        }
    }
}
