using System.ComponentModel.DataAnnotations;

namespace api_hotelaria.Models.Entities;

public class Quarto
{
    public int Id { get; set; }
    [Required(ErrorMessage = "A descrição do quarto é obrigatória.")]
    public string Descricao { get; set; } = null!;
    [Required(ErrorMessage = "O valor da diária é obrigatório.")]
    public decimal ValorDiaria { get; set; }
    [Required(ErrorMessage = "O número do quarto é obrigatório.")]
    public int NumeroQuarto { get; set; }
    [Required(ErrorMessage = "O tipo do quarto é obrigatório.")]
    public string TipoQuarto { get; set; } = null!;
    public bool EstaAtivo { get; set; }
}
