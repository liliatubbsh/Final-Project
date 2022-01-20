using API.core.Comn;
using Oracle.ManagedDataAccess.Client;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Data;

namespace API.infra.common
{
    public class dbContextcs : Idbconction
    {
        private DbConnection _connection;
        private readonly IConfiguration configuration;
        public dbContextcs(IConfiguration configuration)
        {
            this.configuration = configuration;

        }
        public DbConnection comm { get {

                if (_connection == null)
                {

                    _connection = new OracleConnection(configuration[("ConnectionStrings:DefaultConnection")]);
                    _connection.Open();
                }
                else if (_connection.State != ConnectionState.Open) {
                    _connection.Open();
                }
                return _connection;
            }  }


    }
}
