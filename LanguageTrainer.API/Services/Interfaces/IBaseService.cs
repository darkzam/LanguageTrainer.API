using LanguageTrainer.API.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Services.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        int Update(TEntity entity);
        int Remove(TEntity entity);
    }
}
