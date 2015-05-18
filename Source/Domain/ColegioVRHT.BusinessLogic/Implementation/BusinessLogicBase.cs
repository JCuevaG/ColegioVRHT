using ColegioVRHT.BusinessLogic.Interface;
using ColegioVRHT.Entities;
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
        private readonly IBusinessLogicBase<TEntity> _BusinessLogicBase;

        public BusinessLogicBase(IBusinessLogicBase<TEntity> _BusinessLogicBase)
        {
            this._BusinessLogicBase = _BusinessLogicBase;
        }

        public void Add(TEntity entity)
        {
           _BusinessLogicBase.Add(entity);
        }

        public TEntity GetById(int Id)
        {
            return _BusinessLogicBase.GetById(Id);
        }

        public IQueryable<TEntity> Get()
        {
            return _BusinessLogicBase.Get();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _BusinessLogicBase.GetAll();
        }

        public void Update(TEntity entity)
        {
            _BusinessLogicBase.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            _BusinessLogicBase.Remove(entity);
        }

    }
}
