using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Infrastructure ;
using DataModel;

namespace Data.Repositories
{
    public class ComplainTypeRepository : RepositoryBase<ComplainType>, IComplainTypeRepository
    {
        public ComplainTypeRepository(IDatabaseFactory dbFactory): base(dbFactory)
        {

        }
    }

    public interface IComplainTypeRepository : IRepository<ComplainType>
    {

    }
}
