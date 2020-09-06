using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAPI.Models
{
    public  interface IDataRepository
    {
        IEnumerable<Customer> GetCustomers();
    }
}
