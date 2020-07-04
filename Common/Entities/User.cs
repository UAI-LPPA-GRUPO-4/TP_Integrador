using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
	public class User : IdentityBase
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public string City { get; set; }

		public string Country { get; set; }

		public DateTime SignupDate { get; set; }

		public int OrderCount { get; set; }
	}
}
