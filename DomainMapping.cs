using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EClinicApi.Models;
using EClinicApi.DTO;

namespace EClinicApi
{
    public class DomainMapping : Profile
    {
        public DomainMapping()
        {
            CreateMap<UserProfile, UserProfileDTO>();
        }
    }
}
