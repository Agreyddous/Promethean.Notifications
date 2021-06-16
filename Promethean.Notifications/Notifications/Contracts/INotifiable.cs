using System;
using System.Collections.Generic;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Contracts
{
	public interface INotifiable
	{
		bool Valid { get; }
		IReadOnlyCollection<INotification> Notifications { get; }

		void AddNotification(string property, INotificationMessage message);
		void AddNotification(Exception exception);
		void AddNotification(INotification notification);
		void AddNotifications(IEnumerable<INotification> notifications);
		void AddNotifications(INotifiable item);
		void AddNotifications(params INotifiable[] items);
	}
}