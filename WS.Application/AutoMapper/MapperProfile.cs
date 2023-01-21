using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WS.Application.TopicService.Dtos;
using WS.Application.UserService.Dtos;
using WS.Data.Entities;

namespace WS.Application.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Topic, TopicViewModel>().
                ForMember(v => v.TopicName, a => a.MapFrom(v => v.NameTopic));
            CreateMap<User, UserResponse>()
                .ForMember(v => v.IdUser, a => a.MapFrom(v => v.Id));
        }
    }
}