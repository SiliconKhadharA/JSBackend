using System.ComponentModel.DataAnnotations;

namespace JSBackend.Client.Models;

public class BasicInfoModel
{

    [Required]
    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [Required]
    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Phone]
    public string? Phone { get; set; }

    public string? Biography { get; set; }
}
