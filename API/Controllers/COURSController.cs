using API.core.Data;
using API.core.DTO;
using API.core.Repoisitory;
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
    public class COURSController : ControllerBase
    {
        private readonly ICOURCErepoisitory _cours;
        public COURSController(ICOURCErepoisitory cours)
        {
            _cours = cours;
        }

        [HttpPost]
        public string Insertst([FromBody] COURS cours)
        {
            return _cours.InsertCOURS(cours);
        }


        [HttpPut]
        public bool UpdateCOURS([FromBody] COURS cours) {

            return _cours.UpdateCOURS(cours);
        }

        [HttpDelete("{id}")]
        public bool DeleteCOURS(int id) {
            return _cours.DeleteCOURS(id);
        }

        [HttpGet]
        [Route("GetallCOURS")]
        public List<COURS> GetallCOURS() {
            return _cours.GetallCOURS();
        }

        [HttpGet]
        [Route ("GetallCOURSID/{id}")]
        public COURS GetallCOURSID(int id)
        {

            return _cours.GetallCOURSID(id);
        }


        [HttpGet]
        [Route("gettCOURSbyname/{name}")]
        public List<COURS> gettCOURSbyname(string name) {
            return _cours.gettCOURSbyname(name);
        }

        [HttpGet]
        [Route("gettCOURSbynameandid/{id}/{name}")]
        public COURS gettCOURSbynameandid(int id ,string name) {

           return _cours.gettCOURSbynameandid(id,name);
        }

        [HttpGet]
        [Route("namebook")]
        public List<CoursPRICEAndBOOKNameDTO> namepricebook() {
            return _cours.namepricebook();
                
        }

        [HttpGet]
        [Route("coursprice/{price}")]
        public List<courspriceDTO> coursprice(int price) {

            return _cours.coursprice(price);
        }


        //[HttpGet]
        //[Route("gettCOURSbydec/{id}")]

        //public COURS gettCOURSbydec(int id) {

        //    return _cours.gettCOURSbydec(id);

        //}

        [HttpDelete]
        [Route("deleteallCOURS")]
        public bool deleteallCOURS() {

            return _cours.deleteallCOURS();
        }

    }
}
