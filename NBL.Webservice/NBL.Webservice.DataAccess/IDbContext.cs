using NBL.WebService.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBL.Webservice.DataAccess
{
    public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;

        /// <summary>
        /// Save changes
        /// </summary>
        /// <returns></returns>
        int SaveChanges();
        void ExecuteStoredProcedureInsert(string commandText, params object[] parameters);

        IList<TEntity> ExecuteStoredProcedureList<TEntity>(string commandText, params object[] parameters)
          where TEntity : BaseEntity;


        void FixEfProviderServicesProblem();
    }
}
