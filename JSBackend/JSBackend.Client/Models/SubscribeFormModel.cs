using System.ComponentModel.DataAnnotations;

namespace JSBackend.Client.Models;

public class SubscribeFormModel
{
    [Required(ErrorMessage = "You must provide an email address")]
    [EmailAddress]
    public string Email { get; set; } = null!;

    public bool DailyNewsletter { get; set; }

    public bool AdvertisingUpdates { get; set; }

    public bool WeekInReview { get; set; }

    public bool EventUpdates { get; set; }

    public bool StartupWeekly { get; set; }

    public bool Podcasts { get; set; }
}
