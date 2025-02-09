using api_hotelaria.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace api_hotelaria.Models.Entities;

public class Reserva
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Informe o hóspede")]
    public int Hospede { get; set; }
    [Required(ErrorMessage = "Informe o quarto")]
    public int Quarto { get; set; }
    public DateOnly CheckIn { get; set; }
    public DateOnly CheckOut { get; set; }
    public Status Status { get; set; }
    public DateOnly DataCadastro { get; set; }
    public TimeOnly HoraCadastro { get; set; }
}
