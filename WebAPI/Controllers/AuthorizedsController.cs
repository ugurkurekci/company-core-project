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
    public class AuthorizedsController : ControllerBase
    {
        IAuthorizedService _authorizedService;

        public AuthorizedsController(IAuthorizedService authorizedService)
        {
            _authorizedService = authorizedService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _authorizedService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _authorizedService.GetAuthorizedById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Authorized authorized)
        {
            var result = _authorizedService.Add(authorized);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(Authorized authorized)
        {
            var result = _authorizedService.Update(authorized);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Authorized authorized)
        {
            var result = _authorizedService.Delete(authorized);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}