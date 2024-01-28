using com.npo.business.model;
using Com.Npo.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Npo.Data.Repositories
{
    public interface IPeopleRepository : IRepository<Person>
    {

    }
    public class PeopleRepository : GenericRepository<Person>, IPeopleRepository
    {
        public PeopleRepository(DbContext context, ILogger logger, string currentUserEmailId) : base(context, logger, currentUserEmailId)
        {
        }

    }

    public interface IPersonAttributeRepository : IRepository<PersonAttribute>
    {

    }
    public class PersonAttributeRepository : GenericRepository<PersonAttribute>, IPersonAttributeRepository
    {
        public PersonAttributeRepository(DbContext context, ILogger logger, string currentUserEmailId) : base(context, logger, currentUserEmailId)
        {
        }

    }
}
