using api_hotelaria.Models.Entities;
using api_hotelaria.Services.Dtos;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace api_hotelaria.Services;

public class HospedeService(Context context, IMapper mapper)
{
    private readonly Context _context = context;
    private readonly IMapper _mapper = mapper;

    public async Task<Hospede> CadastrarHospede(PostHospedeDto dto)
    {
        Hospede hospede = _mapper.Map<Hospede>(dto);
        Hospede? hospedeExiste = await ConsultarHospedePorCpf(hospede.Cpf);

        if (hospedeExiste != null)
            throw new InvalidOperationException("Hóspede já cadastrado.");

        hospede.DataCadastro = DateOnly.FromDateTime(DateTime.Now);
        hospede.HoraCadastro = TimeOnly.FromDateTime(DateTime.Now);

        await _context.Hospedes.AddAsync(hospede);
        await _context.SaveChangesAsync();

        return hospede;
    }

    public (IEnumerable<Hospede> hospedes, int totalRegistros) ObterConsultaPaginadaDeHospedes(int paginaAtual, int itensPorPagina)
    {
        var totalPaginas = _context.Hospedes.Count() / itensPorPagina;

        IEnumerable<Hospede> hospedes = _context.Set<Hospede>()
            .OrderBy(h => h.Nome)
            .Skip((paginaAtual - 1) * itensPorPagina)
            .Take(itensPorPagina);

        return (hospedes, totalPaginas);
    }

    public async Task<Hospede?> ConsultarHospedePorCpf(string cpf)
    {
        return await _context.Hospedes.Where(h => h.Cpf == cpf).FirstOrDefaultAsync();
    }

    public async Task<string> AtualizarHospede(UpdateHospedeDto dto)
    {
        Hospede? hospedeCadastrado = ObterHospedePorId(dto.Id);

        if (hospedeCadastrado == null)
            throw new InvalidOperationException("Hóspede não encontrado.");

        Hospede hospede = _mapper.Map(dto, hospedeCadastrado);

        hospede.DataAtualizacao = DateOnly.FromDateTime(DateTime.Now);
        hospede.HoraAtualizacao = TimeOnly.FromDateTime(DateTime.Now);

        _context.Hospedes.Update(hospede);
        await _context.SaveChangesAsync();

        return "Hóspede atualizado com sucesso.";
    }

    public Hospede? ObterHospedePorId(int id)
    {
        return _context.Hospedes.Where(h => h.Id == id).FirstOrDefault();
    }
}
