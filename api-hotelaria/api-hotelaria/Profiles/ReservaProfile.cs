using api_hotelaria.Models.Entities;
using api_hotelaria.Services.Dtos;
using AutoMapper;

namespace api_hotelaria.Profiles;

public class ReservaProfile : Profile
{
    public ReservaProfile()
    {
        CreateMap<PostReservaDto, Reserva>();
    }
}
