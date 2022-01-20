using API.core.Data;
using API.core.DTO;
using API.core.Repoisitory;
using API.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.infra.Service
{
   public class COURCEservies : ICOURCEservies
    {
        private readonly ICOURCErepoisitory _cours;
        public COURCEservies(ICOURCErepoisitory cours)
        {

            _cours = cours;
        }

        public List<courspriceDTO> coursprice(int price)
        {
            return _cours.coursprice(price);
        }

        public bool deleteallCOURS()
        {
            return _cours.deleteallCOURS();
        }

        public bool DeleteCOURS(int id)
        {
            return _cours.DeleteCOURS(id);
        }

        public List<COURS> GetallCOURS()
        {
            return _cours.GetallCOURS();
        }

        public COURS GetallCOURSID(int id)
        {
            return _cours.GetallCOURSID(id);
        }

        public List<COURCDTO> getfnamePRICE()
        {
            throw new NotImplementedException();
        }

        public COURS gettCOURSbydec(int id)
        {
            throw new NotImplementedException();
        }

        public List<COURS> gettCOURSbyname(string name){
            return _cours.gettCOURSbyname(name);
        }

        public COURS gettCOURSbynameandid(int id, string name)
        {
            return _cours.gettCOURSbynameandid(id, name);
        }

        public string InsertCOURS(COURS cours)
        {
            return _cours.InsertCOURS( cours);
        }

        public List<CoursPRICEAndBOOKNameDTO> namepricebook()
        {
            return _cours.namepricebook();
        }

        public bool UpdateCOURS(COURS cours)
        {
            return _cours.UpdateCOURS(cours);
        }

     
    }
}
