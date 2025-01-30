using api_hotelaria.Models.Entities;
using api_hotelaria.Services.Dtos;
using AutoMapper;

namespace api_hotelaria.Profiles;

public class HospedeProfile : Profile
{
    public HospedeProfile()
    {
        CreateMap<PostHospedeDto, Hospede>();
        CreateMap<UpdateHospedeDto, Hospede>();
    }
}
