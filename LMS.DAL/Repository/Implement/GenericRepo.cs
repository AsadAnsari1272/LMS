using LMS.DAL.DEL;
using LMS.DAL.Repository.Interface;
using LMS.Models;
using System.Linq.Expressions;

namespace LMS.DAL.Repository.Implement
{
	public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : class
	{
		private readonly ApplicationDbConnection _context;
        public GenericRepo(ApplicationDbConnection option)
        {
            _context = option;
        }
        public void Add(TEntity entity)
		{
			_context.Set<TEntity>().Add(entity);
		}

		public void Delete(int id)
		{
			var IdFromDb = _context.Set<TEntity>().Find(id);
			_context.Remove(IdFromDb);
		}

		public TEntity Get(int id)
		{
			return _context.Set<TEntity>().Find(id);
		}

		public TEntity Get(Expression<Func<TEntity, bool>> filer)
		{
		  return	_context.Set<TEntity>().SingleOrDefault(filer);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _context.Set<TEntity>();
		}
	}
}
