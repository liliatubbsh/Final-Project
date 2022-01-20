using API.core.DTO;
using API.core.Repoisitory;
using API.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.infra.Service
{
    public class Teacher : Iteacher
    {
        private readonly ITEACHERrepoisitory _tracher;
        public Teacher(ITEACHERrepoisitory tracher) {
            _tracher = tracher;
        }
        public string emailcheck(emailteasherDTO check)
        {
          return  _tracher.emailcheck(check);
        }
    }
}
