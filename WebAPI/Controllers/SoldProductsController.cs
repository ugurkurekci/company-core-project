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
    public class SoldProductsController : ControllerBase
    {
        ISoldProductService _soldProductService;

        public SoldProductsController(ISoldProductService soldProductService)
        {
            _soldProductService = soldProductService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _soldProductService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _soldProductService.GetSoldProductById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(SoldProduct soldProduct)
        {
            var result = _soldProductService.Add(soldProduct);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(SoldProduct soldProduct)
        {
            var result = _soldProductService.Update(soldProduct);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(SoldProduct soldProduct)
        {
            var result = _soldProductService.Delete(soldProduct);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
