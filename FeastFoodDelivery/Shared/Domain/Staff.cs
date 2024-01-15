﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeastFoodDelivery.Shared.Domain
{
	public class Staff : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? NRIC { get; set; }
        public string? ContactNumber { get; set; }
        public string? Address { get; set; }

    }
}
