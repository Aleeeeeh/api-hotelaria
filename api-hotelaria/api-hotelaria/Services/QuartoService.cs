using api_hotelaria.Models.Entities;
using api_hotelaria.Models.Enums;
using api_hotelaria.Services.Dtos;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace api_hotelaria.Services;

public class QuartoService(Context context, IMapper mapper)
{
    private readonly Context _context = context;
    private readonly IMapper _mapper = mapper;

    public async Task<Quarto> CadastrarQuarto(PostQuartoDto dto)
    {
        Quarto quarto = _mapper.Map<Quarto>(dto);

        quarto.EstaAtivo = true;

        await _context.Quartos.AddAsync(quarto);
        await _context.SaveChangesAsync();

        return quarto;
    }

    public async Task AtualizarQuarto(UpdateQuartoDto dto)
    {
        Quarto? quartoCadastrado = await ObterQuartoPorId(dto.Id);

        if (quartoCadastrado == null)
            throw new InvalidOperationException("Quarto não encontrado.");

        Quarto quarto = _mapper.Map(dto, quartoCadastrado);

        _context.Quartos.Update(quarto);
        await _context.SaveChangesAsync();
    }

    public async Task<Quarto> ObterQuartoPorId(int id)
    {
        Quarto quarto = await _context.Quartos.Where(q => q.Id == id).FirstOrDefaultAsync() ?? throw new InvalidOperationException("Quarto não encontrado.");

        return quarto;
    }

    public async Task<List<Quarto>> ObterQuartos()
    {
        return await _context.Quartos.ToListAsync();
    }

    public async Task<bool> VerificarSeQuartoEstaDisponivel(int id, DateOnly checkin, DateOnly checkout)
    {
        bool quartoJaReservado = await _context.Reservas.AnyAsync(r =>
        r.Quarto == id &&
        (r.Status == Status.Confirmada || r.Status == Status.Expirada) &&
        (
            (checkin >= r.CheckIn && checkin < r.CheckOut) ||
            (checkout > r.CheckIn && checkout <= r.CheckOut) ||
            (checkin <= r.CheckIn && checkout >= r.CheckOut)
        ));

        if (quartoJaReservado)
            throw new InvalidOperationException("O quarto já está reservado.");

        return true;
    }
}
