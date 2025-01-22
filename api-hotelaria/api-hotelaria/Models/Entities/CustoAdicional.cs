using System.ComponentModel.DataAnnotations;

namespace api_hotelaria.Models.Entities;

public class CustoAdicional
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Informe a reserva")]
    public int Reserva { get; set; }
    [Required(ErrorMessage = "Informe o tipo de custo adicional")]
    public int TipoCusto { get; set; }
    [Required(ErrorMessage = "Informe o valor do custo adicional")]
    public decimal Valor { get; set; }
    public DateOnly DataCobranca { get; set; }
    public TimeOnly HoraCobranca { get; set; }
}
