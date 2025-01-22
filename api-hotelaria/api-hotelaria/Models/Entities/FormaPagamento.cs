using System.ComponentModel.DataAnnotations;

namespace api_hotelaria.Models.Entities;

public class FormaPagamento
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Informe a descrição da forma de pagamento")]
    public string Descricao { get; set; } = null!;
    public bool EstaAtivo { get; set; }
}
