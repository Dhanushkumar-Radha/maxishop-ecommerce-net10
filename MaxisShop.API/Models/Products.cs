using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaxisShop.API.Models;
public class Products
{
    [Required]
    public int? Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public Decimal? Price { get; set; }
    [Required]
    public DateOnly? ManufactureDate { get; set; }
    public bool? InStocks { get; set; }

    public string? Note { get; set; }
}