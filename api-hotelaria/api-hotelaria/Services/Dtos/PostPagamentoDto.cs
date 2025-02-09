using System.ComponentModel.DataAnnotations;

namespace api_hotelaria.Services.Dtos;

public class PostPagamentoDto
{
    [Required(ErrorMessage = "Reserva é obrigatória")]
    public int Reserva { get; set; }
    [Required(ErrorMessage = "Informe o valor total")]
    public decimal ValorTotal { get; set; }
    [Required(ErrorMessage = "Informe a forma de pagamento")]
    public int FormaPagamento { get; set; }
}
