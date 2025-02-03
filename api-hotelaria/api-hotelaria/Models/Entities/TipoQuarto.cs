using System.ComponentModel.DataAnnotations;

namespace api_hotelaria.Models.Entities;

public class TipoQuarto
{
    public int Id { get; set; }
    [Required(ErrorMessage = "A descrição do tipo de quarto é obrigatória.")]
    public string Descricao { get; set; } = null!;
    public bool EstaAtivo { get; set; }
}
