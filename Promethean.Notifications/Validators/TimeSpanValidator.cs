using System;
using Promethean.Notifications.Messages;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Validators
{
	public partial class PrometheanValidator
	{
		public PrometheanValidator IsGreaterThan(TimeSpan value, TimeSpan comparer, string property, int code) => IsGreaterThan(value, comparer, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsGreaterThan(TimeSpan value, TimeSpan comparer, string property, INotificationMessage notification)
		{
			if (value <= comparer)
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator IsGreaterOrEqualTo(TimeSpan value, TimeSpan comparer, string property, int code) => IsGreaterOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsGreaterOrEqualTo(TimeSpan value, TimeSpan comparer, string property, INotificationMessage notification)
		{
			if (value < comparer)
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator IsLowerThan(TimeSpan value, TimeSpan comparer, string property, int code) => IsLowerThan(value, comparer, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsLowerThan(TimeSpan value, TimeSpan comparer, string property, INotificationMessage notification)
		{
			if (value >= comparer)
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator IsLowerOrEqualTo(TimeSpan value, TimeSpan comparer, string property, int code) => IsLowerOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsLowerOrEqualTo(TimeSpan value, TimeSpan comparer, string property, INotificationMessage notification)
		{
			if (value > comparer)
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator IsBetween(TimeSpan value, TimeSpan from, TimeSpan to, string property, int code) => IsBetween(value, from, to, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsBetween(TimeSpan value, TimeSpan from, TimeSpan to, string property, INotificationMessage notification)
		{
			if (!(value > from && value < to))
				AddNotification(property, notification);

			return this;
		}

	}
}