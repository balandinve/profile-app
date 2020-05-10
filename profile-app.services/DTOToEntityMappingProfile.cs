using profile.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace profile_app.services
{
    public class DTOToEntityMappingProfile: AutoMapper.Profile
    {
        public override string ProfileName
        {
            get { return "DTOToEntityMappingProfile"; }
        }
        public DTOToEntityMappingProfile()
        {
            CreateMap<ProfileDTO, Profile>();
            CreateMap<CityDTO, City>();
        }
    }
}
