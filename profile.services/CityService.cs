using AutoMapper;
using profile.data;
using profile.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace profile.services
{
    public interface ICityService
    {
        IList<CityDTO> GetAll();
    }
    public class CityService: ICityService
    {
        private ICityRepository repo;
        private IMapper mapper;

        public CityService(ICityRepository repo, IMapper mapper )
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public IList<CityDTO> GetAll()
        {
            return mapper.Map<List<CityDTO>>(repo.GetAll(w => w.DeletedDate is null));
        }
    }
}
