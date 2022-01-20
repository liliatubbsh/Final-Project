using API.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.core.Repoisitory
{
   public  interface ISTD_COURSErepoisitor
    {

        public string Insert(STD_COURSE std_cours);
        public bool Update(STD_COURSE std_cours);
        public bool Delete(int id);
        public List<STD_COURSE> Getall();
        public STD_COURSE GetallID(int id);

    }
}
