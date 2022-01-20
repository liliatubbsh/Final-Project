using API.core.Comn;
using API.core.Data;
using API.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.infra.Service
{
    public class STDservies : ISTDservies
    {
        private readonly STDRepoisitory _std;
        public STDservies(STDRepoisitory std) {

            _std = std;
        }
        public bool DeleteSTD(int id)
        {
            return _std.DeleteSTD(id);
        }

        public List<STD> GetallSTD()
        {
            return _std.GetallSTD();
        }

        public STD GetallSTDid(int id)
        {
            return _std.GetallSTDid(id);
        }

        public string InsertSTD(STD std)
        {
            return _std.InsertSTD(std);
        }

        public bool UpdateSTD(STD std)
        {
            return _std.UpdateSTD(std);
        }
    }
}
