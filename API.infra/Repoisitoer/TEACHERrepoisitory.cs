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
   public class TEACHERrepoisitory : ITEACHERrepoisitory

    {
        private readonly Idbconction _context;

        public TEACHERrepoisitory(Idbconction context)
        {
            _context = context;
        }


        public bool Delete(int id)
        {

            var p = new DynamicParameters();
            p.Add("idofTEACHER", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _context.comm.ExecuteAsync("TEACHE_package.deleteTEACHE", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public string emailcheck(emailteasherDTO check)
        {
            var p = new DynamicParameters();
            p.Add("@temail", check.EMAIL, dbType: DbType.String, direction: ParameterDirection.Input);
           IEnumerable<emailteasherDTO> result = _context.comm.Query<emailteasherDTO>("Teacher_Package.GetTeacherEmail", p, commandType: CommandType.StoredProcedure);

            if (result.SingleOrDefault()==null)
            {
                return "the email is not available";
            }
            else {

                return "the email is already exist";
            }
            

        }

        public List<TEACHER> Getall()
        {
            IEnumerable<TEACHER> result = _context.comm.Query<TEACHER>("BOOK_package.getallBOOK", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public TEACHER GetallID(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("idofTEACHER", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _context.comm.Query<TEACHER>("BOOK_package.gettBOOKbyid", parameter, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        public string Insert(TEACHER teacher)
        {
            throw new NotImplementedException();
        }

        public bool Update(TEACHER teacher)
        {
            throw new NotImplementedException();
        }
    }
}
