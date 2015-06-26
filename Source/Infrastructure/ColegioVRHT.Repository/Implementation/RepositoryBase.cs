using System;
using ColegioVRHT.Repository.Interface;
using ColegioVRHT.Entities;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.Validation;

namespace ColegioVRHT.Repository.Implementation
{

    public class RepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
        where TEntity : EntityBase
        where TContext : DbContext
    {
        protected TContext Context;

        public RepositoryBase(TContext context)
        {
            Context = context;
        }

        public int Add(TEntity entity)
        {
            int Id = 0;
            try{

                    
                    Context.Set<TEntity>().Add(entity);
                    Id = Context.SaveChanges();
                }

            catch (DbEntityValidationException dbEx)
            {
		        foreach (var validationErrors in dbEx.EntityValidationErrors)
		        {
		            foreach (var validationError in validationErrors.ValidationErrors)
		            {
		                System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
		            }
		        }
            }
            return Id;
        }

        public TEntity GetById(int Id)
        {
            return Context.Set<TEntity>().Find(Id);
        }

        public IQueryable<TEntity> Get()
        {
            return Context.Set<TEntity>().AsQueryable();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList().AsEnumerable();
        }

        public void Update(TEntity entity)
        {
            Context.Set<TEntity>().Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
        }

    }
}
