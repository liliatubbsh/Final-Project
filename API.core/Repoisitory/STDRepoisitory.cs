using API.core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;


namespace API.core.Comn
{
    public interface STDRepoisitory
    {
        public string InsertSTD(STD std);
        public bool UpdateSTD(STD std);

        public bool DeleteSTD(int id);

        public List<STD> GetallSTD();

        public STD GetallSTDid(int id);



    }
}
