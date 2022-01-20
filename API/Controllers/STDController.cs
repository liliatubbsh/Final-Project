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
    public class STDController : ControllerBase
    {
        private readonly ISTDservies _std;
        public STDController(ISTDservies std) {
            _std = std;

        }

        [HttpPost]
        public string Insertst([FromBody]STD std) {

            return _std.InsertSTD(std);
        }


    }
}
