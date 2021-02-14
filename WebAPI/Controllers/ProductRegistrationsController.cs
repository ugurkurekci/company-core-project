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
    public class ProductRegistrationsController : ControllerBase
    {
        IProductRegistrationService _productRegistrationService;

        public ProductRegistrationsController(IProductRegistrationService productRegistrationService)
        {
            _productRegistrationService = productRegistrationService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productRegistrationService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productRegistrationService.GetProductRegistrationById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(ProductRegistration productRegistration)
        {
            var result = _productRegistrationService.Add(productRegistration);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(ProductRegistration productRegistration)
        {
            var result = _productRegistrationService.Update(productRegistration);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(ProductRegistration productRegistration)
        {
            var result = _productRegistrationService.Delete(productRegistration);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
