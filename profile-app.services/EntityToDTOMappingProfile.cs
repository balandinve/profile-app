using AutoMapper;
using profile.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace profile_app.services
{
    public class EntityToDTOMappingProfile: AutoMapper.Profile
    {
        public override string ProfileName
        {
            get { return "EntityToDTOMappingProfile"; }
        }
        public EntityToDTOMappingProfile()
        {
            CreateMap<profile.data.Profile, ProfileDTO>();
            CreateMap<City, CityDTO>();
        }
    }
}
