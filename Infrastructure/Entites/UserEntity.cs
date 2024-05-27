

using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Entites;

public class UserEntity : IdentityUser
{


    [ProtectedPersonalData]

    public string FirstName { get; set; } = null!;

    [ProtectedPersonalData]

    public string LastName { get; set; } = null!;


    [ProtectedPersonalData]

    public string? Bio { get; set; }

    public string? ProfileImage { get; set; } = "avatar1.jpg";

    public bool IsExtrernal { get; set; }

    public ICollection<AddressEntity> Addresses { get; set; } = [];

}
