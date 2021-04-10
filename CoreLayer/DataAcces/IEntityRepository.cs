using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CoreLayer.Entities.Abstruct;

namespace CoreLayer.DataAcces
{
    public interface IEntityRepository<TEntityTip> where TEntityTip : class, IEntity, new()//in this way, it was only possible to work with entities
    {
        List<TEntityTip> GetAll(Expression<Func<TEntityTip, bool>> filter = null);
        TEntityTip Get(Expression<Func<TEntityTip, bool>> filter);
        void Add(TEntityTip entity);
        void Update(TEntityTip entity);
        void Delete(TEntityTip entity);
    }
}
