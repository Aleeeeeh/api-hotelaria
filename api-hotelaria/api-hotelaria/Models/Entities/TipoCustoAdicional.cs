using System.ComponentModel.DataAnnotations;

namespace api_hotelaria.Models.Entities;

public class TipoCustoAdicional
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Informe a descrição do tipo de custo adicional")]
    public string Descricao { get; set; } = null!;
    public bool EstaAtivo { get; set; }
}
