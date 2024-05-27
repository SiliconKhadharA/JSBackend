using System.ComponentModel.DataAnnotations;

namespace JSBackend.Client.Models;

public class NotificationSettingsModel
{
	[Required]
	[EmailAddress]
	public string PreferredEmail { get; set; } = string.Empty;

	public bool IsSubscribedToNewsletter { get; set; }

	public bool IsDarkMode { get; set; }
}
