using System.ComponentModel.DataAnnotations;

namespace JSBackend.Client.Models;

public class AccountAddressModel
{
    [Display(Name = "Address Line 1", Prompt = "Enter your address line", Order = 0)]
    [Required(ErrorMessage = "Address is required")]

    public string Addressline_1 { get; set; } = null!;


    [Display(Name = "Address line 2", Prompt = "Enter your second address line", Order = 1)]
    public string? Addressline_2 { get; set; }

    [Display(Name = "Postal Code", Prompt = "Enter your Postal Code", Order = 2)]
    [Required(ErrorMessage = "Postal Code is required")]
    [DataType(DataType.PostalCode)]

    public string PostalCode { get; set; } = null!;


    [Display(Name = "City", Prompt = "Enter your City", Order = 3)]
    [Required(ErrorMessage = "City is required")]

    public string City { get; set; } = null!;
}
