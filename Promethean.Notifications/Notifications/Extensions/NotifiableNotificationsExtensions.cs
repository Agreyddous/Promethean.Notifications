using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Extensions
{
	public static class NotifiableNotificationsExtensions
	{
		public static IEnumerable<ValidationResult> AsValidationResult(this IReadOnlyDictionary<string, IReadOnlyCollection<INotificationMessage>> notifications) => notifications.SelectMany(notification => notification.Value.Select(message => new ValidationResult(message.Message, new[] { notification.Key })));
	}
}