using System;
using System.Collections.Generic;
using System.Linq;

namespace Promethean.Notifications
{
	public abstract class Notifiable : INotifiable
	{
		private List<Notification> _notifications;

		protected Notifiable() => _notifications = new List<Notification>();

		public bool Valid => Notifications.Count == 0;

		public IReadOnlyCollection<Notification> Notifications => _notifications.AsReadOnly();

		public void AddNotification(string property, NotificationMessage message) => AddNotification(new Notification(property, message));
		public void AddNotification(Exception exception) => AddNotification(new Notification(exception));
		public void AddNotification(Notification notification) => _notifications.Add(notification);
		public void AddNotifications(IEnumerable<Notification> notifications) => _notifications = _notifications.Concat(notifications ?? Array.Empty<Notification>()).ToList();
		public void AddNotifications(Notifiable item) => AddNotifications(item?.Notifications);
		public void AddNotifications(params Notifiable[] items)
		{
			foreach (Notifiable item in items)
				AddNotifications(item);
		}
	}
}