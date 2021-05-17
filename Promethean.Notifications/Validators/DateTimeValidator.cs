using System;
namespace Promethean.Notifications.Validators
{
	public partial class Validator
	{
		public Validator IsGreaterThan(DateTime value, DateTime comparer, string property, NotificationMessage notification)
		{
			if (value <= comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsGreaterOrEqualTo(DateTime value, DateTime comparer, string property, NotificationMessage notification)
		{
			if (value < comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsLowerThan(DateTime value, DateTime comparer, string property, NotificationMessage notification)
		{
			if (value >= comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsLowerOrEqualTo(DateTime value, DateTime comparer, string property, NotificationMessage notification)
		{
			if (value > comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsBetween(DateTime value, DateTime from, DateTime to, string property, NotificationMessage notification)
		{
			if (!(value > from && value < to))
				AddNotification(property, notification);

			return this;
		}

	}
}