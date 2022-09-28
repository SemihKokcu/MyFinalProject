using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // generic constraint
    //class : referans tip
    // IEntity: IEntity olabilir ya da onu implemente eden bir nesne olabilir
    // new() : newlenebilr olmalı bu durumda IEntiy olmaz ve işe yarar
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter); // tek veri gelicek filter zorunlu
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
