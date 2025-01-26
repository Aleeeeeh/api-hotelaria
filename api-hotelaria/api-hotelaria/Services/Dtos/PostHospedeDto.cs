using System.ComponentModel.DataAnnotations;

namespace api_hotelaria.Services.Dtos;

public class PostHospedeDto
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    public string Nome { get; set; } = null!;
    public string? Email { get; set; }
    [Required(ErrorMessage = "O telefone é obrigatório.")]
    public string? Telefone { get; set; } = null!;
    [Required(ErrorMessage = "A data de Nascimento é obrigatória.")]
    public DateOnly DataNascimento { get; set; }
    [Required(ErrorMessage = "O CPF é obrigatório.")]
    public string Cpf { get; set; } = null!;
    public string? Rg { get; set; }
    [Required(ErrorMessage = "O endereço é obrigatório.")]
    public string Endereco { get; set; } = null!;
    [Required(ErrorMessage = "O número é obrigatório.")]
    public int Numero { get; set; }
    public string? Complemento { get; set; }
    public string? Referencia { get; set; }
}
