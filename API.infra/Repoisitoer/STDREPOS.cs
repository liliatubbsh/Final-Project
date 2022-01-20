using API.core.Comn;
using API.core.Data;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace API.infra.Repoisitoer
{
    public class STDREPOS : STDRepoisitory
    {
        private readonly Idbconction  _context;

        public STDREPOS(Idbconction context)
        {
            _context = context;
        }

        public bool DeleteSTD(int id)
        {
           var p= new DynamicParameters();
            p.Add("idofstd", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _context.comm.ExecuteAsync("std_package.deletestd", p, commandType: CommandType.StoredProcedure);
            return true;

        }

        public List<STD> GetallSTD()
        {

            IEnumerable<STD> result = _context.comm.Query<STD>("std_package.getallstd", commandType: CommandType.StoredProcedure);
                return result.ToList();
        }

        public STD GetallSTDid(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("idofstudent", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _context.comm.Query<STD>("std_package.gettstdbyid", parameter, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        public string InsertSTD(STD std)
        {          
            var p = new DynamicParameters();
            p.Add("idofstd", null, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("fname", std.S_FNAME, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("lname", std.S_LNAME, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PRICE", std.C_PRICE, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("PARTHDATESTD", std.PARTHDATE, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("MARKSTD", std.MARK, dbType: DbType.Int32, direction: ParameterDirection.Input); 
            var result = _context.comm.ExecuteAsync("std_package.insertstd", p, commandType: CommandType.StoredProcedure);
            return "Valid";
            
        }


        public bool UpdateSTD(STD std)
        {

            var p = new DynamicParameters();
            p.Add("idofstd", std.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("fname", std.S_FNAME, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("lname", std.S_LNAME, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PRICE", std.C_PRICE, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("PARTHDATESTD", std.PARTHDATE, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("MARKSTD", std.MARK, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _context.comm.ExecuteAsync("std_package.updatestd", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
