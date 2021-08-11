using System;
using Promethean.Notifications.Contracts;
using Promethean.Notifications.Messages;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications
{
	public class Notification : INotification
	{
		protected Notification() { }

		public Notification(string property, INotificationMessage notificationMessage)
		{
			Property = property;
			Message = notificationMessage;
		}

		public Notification(Exception exception)
		{
			Property = "Error";
			Message = new ExceptionNotificationMessage(exception);
		}

		public string Property { get; private set; }
		public INotificationMessage Message { get; private set; }
	}
}