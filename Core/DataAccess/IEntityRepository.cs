using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T :class,IEntity,new()
    {
        //generic constraint 
        //class: Referans tip olabilir.
        //IEntity : IEntity olabilir ya da IEntity implemente eden bir nesne olabilir. 
        //new () : new lenebilir olmalıdır
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
     
    }
}
