using API.core.Comn;
using API.core.Data;
using API.core.Repoisitory;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace API.infra.Repoisitoer
{
    public class TEACHER_COURSErepoisitory : ITEACHER_COURSErepoisitory
    {


        private readonly Idbconction _context;

        public TEACHER_COURSErepoisitory(Idbconction context)
        {
            _context = context;
        }


        public bool Delete(int id)
        {

            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _context.comm.ExecuteAsync("TEACHER_COURSE_package.deleteTEACHER_COURSE", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<TEACHER_COURSE> Getall()
        {
            IEnumerable<TEACHER_COURSE> result = _context.comm.Query<TEACHER_COURSE>("TEACHER_COURSE_package.getallTEACHER_COURS", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public TEACHER_COURSE GetallID(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _context.comm.Query<TEACHER_COURSE>("TEACHER_COURSE_package.gettTEACHER_COURSEbyid", parameter, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        public string Insert(TEACHER_COURSE book)
        {
            return ";";
                 

        }

        public bool Update(TEACHER_COURSE book)
        {
            throw new NotImplementedException();
        }
    }
}
