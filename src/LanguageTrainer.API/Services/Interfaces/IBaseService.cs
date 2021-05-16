using LanguageTrainer.API.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Services.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity);
        IEnumerable<TEntity> Create(IEnumerable<TEntity> entities);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        int Update(TEntity entity);
        int Remove(TEntity entity);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}
