using api_hotelaria.Models.Entities;
using api_hotelaria.Models.Enums;
using api_hotelaria.Services.Dtos;
using AutoMapper;

namespace api_hotelaria.Services;

public class ReservaService(Context context, IMapper mapper, QuartoService quartoService, PagamentoService pagamentoService)
{
    private readonly Context _context = context;
    private readonly IMapper _mapper = mapper;
    private readonly QuartoService _quartoService = quartoService;
    private readonly PagamentoService _pagamentoService = pagamentoService;

    public async Task<Reserva> CriarReserva(PostReservaDto dto)
    {
        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            Reserva reserva = _mapper.Map<Reserva>(dto);

            reserva.Status = Status.Confirmada;
            reserva.DataCadastro = DateOnly.FromDateTime(DateTime.Now);
            reserva.HoraCadastro = TimeOnly.FromDateTime(DateTime.Now);

            await _context.Reservas.AddAsync(reserva);
            await _context.SaveChangesAsync();

            await _quartoService.VerificarSeQuartoEstaDisponivel(reserva.Quarto, reserva.CheckIn, reserva.CheckOut);

            Quarto quarto = await _quartoService.ObterQuartoPorId(reserva.Quarto);

            PostPagamentoDto pagamentoDto = new()
            {
                Reserva = reserva.Id,
                ValorTotal = quarto.ValorDiaria,
                FormaPagamento = dto.FormaPagamento
            };

            await _pagamentoService.CriarPagamento(pagamentoDto);

            await transaction.CommitAsync();

            return reserva;
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }
    }
}
