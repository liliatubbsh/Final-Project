using API.core.Data;
using API.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.core.Service
{
   public interface ICOURCEservies
    {
        public string InsertCOURS(COURS cours);
        public bool UpdateCOURS(COURS cours);
        public bool DeleteCOURS(int id);
        public List<COURS> GetallCOURS();
        public COURS GetallCOURSID(int id);



        public List<COURS> gettCOURSbyname(string name);

        public COURS gettCOURSbynameandid(int id ,string name);
        public COURS gettCOURSbydec(int id);
        public bool deleteallCOURS();
        public List<COURCDTO> getfnamePRICE();
        public List<CoursPRICEAndBOOKNameDTO> namepricebook();
        public List<courspriceDTO> coursprice(int price);




    }
}
