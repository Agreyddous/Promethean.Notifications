using Promethean.Notifications.Messages;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Validators
{
	public partial class Validator
	{
		public Validator IsGreaterThan(decimal value, decimal comparer, string property, int code) => IsGreaterThan(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsGreaterThan(decimal value, decimal comparer, string property, INotificationMessage notification)
		{
			if (value <= comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsGreaterOrEqualTo(decimal value, decimal comparer, string property, int code) => IsGreaterOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsGreaterOrEqualTo(decimal value, decimal comparer, string property, INotificationMessage notification)
		{
			if (value < comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsLowerThan(decimal value, decimal comparer, string property, int code) => IsLowerThan(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsLowerThan(decimal value, decimal comparer, string property, INotificationMessage notification)
		{
			if (value >= comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsLowerOrEqualTo(decimal value, decimal comparer, string property, int code) => IsLowerOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsLowerOrEqualTo(decimal value, decimal comparer, string property, INotificationMessage notification)
		{
			if (value > comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator AreEqual(decimal value, decimal comparer, string property, int code) => AreEqual(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator AreEqual(decimal value, decimal comparer, string property, INotificationMessage notification)
		{
			if (!value.Equals(comparer))
				AddNotification(property, notification);

			return this;
		}

		public Validator IsBetween(decimal value, decimal from, decimal to, string property, int code) => IsBetween(value, from, to, property, NotificationMessage.ByCode(code));
		public Validator IsBetween(decimal value, decimal from, decimal to, string property, INotificationMessage notification)
		{
			if (value < from || value > to)
				AddNotification(property, notification);

			return this;
		}
	}
}