using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Automation
{
    public interface IGeneric<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Get(Expression<Func<T, bool>> where = null);
        IEnumerable<T> GetByWhere(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includes = "");

        T GetEntity(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null,
            string includes = "");
        T GetEntityByName(Expression<Func<T, bool>> @where = null);
        T GetEntityById(int id);
        T Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool DeleteById(int id);
    }
}
