using api_hotelaria.Models.Entities;
using api_hotelaria.Services;
using api_hotelaria.Services.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace api_hotelaria.Controllers;

[ApiController]
[Route("quartos")]
public class QuartoController(QuartoService service) : ControllerBase
{
    private readonly QuartoService _service = service;

    [HttpPost]
    public async Task<IActionResult> CadastrarQuarto([FromBody] PostQuartoDto dto)
    {
        try
        {
            return StatusCode(201, await _service.CadastrarQuarto(dto));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao cadastrar quarto. Log: {ex.Message}");
        }
    }

    [HttpPut]
    public async Task<IActionResult> AtualizarQuarto([FromBody] UpdateQuartoDto dto)
    {
        try
        {
            await _service.AtualizarQuarto(dto);
            return StatusCode(204);
        }
        catch (InvalidOperationException ex)
        {
            return StatusCode(404, ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao atualizar quarto. Log: {ex.Message}");
        }
    }

    [HttpGet]
    public async Task<ActionResult<List<Quarto>>> ObterListaDeQuartos()
    {
        try
        {
            return StatusCode(200, await _service.ObterQuartos());
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao obter lista de quartos disponíveis. Log: {ex.Message}");
        }
    }
}
