using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeastFoodDelivery.Shared.Domain
{
	public class Customer : BaseDomainModel
	{
		public string? CustName { get; set; }
        public string? Address { get; set; }
		public string? Email { get; set; }
		public int MobileNumber { get; set; }

	}
}
