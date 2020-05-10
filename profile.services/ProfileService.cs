using AutoMapper;
using profile.data;
using profile.repository;
using System;
using System.Collections.Generic;

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
            return repo.Add(mapper.Map<data.Profile>(item));
        }

        public IList<ProfileDTO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
