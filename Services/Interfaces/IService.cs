using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Services.Interfaces
{
    public interface IService<TEntity> where TEntity : class
    {
        public TEntity Create(TEntity entity);

        public TEntity Get(int id);

        public List<TEntity> GetAll();

        public TEntity Update(TEntity entity);

        public int Remove(TEntity entity);
    }
}
