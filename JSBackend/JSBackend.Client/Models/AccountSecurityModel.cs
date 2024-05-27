using System.ComponentModel.DataAnnotations;

namespace JSBackend.Client.Models;

public class AccountSecurityModel
{
	
	[DataType(DataType.Password)]
	[Required]
	public string? CurrentPassword { get; set; } 

	[DataType(DataType.Password)]
	[Required]
	[RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,}$", ErrorMessage = "Invalid Password, must be a strong password")]
	public string? NewPassword { get; set; } 

	[Required]
	public string? ConfirmPassword { get; set; }
}
