using Common.Entities;
using System.Collections.Generic;

namespace BusinessLogic
{
	public interface IUserManagement
	{
		IList<User> GetAll();
		void Add(User user);
		User Get(string email);
		void Update(User user);
		void Delete(int id);
	}
}