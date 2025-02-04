using api_hotelaria.Models.Entities;
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
        quarto.EstaReservado = false;

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

    public async Task<Quarto?> ObterQuartoPorId(int id)
    {
        return await _context.Quartos.Where(q => q.Id == id).FirstOrDefaultAsync();
    }

    public async Task<List<Quarto>> ObterQuartoDisponiveis()
    {
        return await _context.Quartos.Where(q => q.EstaReservado == false).ToListAsync();
    }
}
