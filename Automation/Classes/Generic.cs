using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Baran.Ferroalloy.Automation
{
    public abstract class Generic<T> : IGeneric<T> where T : class
    {
        protected DbContext _conntext;
        protected DbSet<T> _dbSet;
        public Generic(DbContext db)
        {
            _conntext = db;
            _dbSet = db.Set<T>(); //db.Set<T_User>() or db.T_User
        }

        public T GetEntity(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includes = "")
        {

            T query1 = null;
            IQueryable<T> query = _dbSet;

            if (where != null)
            {
                query1 = query.FirstOrDefault(where);
            }

            if (orderby != null)
            {
                query = orderby(query);
            }

            if (includes != "")
            {
                foreach (string include in includes.Split(','))
                {
                    query = query.Include(include);
                }
            }

            return query1;

        }

        public virtual IEnumerable<T> GetByWhere(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includes = "")
        {
            IQueryable<T> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }

            if (orderby != null)
            {
                query = orderby(query);
            }

            if (includes != "")
            {
                foreach (string include in includes.Split(','))
                {
                    query = query.Include(include);
                }
            }

            return query.ToList();
        }

        public virtual bool Delete(T entity)
        {
            try
            {
                _conntext.Entry(entity).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual bool DeleteById(int id)
        {
            try
            {
                var entity = GetEntityById(id);
                Delete(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> @where = null)
        {
            IQueryable<T> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }

            return query.ToList();
        }

        public T GetEntityByName(Expression<Func<T, bool>> firstOrDefault)
        {
            return _dbSet.FirstOrDefault(firstOrDefault);
        }


        public virtual T GetEntityById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual T Insert(T entity)
        {
            try
            {
                
                return _dbSet.Add(entity); 
            }
            catch
            {
                return null;
            }
        }


        public virtual bool Update(T entity)
        {
            try
            {
                _conntext.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
