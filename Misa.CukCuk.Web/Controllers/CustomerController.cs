using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Misa.Core.Entities;
using Misa.Core.Interfaces;
using Misa.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Misa.CukCuk.Web.Controllers
{
    [Route("api/v1/[controller]s")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerRepository _customerRepository;
        ICustomerServices _customerServices;
        public CustomerController(ICustomerRepository customerRepository, ICustomerServices customerServices)
        {
            _customerRepository = customerRepository;
            _customerServices = customerServices;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var customers = _customerRepository.GetAll();
            if(customers.Count() > 0)
            {
                return Ok(customers);
            }
            return NoContent();
        }
        [HttpGet("{customerId}")]
        public IActionResult GetById(Guid customerId)
        {
            var customer = _customerRepository.GetByid(customerId);
            if(customer != null)
            {
                return Ok(customer);
            }
            return NoContent();
        }
        [HttpPost]
        public IActionResult Insert(Customer customer)
        {
            int rowAffects = _customerServices.Insert(customer);
            if(rowAffects > 0)
            {
                return Ok();
            }
            return NoContent();
        }
        [HttpPut]
        public IActionResult Update(Guid customerId, Customer customer)
        {
            int rowAffects = _customerServices.Update(customerId ,customer);
            if (rowAffects > 0)
            {
                return Ok();
            }
            return NoContent();
        }
    }
}
