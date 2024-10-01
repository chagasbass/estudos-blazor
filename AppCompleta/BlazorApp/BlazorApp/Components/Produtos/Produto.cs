using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Components.Produtos;

public class Produto
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Nome")]
    [Required(ErrorMessage = "O nome do produto é obrigatório.")]
    public string? Nome { get; set; }

    [Display(Name = "Categoria")]
    [Required(ErrorMessage = "A categoria é obrigatória.")]
    public string? Categoria { get; set; }


    [Display(Name = "Preço")]
    [Required(ErrorMessage = "O preço é obrigatório.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser válido.")]
    public decimal Preco { get; set; }

    [Display(Name = "Data de Validade")]
    [Required(ErrorMessage = "A data de validade é obrigatória.")]
    public DateTime DataValidade { get; set; }

    public Produto() { }
}