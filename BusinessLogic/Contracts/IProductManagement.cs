using Common.Entities;
using System.Collections.Generic;

namespace BusinessLogic
{
	public interface IProductManagement
	{
		IList<Product> GetAllProducts();
		void AddProduct(Product prod);
		Product Get(int id);
		void Update(Product prod);
		void Delete(int id);
	}
}