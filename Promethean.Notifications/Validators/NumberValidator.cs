namespace Promethean.Notifications.Validators
{
	public partial class Validator
	{
		public Validator IsGreaterThan(decimal value, decimal comparer, string property, NotificationMessage notification)
		{
			if (value <= comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsGreaterOrEqualTo(decimal value, decimal comparer, string property, NotificationMessage notification)
		{
			if (value < comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsLowerThan(decimal value, decimal comparer, string property, NotificationMessage notification)
		{
			if (value >= comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsLowerOrEqualTo(decimal value, decimal comparer, string property, NotificationMessage notification)
		{
			if (value > comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator AreEqual(decimal value, decimal comparer, string property, NotificationMessage notification)
		{
			if (!value.Equals(comparer))
				AddNotification(property, notification);

			return this;
		}

		public Validator IsBetween(decimal value, decimal from, decimal to, string property, NotificationMessage notification)
		{
			if (value < from || value > to)
				AddNotification(property, notification);

			return this;
		}
	}
}