using api_hotelaria.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace api_hotelaria.Models.Entities;

public class Pagamento
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Informe o número da reserva")]
    public int Reserva { get; set; }
    [Required(ErrorMessage = "Informe o valor total")]
    public decimal ValorTotal { get; set; }
    [Required(ErrorMessage = "Informe a forma de pagamento")]
    public int FormaPagamento { get; set; }
    public StatusPagamento StatusPagamento { get; set; }
    public DateOnly DataPagamento { get; set; }
    public TimeOnly HoraPagamento { get; set; }
}
