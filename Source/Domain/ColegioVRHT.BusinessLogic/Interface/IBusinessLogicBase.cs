using ColegioVRHT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioVRHT.BusinessLogic.Interface
{
    public interface IBusinessLogicBase<TEntity>
        where TEntity : EntityBase
    {

        void Add(TEntity entity);

        TEntity GetById(int Id);

        IQueryable<TEntity> Get();

        IEnumerable<TEntity> GetAll();

        void Update(TEntity entity);

        void Remove(TEntity entity);
                
    }
}
