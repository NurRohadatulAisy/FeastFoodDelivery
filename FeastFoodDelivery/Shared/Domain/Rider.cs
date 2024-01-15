using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeastFoodDelivery.Shared.Domain
{
	public class Rider: BaseDomainModel
	{
        public string? LicensePlateNumber { get; set; }

        public int? StaffId { get; set; }
        public virtual Staff? staff { get; set; }
    }
}
