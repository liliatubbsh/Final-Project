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
   public class STD_COURSErepoisitor : ISTD_COURSErepoisitor
    {

        private readonly Idbconction _context;

        public STD_COURSErepoisitor(Idbconction context)
        {
            _context = context;
        }

        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _context.comm.ExecuteAsync("STD_COURS_package.deleteSTD_COURS", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<STD_COURSE> Getall()
        {
            IEnumerable<STD_COURSE> result = _context.comm.Query<STD_COURSE>("STD_COURS_package.getallSTD_COURS", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public STD_COURSE GetallID(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _context.comm.Query<STD_COURSE>("STD_COURS_package.gettSTD_COURSbyid", parameter, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        public string Insert(STD_COURSE std_cours)
        {
            throw new NotImplementedException();
        }

        public bool Update(STD_COURSE std_cours)
        {
            throw new NotImplementedException();
        }
    }
}
