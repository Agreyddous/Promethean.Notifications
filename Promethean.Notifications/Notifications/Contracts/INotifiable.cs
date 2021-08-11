using System;
using System.Collections.Generic;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Contracts
{
	public interface INotifiable
	{
		bool Valid { get; }
		IReadOnlyDictionary<string, IReadOnlyCollection<INotificationMessage>> Notifications { get; }

		INotifiable AddNotification(string property, INotificationMessage message);
		INotifiable AddNotification(INotification notification);
		INotifiable AddNotification(Exception exception);

		INotifiable AddNotifications(IEnumerable<KeyValuePair<string, IReadOnlyCollection<INotificationMessage>>> notifications);
		INotifiable AddNotifications(INotifiable item);
		INotifiable AddNotifications(params INotifiable[] items);
	}
}