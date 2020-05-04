using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAPI2.Models
{
    public  interface IDataRepository
    {
        IEnumerable<Customer> GetCustomers();
    }
}
