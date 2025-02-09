using System.ComponentModel.DataAnnotations;

namespace api_hotelaria.Services.Dtos;

public class PostReservaDto
{
    [Required(ErrorMessage = "Informe o hóspede")]
    public int Hospede { get; set; }
    [Required(ErrorMessage = "Informe o quarto")]
    public int Quarto { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public int FormaPagamento { get; set; }
}
