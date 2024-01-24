using LMS.Models;

namespace LMS.DAL.Repository.Interface
{
	public interface IProductRepo : IGenericRepo<Product>
	{
		void GetPriceDetail();
	}
}
