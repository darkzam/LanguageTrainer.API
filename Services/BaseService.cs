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
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<TEntity> _repository;
        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = (IRepository<TEntity>)_unitOfWork.GetRepo(nameof(TEntity));
        }

        public TEntity Create(TEntity article)
        {
            _repository.Add(article);
            _unitOfWork.Complete();

            return article;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return (List<TEntity>)_repository.GetAll();
        }

        public TEntity Get(int id)
        {
            return _repository.Get(id);
        }

        public int Update(TEntity article)
        {
            _repository.Update(article);
            return _unitOfWork.Complete();
        }

        public int Remove(TEntity article)
        {
            _repository.Remove(article);
            return _unitOfWork.Complete();
        }
    }
}
