using api_hotelaria.Models.Entities;
using api_hotelaria.Models.Enums;
using api_hotelaria.Services.Dtos;
using AutoMapper;

namespace api_hotelaria.Services;

public class PagamentoService(Context context, IMapper mapper)
{
    private readonly Context _context = context;
    private readonly IMapper _mapper = mapper;

    public async Task<Pagamento> CriarPagamento(PostPagamentoDto dto)
    {
        Pagamento pagamento = _mapper.Map<Pagamento>(dto);

        pagamento.StatusPagamento = StatusPagamento.Pendente;

        await _context.Pagamentos.AddAsync(pagamento);
        await _context.SaveChangesAsync();

        return pagamento;
    }
}
