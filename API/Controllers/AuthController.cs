using API.core.Data;
using API.core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IJWTService _jwt;
        public AuthController(IJWTService jwt)
        {
            _jwt = jwt;
        }
        [HttpPost]
        [Route("authuser")]
        public IActionResult auth([FromBody] LOGIN_TABLE login)
        {
            var item = _jwt.Auth(login);
            if (item == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(item);
            }
        }



        [HttpGet]
       public bool sendemail()
        {
           return _jwt.emaill();
        }

    }
}