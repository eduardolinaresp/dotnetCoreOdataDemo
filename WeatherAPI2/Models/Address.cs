using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAPI2.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public ZipCode ZipCode { get; set; }
    }
}
