using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CoreLayer.Entities.Abstruct;
using Microsoft.EntityFrameworkCore;

namespace CoreLayer.DataAcces.EntitiyFramework
{
    public class EfEntitiyRepositoryBase<TEntityTip, TContextTip> : IEntityRepository<TEntityTip>
        where TEntityTip : class , IEntity , new()
        where TContextTip : DbContext , new()
    { 
        public void Add(TEntityTip entity)
        {
            using (TContextTip context = new TContextTip())
            {
                var addedToEntity = context.Entry(entity);
                addedToEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(TEntityTip entity)
        {
            using (TContextTip context = new TContextTip())
            {
                var deletedToEntity = context.Entry(entity);
                deletedToEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntityTip Get(Expression<Func<TEntityTip, bool>> filter)
        {
            using (TContextTip context = new TContextTip())
            {
                return context.Set<TEntityTip>().SingleOrDefault(filter);
            }
        }                                                                                                                                                                                  

        public List<TEntityTip> GetAll(Expression<Func<TEntityTip, bool>> filter = null)
        {
            using (TContextTip context = new TContextTip())
            {
                if (filter == null)
                {
                    return context.Set<TEntityTip>().ToList();
                }
                else
                {
                    return context.Set<TEntityTip>().Where(filter).ToList();
                }
            }
        }

        public void Update(TEntityTip entity)
        {
            using (TContextTip context = new TContextTip())
            {
                var updatedToEntity = context.Entry(entity);
                updatedToEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
