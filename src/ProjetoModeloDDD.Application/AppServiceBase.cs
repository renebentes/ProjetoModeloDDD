using ProjetoModeloDDD.Application.Contracts;
using ProjetoModeloDDD.Domain.Contracts.Services;
using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity>
        where TEntity : class
    {
        private readonly IServiceBase<TEntity> _service;

        public AppServiceBase(IServiceBase<TEntity> service)
        {
            _service = service;
        }

        public void Add(TEntity entity)
        {
            _service.Add(entity);
        }

        public IEnumerable<TEntity> GetAll() => _service.GetAll();

        public TEntity GetById(int id) => _service.GetById(id);

        public void Remove(TEntity entity)
        {
            _service.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _service.Update(entity);
        }

        #region IDisposable Support

        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _service.Dispose();
                }

                disposedValue = true;
            }
        }

        ~AppServiceBase()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion IDisposable Support
    }
}