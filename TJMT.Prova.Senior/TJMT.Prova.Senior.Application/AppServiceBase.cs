using System;
using System.Collections.Generic;
using TJMT.Prova.Senior.Application.Interface;
using TJMT.Prova.Senior.Domain.Interfaces.Services;

namespace TJMT.Prova.Senior.Application
{
    public class AppServiceBase<TEntity> : IDisposable, Interface.IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly Domain.Interfaces.Services.IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(Domain.Interfaces.Services.IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }
     
        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

    }
}
