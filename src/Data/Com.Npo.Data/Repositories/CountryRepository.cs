using com.npo.business.model;
using com.npo.business.model.Base;
using Com.Npo.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Npo.Data.Repositories
{
    public interface ICountryRepository : IRepository<Country>
    {

    }
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DbContext context, ILogger logger, string currentUserEmailId) : base(context, logger, currentUserEmailId)
        {
        }

    }

    public interface IRegionRepository : IRepository<Region>
    {

    }
    public class RegionRepository : GenericRepository<Region>, IRegionRepository
    {
        public RegionRepository(DbContext context, ILogger logger, string currentUserEmailId) : base(context, logger, currentUserEmailId)
        {
        }

    }

    public interface ICityRepository : IRepository<City>
    {

    }
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        public CityRepository(DbContext context, ILogger logger, string currentUserEmailId) : base(context, logger, currentUserEmailId)
        {
        }

    }
}
