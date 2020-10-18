using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Repository.Interfaces
{
    public interface IRepository<TEntity> : IBaseRepo where TEntity : class
    {
        public void Add(TEntity entity);

        public void Add(IEnumerable<TEntity> entities);

        public void Update(TEntity entity);

        public void Remove(TEntity entity);

        public TEntity Get(int id);

        public IEnumerable<TEntity> GetAll();

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}
