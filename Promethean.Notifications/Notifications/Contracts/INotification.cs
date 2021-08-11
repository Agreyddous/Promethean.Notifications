using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Contracts
{
	public interface INotification
	{
		string Property { get; }
		INotificationMessage Message { get; }
	}
}