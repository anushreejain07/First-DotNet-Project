using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreWebAPI.Dtos.Character;
using AspNetCoreWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebAPI.Services.CharacterService
{
    public interface ICharacterService
    {
         public Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacter(); //Get

         public Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id); //Get
         public Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter); //POST

         public Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);

         public Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);

         
    }
}