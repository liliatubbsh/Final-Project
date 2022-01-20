using API.core.Data;
using API.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.core.Repoisitory
{
    public interface ITEACHERrepoisitory
    {

        public string Insert(TEACHER teacher);
        public bool Update(TEACHER teacher);
        public bool Delete(int id);
        public List<TEACHER> Getall();
        public TEACHER GetallID(int id);
      


        public string emailcheck(emailteasherDTO check);

    }
}
