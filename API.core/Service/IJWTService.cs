using API.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.core.Service
{
    public interface IJWTService
    {
        public string Auth(LOGIN_TABLE login);
        public bool emaill();


    }
}
