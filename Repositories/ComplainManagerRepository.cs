using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Infrastructure ;
using DataModel;

namespace Data.Repositories
{
    public class ComplainManagerRepository : RepositoryBase<ComplainMaster>, IComplainManagerRepository
    {
        public ComplainManagerRepository(IDatabaseFactory dbFactory): base(dbFactory)
        {

        }
    }

    public interface IComplainManagerRepository : IRepository<ComplainMaster>
    {

    }
}
