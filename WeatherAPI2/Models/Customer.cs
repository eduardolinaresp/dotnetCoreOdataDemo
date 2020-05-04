﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAPI2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<string> Emails { get; set; }
        public Address HomeAddress { get; set; }
        public IList<Address> FavoriteAddresses { get; set; }
        public Order PersonOrder { get; set; }
        public Order[] Orders { get; set; }
    }
}
