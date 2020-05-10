using profile.data;
using System;
using System.Collections.Generic;
using System.Text;
using static profile.repository.IRepository;

namespace profile.repository
{
    public interface IProfileRepository: IRepository<Profile, int> {
    }
    public class ProfileRepository:  Repository<Profile, int>, IProfileRepository
    {
        public ProfileRepository(UnitOfWork context): base(context) { }
    }
}
