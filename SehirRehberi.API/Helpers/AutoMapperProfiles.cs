using SehirRehberi.API.Dtos;
using SehirRehberi.API.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SehirRehberi.API.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<City, CityForListDto>().ForMember(dest => dest.PhotoUrl, opt =>
            {
                opt.MapFrom(src=>src.Photos.FirstOrDefault(x=>x.IsMain).Url);
            });

            CreateMap<City, CityForDetailDto>();
            CreateMap<PhotoForCreationDto, Photo>();
            CreateMap<PhotoForReturnDto, Photo>();
        }
    }
}
