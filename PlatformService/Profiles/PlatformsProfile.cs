using AutoMapper;
using PlatformService.DTOs;
using PlatformService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            CreateMap<Platform, PlatformReadDTOs>();
            CreateMap<PlatformCreateDTO, Platform>();
        }
    }
}
