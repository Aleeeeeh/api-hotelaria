using api_hotelaria.Models.Entities;
using api_hotelaria.Services;
using api_hotelaria.Services.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace api_hotelaria.Controllers;

[ApiController]
[Route("hospedes")]
public class HospedeController(HospedeService service) : ControllerBase
{
    private readonly HospedeService _service = service;

    [HttpPost]
    public async Task<IActionResult> CadastrarHospede([FromBody] PostHospedeDto dto)
    {
        try
        {
            return StatusCode(201, await _service.CadastrarHospede(dto));
        }
        catch (InvalidOperationException ex)
        {
            return StatusCode(409, ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao cadastrar hóspede. Log: {ex.Message}");
        }
    }

    [HttpGet("consulta-por-cpf")]
    public async Task<IActionResult> ConsultarHospedePorCpf([FromQuery] string cpf)
    {
        try
        {
            Hospede? hospede = await _service.ConsultarHospedePorCpf(cpf);

            return StatusCode(200, hospede);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao consultar hóspede. Log: {ex.Message}");
        }
    }

    [HttpGet("consulta-paginada")]
    public async Task<IActionResult> ObterConsultaPaginaHospedes([FromQuery] int paginaAtual, [FromQuery] int itensPorPagina)
    {
        try
        {
            (IEnumerable<Hospede> hospedes, int totalPaginas) = _service.ObterConsultaPaginadaDeHospedes(paginaAtual, itensPorPagina);

            return StatusCode(200, new { hospedes, totalPaginas });
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao obter consulta paginada de hóspedes. Log: {ex.Message}");
        }
    }
}
