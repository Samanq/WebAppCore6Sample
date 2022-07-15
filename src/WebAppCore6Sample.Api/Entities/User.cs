using System.ComponentModel.DataAnnotations;

namespace WebAppCore6Sample.Api.Entities;

public class User
{
    [Key]
    [Required]
    public long Id { get; set; }

    [Required]
    [StringLength(50)]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = string.Empty;

    [Required]
    public byte[] PasswordHash { get; set; }

    [Required]
    public byte[] PasswordSalt { get; set; }

    public string? RefreshToken { get; set; }

    public DateTime? RefreshTokenExpiry { get; set; }
}
