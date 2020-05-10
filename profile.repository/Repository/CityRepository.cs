using profile.data;
using System;
using System.Collections.Generic;
using System.Text;
using static profile.repository.IRepository;

namespace profile.repository
{
    public interface ICityRepository : IRepository<City, int>
    {

    }
    public class CityRepository : Repository<City, int>, ICityRepository
    {
        public CityRepository(UnitOfWork context) : base(context)
        {

        }
    }
}
