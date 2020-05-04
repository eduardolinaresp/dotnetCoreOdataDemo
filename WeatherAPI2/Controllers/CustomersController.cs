using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeatherAPI2.Models;

namespace WeatherAPI2.Controllers
{
    [Route("odata/[controller]")]
    [ApiController]
    //[ApiExplorerSettings(IgnoreApi = false)]
    public class CustomersController : ODataController
    {

        private readonly ILogger<CustomersController> _logger;
        private IDataRepository _repository;

        public CustomersController(IDataRepository repository, ILogger<CustomersController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        [HttpGet]
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_repository.GetCustomers());
        }
        [HttpGet]
        [EnableQuery]
        public IActionResult Get(int key)
        {
            return Ok(_repository.GetCustomers().FirstOrDefault(c => c.Id == key));
        }
    }
}