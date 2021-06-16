using System;
using Promethean.Notifications.Messages;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Validators
{
	public partial class Validator
	{
		public Validator IsGreaterThan(TimeSpan value, TimeSpan comparer, string property, int code) => IsGreaterThan(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsGreaterThan(TimeSpan value, TimeSpan comparer, string property, INotificationMessage notification)
		{
			if (value <= comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsGreaterOrEqualTo(TimeSpan value, TimeSpan comparer, string property, int code) => IsGreaterOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsGreaterOrEqualTo(TimeSpan value, TimeSpan comparer, string property, INotificationMessage notification)
		{
			if (value < comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsLowerThan(TimeSpan value, TimeSpan comparer, string property, int code) => IsLowerThan(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsLowerThan(TimeSpan value, TimeSpan comparer, string property, INotificationMessage notification)
		{
			if (value >= comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsLowerOrEqualTo(TimeSpan value, TimeSpan comparer, string property, int code) => IsLowerOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsLowerOrEqualTo(TimeSpan value, TimeSpan comparer, string property, INotificationMessage notification)
		{
			if (value > comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsBetween(TimeSpan value, TimeSpan from, TimeSpan to, string property, int code) => IsBetween(value, from, to, property, NotificationMessage.ByCode(code));
		public Validator IsBetween(TimeSpan value, TimeSpan from, TimeSpan to, string property, INotificationMessage notification)
		{
			if (!(value > from && value < to))
				AddNotification(property, notification);

			return this;
		}

	}
}