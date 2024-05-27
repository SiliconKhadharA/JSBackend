using JSBackend.Client.Models;

namespace JSBackend.Client.ViewModel;

public class AccountDetailsViewModel
{
    public BasicInfoModel? BasicInfo { get; set; }

    public AccountAddressModel? AccountAddress { get; set; }
}
