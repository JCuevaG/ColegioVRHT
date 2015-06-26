using ColegioVRHT.BusinessLogic.Interface;
using ColegioVRHT.Entities;
using ColegioVRHT.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioVRHT.BusinessLogic.Implementation
{
    public class BusinessLogicBase<TEntity> : IBusinessLogicBase<TEntity> 
        where TEntity : EntityBase
    {
        private readonly IRepositoryBase<TEntity> _IRepositoryBase;

        
        public BusinessLogicBase(IRepositoryBase<TEntity> _IRepositoryBase)
        {
            this._IRepositoryBase = _IRepositoryBase;
        }

        public int Add(TEntity entity)
        {
            int Id = 0;
            
            Id  = _IRepositoryBase.Add(entity);
            return Id;
        }

        public TEntity GetById(int Id)
        {
            return _IRepositoryBase.GetById(Id);
        }

        public IQueryable<TEntity> Get()
        {
            return _IRepositoryBase.Get();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _IRepositoryBase.GetAll();
        }

        public void Update(TEntity entity)
        {
            _IRepositoryBase.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            _IRepositoryBase.Remove(entity);
        }

    }
}
