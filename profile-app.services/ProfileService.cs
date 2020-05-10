using AutoMapper;
using profile.data;
using profile.repository;
using System;
using System.Collections.Generic;
using Profile = profile.data.Profile;

namespace profile.services
{
    public interface IProfileService
    {
        int Add(ProfileDTO item);

        IList<ProfileDTO> GetAll();
    }
    public class ProfileService : IProfileService
    {
        private IProfileRepository repo;
        private IMapper mapper;

        public ProfileService(IProfileRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        public int Add(ProfileDTO item)
        {
            var dto = mapper.Map<Profile>(item);
            return repo.Add(dto);
        }

        public IList<ProfileDTO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
