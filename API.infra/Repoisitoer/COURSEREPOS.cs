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
 public class COURSEREPOS: ICOURCErepoisitory
    {
        private readonly Idbconction _context;

        public COURSEREPOS(Idbconction context)
        {
            _context = context;
        }

        public List<courspriceDTO> coursprice(int price)
        {
            var p = new DynamicParameters();
            p.Add("PRICE", price, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<courspriceDTO> result = _context.comm.Query<courspriceDTO>("COURS_package.GetCoursPRICEAndBOOK", p, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

        public bool deleteallCOURS()
        {
            var result = _context.comm.ExecuteAsync("COURS_package.deleteallCOURS", commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteCOURS(int id)
        {
            var p = new DynamicParameters();
            p.Add("idofCOURS", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _context.comm.ExecuteAsync("COURS_package.deleteCOURS", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<COURS> GetallCOURS()
        {
            IEnumerable<COURS> result = _context.comm.Query<COURS>("COURS_package.getallCOURS", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public COURS GetallCOURSID(int id)
        {
            var p = new DynamicParameters();
            p.Add("idofCOURSt", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<COURS> result = _context.comm.Query<COURS>("COURS_package.gettCOURSbyid", p, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();

        }

        public List<COURCDTO> getfnamePRICE()
        {
            throw new NotImplementedException();
        }

        public COURS gettCOURSbydec(int id)
        {
            var p = new DynamicParameters();
            p.Add("idofCOURS", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<COURS> result = _context.comm.Query<COURS>("COURS_package.gettCOURSbyid", p, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        public List<COURS> gettCOURSbyname(string name){
            var p = new DynamicParameters();
            p.Add("FName", name, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<COURS> result = _context.comm.Query<COURS>("COURS_package.gettCOURSbyname", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public COURS gettCOURSbynameandid(int id, string name)
        {
            var p = new DynamicParameters();
            p.Add("idofCOURS", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("FName", name, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<COURS> result = _context.comm.Query<COURS>("COURS_package.gettCOURSbynameandid", p, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
           
        }

        public string InsertCOURS(COURS cours)
        { 
            var p = new DynamicParameters();

          
            p.Add("FName", cours.C_NAME, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PRICE", cours.C_PRICE, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("STARTD", cours.STARTDATE, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ENDDA", cours.ENDDATE, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("IMGP", cours.IMAGEPATH, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _context.comm.Execute("COURS_package.insertCOURS", p, commandType: CommandType.StoredProcedure);
            return "Valid";

        }

        public List<CoursPRICEAndBOOKNameDTO> namepricebook()
        {
            IEnumerable<CoursPRICEAndBOOKNameDTO> result = _context.comm.Query<CoursPRICEAndBOOKNameDTO>("COURS_package.GetCoursPRICEAndBOOKName", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateCOURS(COURS cours)
        {
            var p = new DynamicParameters();

            p.Add("idofCOURS", cours.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("FName", cours.C_NAME, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PRICE", cours.C_PRICE, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("STARTD", cours.STARTDATE, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ENDDA", cours.ENDDATE, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("IMGP", cours.IMAGEPATH, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _context.comm.ExecuteAsync("COURS_package.updateCOURS", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        List<COURS> ICOURCErepoisitory.gettCOURSbydec(int id)
        {
            throw new NotImplementedException();
        }
    }
}
