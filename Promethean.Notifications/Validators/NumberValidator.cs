namespace Promethean.Notifications.Validators
{
	public partial class Validator
	{
		public Validator IsGreaterThan(double value, double comparer, string property, NotificationMessage notification)
		{
			if (value <= comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsGreaterOrEqualTo(double value, double comparer, string property, NotificationMessage notification)
		{
			if (value < comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsLowerThan(double value, double comparer, string property, NotificationMessage notification)
		{
			if (value >= comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsLowerOrEqualTo(double value, double comparer, string property, NotificationMessage notification)
		{
			if (value > comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator AreEqual(double value, double comparer, string property, NotificationMessage notification)
		{
			if (value != comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsBetween(double value, double from, double to, string property, NotificationMessage notification)
		{
			if (value < from || value > to)
				AddNotification(property, notification);

			return this;
		}
	}
}