using Data.Infrastructure;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositoriesi
{
    public class TechnicianRepository : RepositoryBase<Technician>, ITechnicianRepository
    {

        public TechnicianRepository(IDatabaseFactory dbFactory): base(dbFactory)
        {

        } 
    }


    public interface ITechnicianRepository : IRepository<Technician>
    { 
    }
}
