using api_hotelaria.Models.Entities;
using api_hotelaria.Services.Dtos;
using AutoMapper;

namespace api_hotelaria.Profiles;

public class QuartoProfile : Profile
{
    public QuartoProfile()
    {
        CreateMap<PostQuartoDto, Quarto>();
        CreateMap<UpdateQuartoDto, Quarto>();
    }
}
