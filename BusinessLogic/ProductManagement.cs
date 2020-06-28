using Common.Entities;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Implementations;

namespace BusinessLogic
{
	public class ProductManagement : IProductManagement
	{
		BaseDataService<Product> db;

		public ProductManagement()
		{
			db = new BaseDataService<Product>();
		}

		public IList<Product> GetAllProducts()
		{
			return db.Get();
		}

		public Product Get(int id)
		{
			return db.Get(x => x.Id == id).FirstOrDefault();
		}

		public void AddProduct(Product prod)
		{
			db.Create(prod);
		}

		public void Update(Product prod)
		{
			db.Update(prod);
		}

		public void Delete(int id)
		{
			db.Delete(id);
		}
	}
}
