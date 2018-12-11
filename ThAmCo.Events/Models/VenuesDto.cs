using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Events.Models
{
    /* [{
         * "code":"CRKHL",
         * "name":"Crackling Hall",
         * "description":"Once the residence of Lord and Lady Crackling, this lavish dwelling remains a prime example of 18th century fine living.",
         * "capacity":150,
         * "date":"2018-11-20T00:00:00",
         * "costPerHour":97.65
    }] */

    public class VenuesDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public DateTime Date { get; set; }
        public double CostPerhour { get; set; }

    }
}
