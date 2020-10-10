using LanguageTrainer.API.Repository.Interfaces;
using LanguageTrainer.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace LanguageTrainer.API.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IRepository<TEntity> _repository;
        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = (IRepository<TEntity>)_unitOfWork.GetRepo(typeof(TEntity).Name);
        }

        public TEntity Create(TEntity entity)
        {
            _repository.Add(entity);
            _unitOfWork.Complete();

            return entity;
        }

        public IEnumerable<TEntity> Create(IEnumerable<TEntity> entities)
        {
            _repository.Add(entities);
            _unitOfWork.Complete();

            return entities;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity Get(int id)
        {
            return _repository.Get(id);
        }

        public int Update(TEntity entity)
        {
            _repository.Update(entity);
            return _unitOfWork.Complete();
        }

        public int Remove(TEntity entity)
        {
            _repository.Remove(entity);
            return _unitOfWork.Complete();
        }
    }
}
