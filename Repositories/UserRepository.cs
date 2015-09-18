using Data.Infrastructure;
using DataModel;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {

        public UserRepository(IDatabaseFactory dbFactory): base(dbFactory)
        {

        } 
    }


    public interface IUserRepository : IRepository<User>
    { 
    }
}
