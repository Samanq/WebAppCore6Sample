using System.ComponentModel.DataAnnotations;

namespace WebAppCore6Sample.Api.Entities;

public class Product
{
    [Key]
    public long Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public double Price { get; set; }
}
