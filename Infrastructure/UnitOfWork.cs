using ResourceMetadata.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure 
{
    public class UnitOfWork : IUnitOfWork
    {
        private ComplainManagerEntities dbContext;
        private readonly IDatabaseFactory dbFactory;
        protected ComplainManagerEntities DbContext
        {
            get
            {
                return dbContext ?? dbFactory.Get();
            }
        }

        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public void SaveChanges()
        {
            DbContext.SaveChanges();
        }
    }
}
