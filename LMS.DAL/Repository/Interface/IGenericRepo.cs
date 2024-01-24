using LMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL.Repository.Interface
{
	public interface IGenericRepo<TEntity> where TEntity : class
	{
		void Add(TEntity entity);
		void Update(TEntity entity);
		void Delete(int id);

		Product Get(int id);
		IEnumerable<TEntity> GetAll();
	}
}
