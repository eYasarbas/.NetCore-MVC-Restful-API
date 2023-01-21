using Microsoft.EntityFrameworkCore;
using WebAPIApp.Data;

namespace WebAPIApp.Repository
{
    public class EfRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<T> _dbSet;
        public EfRepository(DatabaseContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public T Add(T entity)
        {
            var result = new T();
            _dbSet.Add(entity);
            _context.SaveChanges();
            result = entity;

            return result;
        }

        public T Delete(T entity)
        {
            var result = new T();
            _dbSet.Remove(entity);
            _context.SaveChanges();
            result = entity;
            return result;

        }

        public List<T> GetAll()
        {
            var result = new List<T>();
            var list = _dbSet.ToList();
            if (list != null)
            {
                result = list;
            }
            else
            {
                result = null;
            }
            return result;
        }

        public T GetById(int id)
        {
            var result = new T();
            result = _dbSet.Find(id);

            return result;
        }

        public T UpdateById(T entity, int id)
        {
            var result = new T();
            var model = _dbSet.Find(id);
            if (model == null)
            {
                return null;

            }

            var response = _context.Entry(model);
            response.State = EntityState.Modified;
            _context.SaveChanges();
            result = response.Entity;
            return result;

        }
    }
}