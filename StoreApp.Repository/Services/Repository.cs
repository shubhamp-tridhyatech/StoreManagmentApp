using Microsoft.EntityFrameworkCore;
using StoreApp.Data;
using StoreApp.Repository.Services.IRepository;
using System.Linq.Expressions;

namespace StoreApp.Repository.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly PointOfSaleContext _context;
        private DbSet<T> _dbSet;
        public Repository(PointOfSaleContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        //public T ExecuteStoredProcedure(string storedProcName, params object[] parameters)
        //{
        //    return _dbSet.FromSql(storedProcName, parameters).ToList();
        //}

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
