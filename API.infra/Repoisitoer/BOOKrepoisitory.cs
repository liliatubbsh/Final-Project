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
    class BOOKrepoisitory : IBOOKrepoisitory
    {

        private readonly Idbconction _context;

        public BOOKrepoisitory(Idbconction context)
        {
            _context = context;
        }

        public bool Delete(int id)
        {

            var p = new DynamicParameters();
            p.Add("idofbook", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _context.comm.ExecuteAsync("BOOK_package.deleteBOOK", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<BOOK> Getall()
        {

            IEnumerable<BOOK> result = _context.comm.Query<BOOK>("BOOK_package.getallBOOK", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public BOOK GetallID(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("idofbook", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _context.comm.Query<BOOK>("BOOK_package.gettBOOKbyid", parameter, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        public string Insert(BOOK book)
        {
            var p = new DynamicParameters();
            p.Add("idofbook", book.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("NAME", book.B_NAME, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PRICE", book.P_PRICE, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PUBLISHDATE", book.PUBLISHDATE, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _context.comm.ExecuteAsync("BOOK_package.InsertBOOK", p, commandType: CommandType.StoredProcedure);
            return "Valid";

        }

        public bool Update(BOOK book)
        {
            var p = new DynamicParameters();
            p.Add("idofbook", book.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("NAME", book.B_NAME, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PRICE", book.P_PRICE, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PUBLISHDATE", book.PUBLISHDATE, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _context.comm.ExecuteAsync("BOOK_package.updateBOOK", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
