using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAPI2.Models
{
    public class BillAddress : Address
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
