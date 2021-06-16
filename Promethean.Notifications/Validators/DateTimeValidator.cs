using System;
using Promethean.Notifications.Messages;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Validators
{
	public partial class Validator
	{
		public Validator IsGreaterThan(DateTime value, DateTime comparer, string property, int code) => IsGreaterThan(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsGreaterThan(DateTime value, DateTime comparer, string property, INotificationMessage notification)
		{
			if (value <= comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsGreaterOrEqualTo(DateTime value, DateTime comparer, string property, int code) => IsGreaterOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsGreaterOrEqualTo(DateTime value, DateTime comparer, string property, INotificationMessage notification)
		{
			if (value < comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsLowerThan(DateTime value, DateTime comparer, string property, int code) => IsLowerThan(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsLowerThan(DateTime value, DateTime comparer, string property, INotificationMessage notification)
		{
			if (value >= comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsLowerOrEqualTo(DateTime value, DateTime comparer, string property, int code) => IsLowerOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsLowerOrEqualTo(DateTime value, DateTime comparer, string property, INotificationMessage notification)
		{
			if (value > comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsBetween(DateTime value, DateTime from, DateTime to, string property, int code) => IsBetween(value, from, to, property, NotificationMessage.ByCode(code));
		public Validator IsBetween(DateTime value, DateTime from, DateTime to, string property, INotificationMessage notification)
		{
			if (!(value > from && value < to))
				AddNotification(property, notification);

			return this;
		}

	}
}