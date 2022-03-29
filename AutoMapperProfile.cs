using AspNetCoreWebAPI.Dtos.Character;
using AspNetCoreWebAPI.Models;
using AutoMapper;

namespace AspNetCoreWebAPI
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character,GetCharacterDto>();
            CreateMap<AddCharacterDto,Character>();
        }
    }
}