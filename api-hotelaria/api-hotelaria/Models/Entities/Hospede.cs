﻿using System.ComponentModel.DataAnnotations;

namespace api_hotelaria.Models.Entities;

public class Hospede
{
    public int Id { get; set; }
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
    public DateOnly DataCadastro { get; set; }
    public TimeOnly HoraCadastro { get; set; }
    public DateOnly DataAtualizacao { get; set; }
    public TimeOnly HoraAtualizacao { get; set; }
    public bool EstaAtivo { get; set; }
}
