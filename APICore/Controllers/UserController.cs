using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Model;
using API.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICore.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetAllUsers();
            if (result.Any())
            {
                return Ok(result);
            }
            return StatusCode(StatusCodes.Status204NoContent);

        }
        [HttpGet("{userId}")]
        public async Task<IActionResult> Get(int userId)
        {
            var result = await _service.GetUser(userId);
            if (result!=null)
            {
                return Ok(result);
            }
            return StatusCode(StatusCodes.Status204NoContent);

        }
        [HttpPost]
        public async Task<IActionResult> Post(Users user)
        {
            var result = await _service.AddUser(user);
            if (result!= null)
            {
                return Ok(result);
            }
            return StatusCode(StatusCodes.Status204NoContent);

        }
        [HttpPut]
        public async Task<IActionResult> Put(Users user)
        {
            var result = await _service.UpdateUser(user);
            if (result != null)
            {
                return Ok(result);
            }
            return StatusCode(StatusCodes.Status204NoContent);

        }
        [HttpDelete]
        public async Task<IActionResult> Delete(Users user)
        {
            var result = await _service.RemoveUser(user);
            if (result)
            {
                return Ok(result);
            }
            return StatusCode(StatusCodes.Status204NoContent);

        }
    }
}