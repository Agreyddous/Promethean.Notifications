using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Promethean.Notifications.Contracts;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications
{
	public abstract class Notifiable : INotifiable
	{
		private List<INotification> _notifications;

		protected Notifiable() => _notifications = new List<INotification>();

		[JsonIgnore]
		public bool Valid => Notifications.Count == 0;

		[JsonIgnore]
		public IReadOnlyCollection<INotification> Notifications => _notifications.AsReadOnly();

		public void AddNotification(string property, INotificationMessage message) => AddNotification(new Notification(property, message));
		public void AddNotification(Exception exception) => AddNotification(new Notification(exception));
		public void AddNotification(INotification notification) => _notifications.Add(notification);
		public void AddNotifications(IEnumerable<INotification> notifications) => _notifications = notifications != null ? _notifications.Concat(notifications).ToList() : _notifications;
		public void AddNotifications(INotifiable item) => AddNotifications(item?.Notifications);
		public void AddNotifications(params INotifiable[] items) => AddNotifications(items.SelectMany(item => item?.Notifications));
	}
}