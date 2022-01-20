using API.core.Comn;
using API.core.Data;
using API.core.DTO;
using API.core.Repoisitory;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace API.infra.Repoisitoer
{
   public class JWTRepository: IJWTRepository
    {
        private readonly Idbconction _context;

        public JWTRepository(Idbconction context)
        {
            _context = context;
        }

        public AuthDTO Auth(LOGIN_TABLE login) {

            
            var p = new DynamicParameters();
            p.Add("@UNAME", login.USERNAME, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PASS", login.PASSWORD, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<AuthDTO> result = _context.comm.Query<AuthDTO>("API_lOGIN_PAKAGE.LOGIN", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault(); ;
              }



    }
}
