using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBL.Webservice.DataAccess
{
    public class SqlServerDataProvider:IDataProvider
    {

        public void InitConnectionFactory()
        {
            var connectionFactory = new SqlConnectionFactory();

#pragma warning disable 0618
            Database.DefaultConnectionFactory = connectionFactory;
        }

        public void SetDatabaseInitializer()
        {
            throw new NotImplementedException();
        }

        public void InitDatabase()
        {
            throw new NotImplementedException();
        }

        public bool StoredProceduredSupported { get; }
        public DbParameter GetParameter()
        {
            throw new NotImplementedException();
        }
    }
}

    