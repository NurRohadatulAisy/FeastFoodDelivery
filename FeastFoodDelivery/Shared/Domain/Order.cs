using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeastFoodDelivery.Shared.Domain
{
	public class Order: BaseDomainModel
	{
        public int? CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

        public int? StaffId { get; set; }
        public virtual Staff? Staff { get; set; }

        public int? FoodItemID { get; set; }
        public virtual FoodItem? FoodItem { get; set; }




    }
}
