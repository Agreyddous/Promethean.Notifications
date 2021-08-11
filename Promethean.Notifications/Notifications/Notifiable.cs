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
		private Dictionary<string, ICollection<INotificationMessage>> _notifications;

		protected Notifiable() => _notifications = new Dictionary<string, ICollection<INotificationMessage>>();

		[JsonIgnore]
		public bool Valid => Notifications.Count == 0;

		[JsonIgnore]
		public IReadOnlyDictionary<string, IReadOnlyCollection<INotificationMessage>> Notifications => _notifications.ToDictionary(notification => notification.Key, notification => (IReadOnlyCollection<INotificationMessage>)notification.Value.ToList().AsReadOnly());

		public INotifiable AddNotification(string property, INotificationMessage message)
		{
			if (!_notifications.ContainsKey(property))
				_notifications.Add(property, new List<INotificationMessage>());

			_notifications[property].Add(message);

			return this;
		}

		public INotifiable AddNotification(INotification notification) => AddNotification(notification.Property, notification.Message);
		public INotifiable AddNotification(Exception exception) => AddNotification(new Notification(exception));


		public INotifiable AddNotifications(IEnumerable<KeyValuePair<string, IReadOnlyCollection<INotificationMessage>>> notifications)
		{
			_notifications = notifications != null ? Notifications.Concat(notifications).ToDictionary(notification => notification.Key, notification => (ICollection<INotificationMessage>)notification.Value.ToList()) : _notifications;

			return this;
		}

		public INotifiable AddNotifications(INotifiable item) => AddNotifications(item?.Notifications);
		public INotifiable AddNotifications(params INotifiable[] items) => AddNotifications(items.SelectMany(item => item?.Notifications));
	}
}