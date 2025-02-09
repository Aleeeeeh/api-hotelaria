using api_hotelaria.Models.Entities;
using api_hotelaria.Services;
using api_hotelaria.Services.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace api_hotelaria.Controllers;

[ApiController]
[Route("reservas")]
public class ReservaController(ReservaService service) : ControllerBase
{
    private readonly ReservaService _service = service;

    [HttpPost]
    public async Task<ActionResult<Reserva>> CriarReserva(PostReservaDto dto)
    {
        try
        {
            return StatusCode(201, await _service.CriarReserva(dto));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
