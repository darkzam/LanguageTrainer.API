﻿using LanguageTrainer.API.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        IBaseRepo GetRepo(string entityName);
        int Complete();
    }
}
