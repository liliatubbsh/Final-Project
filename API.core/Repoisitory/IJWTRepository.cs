using API.core.Data;
using API.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.core.Repoisitory
{
   public  interface IJWTRepository
    {
        public AuthDTO Auth(LOGIN_TABLE login);

    }
}
