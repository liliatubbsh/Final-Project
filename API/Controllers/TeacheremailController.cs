using API.core.DTO;
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
    public class TeacheremailController : ControllerBase
    {
        private readonly Iteacher _teacher;

        public TeacheremailController(Iteacher teacher) {

            _teacher = teacher;
        }

        [HttpPost]
        public string emailcheck([FromBody]emailteasherDTO check)
        {

            return _teacher.emailcheck(check);
        }

    }
}
