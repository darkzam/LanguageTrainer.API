﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Models
{
    public class SourceDto
    {
        public int Id { get; set; }
        public int SourceTypeId { get; set; }
        public string Content { get; set; }
    }
}
