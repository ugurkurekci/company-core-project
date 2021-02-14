using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerRegistrationController : ControllerBase
    {
        ICustomerRegistrationService _customerRegistrationService;

        public CustomerRegistrationController(ICustomerRegistrationService customerRegistrationService)
        {
            _customerRegistrationService = customerRegistrationService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _customerRegistrationService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _customerRegistrationService.GetCustomerRegistrationById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(CustomerRegistration customerRegistration)
        {
            var result = _customerRegistrationService.Add(customerRegistration);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(CustomerRegistration customerRegistration)
        {
            var result = _customerRegistrationService.Update(customerRegistration);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(CustomerRegistration customerRegistration)
        {
            var result = _customerRegistrationService.Delete(customerRegistration);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
